using MailKit;
using MailKit.Search;
using MailKit.Net.Imap;
using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;
using System.IO.Ports;
using System.Text;
using MailKit.Security;
using System.Collections.Generic;
using System.Management;

namespace rgb_strip_handler
{
    public partial class Home : MetroForm
    {
        SerialPort arduino = new SerialPort("COM11", 115200, Parity.None, 8, StopBits.One);

        Color c, savedColor = Color.Red;
        ImapClient client = new ImapClient();

        /* First elements in messages */
        const int SIMPLE_COLOR = 0;
        const int RAINBOW = 1;
        const int RAINBOW_CYCLE = 2;
        const int KNIGHT_RIDER = 3;
        const int FADE = 4;
        const int BLINK = 5;
        const int GET_TEMP = 6;
        const int OFF_DESK = 7;
        const int ON_DESK = 8;
        const int OFF_PRINTER = 9;
        const int ON_PRINTER = 10;

        /* File paths for saved things */
        const string pathColor = @".\color.txt";
        const string brightnessColor = @".\brightness.txt";
        const string pathSerial = @".\serial.txt";

        /* Email notify counter */
        int cnt = 1;

        /* Average temperature calculation */
        double sumTemp;
        double avgTemp;
        int tempCnt;

        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* Set main page */
            metroTabControl1.SelectedTab = metroTabPage1_light;

            /* Set individual chart design settigns */
            setChartSettings();

            try
            {
                /* Set event handler for incoming bytes from serial port */
                arduino.DataReceived += Arduino_DataReceived;

                /* Read previous color from file */
                readColor(pathColor);

                /* Read previous brightness from file */
                readBrightness();

                /* Read previous Port Name from file */
                readSerialSettings(pathSerial);

                /* Try connect */
                arduino.Open();

                /* Set active connection design */
                Style = MetroFramework.MetroColorStyle.Green;
                Refresh();
            }
            catch (Exception ex)
            {
                DialogResult result;
                result = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                if (result == DialogResult.Cancel)
                {
                    this.Close();
                }
                else if (result == DialogResult.Retry)
                {
                    arduino.Dispose();

                    metroLabel9.Text = "Sorry... please choose a COM port.";

                    metroTabControl1.SelectedTab = metroTabPage4_settings;

                    string[] portnames = SerialPort.GetPortNames();

                    foreach (string names in portnames)
                    {
                        port_names_cbox.Items.Add(names);
                    }

                    port_names_cbox.SelectedIndex = 0;
                }
            }

            if (arduino.IsOpen)
            {
                /* Save port name into file */
                saveSerialSettings(pathSerial, arduino.PortName);

                /* Set zero */
                notifyIcon1.Icon = CreateIcon(00);

                /* Get temperature */
                getTemp();

                /* Set previous color and brightness */
                String color = SIMPLE_COLOR.ToString() + "," + ((savedColor.R / 100) * metroTrackBar1.Value).ToString()
                                                       + "," + ((savedColor.G / 100) * metroTrackBar1.Value).ToString() 
                                                       + "," + ((savedColor.B / 100) * metroTrackBar1.Value).ToString() + ",\n";

                color_red_tbox.Text = colorWheel1.Color.R.ToString();
                color_green_tbox.Text = colorWheel1.Color.G.ToString();
                color_blue_tbox.Text = colorWheel1.Color.B.ToString();

                arduino.Write(color);
            }
        }

        private void Arduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string incoming = arduino.ReadLine();
            BeginInvoke(new LineReceivedEvent(LineReceived), incoming);
        }

        private delegate void LineReceivedEvent(string TEMP);

        private void LineReceived(string TEMP)
        {
            try
            {
                /* Add temperature to Chart and set notifyIcon */
                setTempNoty(TEMP);
            }
            catch (Exception)
            {
                /* Set zero */
                notifyIcon1.Icon = CreateIcon(00);

                /* Get temperature */
                getTemp();
            }
        }

        void setTempNoty(string TEMP)
        {
            string temp_double = TEMP.Substring(5, 5);
            double room_temp = Convert.ToDouble(temp_double.Replace(".", ","));

            chart1.Series["Szoba"].Points.AddXY(DateTime.Now.ToLongTimeString(), room_temp);

            temp_tbox.Text = room_temp.ToString();
            avgTemp_tbox.Text = averageTemperature(room_temp).ToString("N2");
            notifyIcon1.Icon = CreateIcon((int)room_temp);
        }

        private void Exit_Application(object Sender, EventArgs e)
        {
            notifyIcon1.Icon = null;
            Application.Exit();
        }

        public void saveColor(string path, Color selectedColor)
        {
            try
            {
                /* Delete the file if it exists. */
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                /* Create the file. */
                using (FileStream fs = File.Create(path))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes(selectedColor.ToArgb().ToString());

                    /* Write data to the file. */
                    fs.Write(info, 0, info.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("HIBA - " + ex.Message);
            }
        }

        public void saveBrightness(int brightnessValue)
        {
            try
            {
                /* Delete the file if it exists. */
                if (File.Exists(brightnessColor))
                {
                    File.Delete(brightnessColor);
                }

                /* Create the file. */
                using (FileStream fs = File.Create(brightnessColor))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes(brightnessValue.ToString());

                    /* Write data to the file. */
                    fs.Write(info, 0, info.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("HIBA - " + ex.Message);
            }
        }

        public void readBrightness()
        {
            try
            {
                if (File.Exists(brightnessColor))
                {
                    /* Open the stream and read it back. */
                    using (StreamReader sr = File.OpenText(brightnessColor))
                    {
                        string readBrightness = "";
                        while ((readBrightness = sr.ReadLine()) != null)
                        {
                            metroTrackBar1.Value = Int32.Parse(readBrightness);
                        }
                    }
                }
            }
            catch (Exception)
            {
                /* We have not color, set default */
                colorWheel1.Color = Color.White;
            }
        }

        public void readColor(string path)
        {
            try
            {
                if (File.Exists(pathColor))
                {
                    /* Open the stream and read it back. */
                    using (StreamReader sr = File.OpenText(path))
                    {
                        string readColor = "";
                        while ((readColor = sr.ReadLine()) != null)
                        {
                            savedColor = Color.FromArgb(Int32.Parse(readColor));
                            colorWheel1.Color = savedColor;
                        }
                    }
                }
            }
            catch (Exception)
            {
                /* We have not color, set default */
                colorWheel1.Color = Color.White;
            }
        }

        private void saveSerialSettings(string path, string portName)
        {
            try
            {
                /* Delete the file if it exists. */
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                /* Create the file. */
                using (FileStream fs = File.Create(path))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes(portName);

                    /* Write data to the file. */
                    fs.Write(info, 0, info.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("HIBA - " + ex.Message);
            }
        }

        public bool readSerialSettings(string path)
        {
            bool result = false;
            try
            {
                if (File.Exists(path))
                {
                    /* Open the stream and read it back. */
                    using (StreamReader sr = File.OpenText(path))
                    {
                        string comPortName = "";

                        while ((comPortName = sr.ReadLine()) != null)
                        {
                            arduino.PortName = comPortName;
                        }

                        result = true;
                    }
                }
            }
            catch (Exception)
            {
                // UOpS...
            }

            return result;
        }

        private Icon CreateIcon(int value)
        {
            if (value < 50)
            {
                c = Color.FromArgb(0, 255, 0);
            }
            else if (value >= 80)
            {
                c = Color.OrangeRed;
            }
            else
            {
                c = Color.Yellow;
            }

            using (Bitmap bm = new Bitmap(16, 16))
            {
                using (Graphics g = Graphics.FromImage(bm))
                {
                    using (Brush b = new SolidBrush(c))
                    {
                        g.DrawString(value.ToString(), SystemFonts.DefaultFont, b, 0, 0);
                        return Icon.FromHandle(bm.GetHicon());
                    }
                }
            }
        }

        private void setChartSettings()
        {
            temp_tbox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            celsius_lb.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);

            chart1.ChartAreas[0].AxisX.LineColor = Color.White;
            chart1.ChartAreas[0].AxisY.LineColor = Color.White;

            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;

            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Red;
            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Red;
        }

        private void getTemp()
        {
            try
            {
                String msg = GET_TEMP.ToString() + ",0,0,0\n";
                arduino.Write(msg);
            }
            catch (Exception) { }
        }

        private double averageTemperature(double receivedTemp)
        {
            tempCnt++;
            sumTemp += receivedTemp;
            avgTemp = sumTemp / tempCnt;

            return avgTemp;
        }

        private void colorWheel1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                int red, green, blue;

                red = ((int.Parse(color_red_tbox.Text) / 100) * metroTrackBar1.Value);
                green = ((int.Parse(color_green_tbox.Text) / 100) * metroTrackBar1.Value);
                blue = ((int.Parse(color_blue_tbox.Text) / 100) * metroTrackBar1.Value);

                String color = SIMPLE_COLOR.ToString() + "," + colorWheel1.Color.R.ToString() + "," + colorWheel1.Color.G.ToString() + "," + colorWheel1.Color.B.ToString() + ",\n";
                arduino.Write(color);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba","Nem sikerült beállítani a színt.\r\n" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                color_red_tbox.Text = colorWheel1.Color.R.ToString();
                color_green_tbox.Text = colorWheel1.Color.G.ToString();
                color_blue_tbox.Text = colorWheel1.Color.B.ToString();

                saveColor(pathColor, Color.FromArgb(colorWheel1.Color.A, colorWheel1.Color.R, colorWheel1.Color.G, colorWheel1.Color.B));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba", "Nem sikerült elmenteni a színt.\r\n" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void metroTrackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                int red, green, blue;

                red = ((int.Parse(color_red_tbox.Text) / 100) * metroTrackBar1.Value);
                green = ((int.Parse(color_green_tbox.Text) / 100) * metroTrackBar1.Value);
                blue = ((int.Parse(color_blue_tbox.Text) / 100) * metroTrackBar1.Value);

                saveColor(pathColor, Color.FromArgb(colorWheel1.Color.A, colorWheel1.Color.R, colorWheel1.Color.G, colorWheel1.Color.B));
                saveBrightness(metroTrackBar1.Value);

                String color = SIMPLE_COLOR.ToString() + "," + red.ToString() + "," + green.ToString() + "," + blue.ToString() + ",\n";
                arduino.Write(color);
            }
            catch (Exception) { }
        }

        private void rainbow_btn_Click(object sender, EventArgs e)
        {
            try
            {
                String color = RAINBOW.ToString() + ",0,0,0\n";
                arduino.Write(color);
            }
            catch (Exception) { }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rainbowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String color = RAINBOW.ToString() + ",0,0,0\n";
                arduino.Write(color);
            }
            catch (Exception) { }
        }

        private void rainbowCycleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String color = RAINBOW_CYCLE.ToString() + ",0,0,0\n";
                arduino.Write(color);
            }
            catch (Exception) { }
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String color = SIMPLE_COLOR.ToString() + "," + Color.Red.R.ToString() + "," + Color.Red.G.ToString() + "," + Color.Red.B.ToString() + ",\n";
                colorWheel1.Color = Color.Red;
                arduino.Write(color);
            }
            catch (Exception) { }
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String color = SIMPLE_COLOR.ToString() + "," + Color.Green.R.ToString() + "," + Color.Green.G.ToString() + "," + Color.Green.B.ToString() + ",\n";
                colorWheel1.Color = Color.Green;
                arduino.Write(color);
            }
            catch (Exception) { }
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String color = SIMPLE_COLOR.ToString() + "," + Color.Blue.R.ToString() + "," + Color.Blue.G.ToString() + "," + Color.Blue.B.ToString() + ",\n";
                colorWheel1.Color = Color.Blue;
                arduino.Write(color);
            }
            catch (Exception) { }
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String color = SIMPLE_COLOR.ToString() + "," + Color.White.R.ToString() + "," + Color.White.G.ToString() + "," + Color.White.B.ToString() + ",\n";
                colorWheel1.Color = Color.White;
                arduino.Write(color);
            }
            catch (Exception) { }
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String color = SIMPLE_COLOR.ToString() + "," + Color.Yellow.R.ToString() + "," + Color.Yellow.G.ToString() + "," + Color.Yellow.B.ToString() + ",\n";
                colorWheel1.Color = Color.Yellow;
                arduino.Write(color);
            }
            catch (Exception) { }
        }

        private void cyanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String color = SIMPLE_COLOR.ToString() + "," + Color.Cyan.R.ToString() + "," + Color.Cyan.G.ToString() + "," + Color.Cyan.B.ToString() + ",\n";
                colorWheel1.Color = Color.Cyan;
                arduino.Write(color);
            }
            catch (Exception) { }
        }

        private void Home_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                this.Hide();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void knight_rider_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Color rgb = colorWheel1.Color;

                String color = KNIGHT_RIDER.ToString() + "," + rgb.R.ToString() + "," + rgb.G.ToString() + "," + rgb.B.ToString() + ",\n";
                arduino.Write(color);
            }
            catch (Exception) { }
        }

        private void fade_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Color rgb = colorWheel1.Color;

                String color = FADE.ToString() + "," + rgb.R.ToString() + "," + rgb.G.ToString() + "," + rgb.B.ToString() + ",\n";
                arduino.Write(color);
            }
            catch (Exception) { }
        }

        private void blink_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Color rgb = colorWheel1.Color;

                String color = BLINK.ToString() + "," + rgb.R.ToString() + "," + rgb.G.ToString() + "," + rgb.B.ToString() + ",\n";
                arduino.Write(color);
            }
            catch (Exception) { }
        }

        private void emailTimer_Tick(object sender, EventArgs e)
        {
            if (client.IsConnected == true)
            {
                if (!client.Inbox.IsOpen)
                {
                    // open the Inbox folder...
                    client.Inbox.Open(FolderAccess.ReadOnly);
                }

                var uids = client.Inbox.Search(SearchQuery.NotSeen);

                if (uids.Count > 0)
                {
                    blink_btn_Click(sender, e);

                    /* start blinking stopper */
                    timer1.Enabled = true;
                }
                else
                {
                    readColor(pathColor);
                    String color = SIMPLE_COLOR.ToString() + "," + colorWheel1.Color.R.ToString() + "," + colorWheel1.Color.G.ToString() + "," + colorWheel1.Color.B.ToString() + ",\n";
                    arduino.Write(color);
                }
            }
            else
            {
                try
                {
                    client.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
                    client.Authenticate(email_tbox.Text, password_tbox.Text);
                }
                catch (Exception)
                {
                    client.Disconnect(true);
                    emailTimer.Enabled = false;
                }
            }
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroToggle1.CheckState == CheckState.Unchecked)
            {
                emailTimer.Enabled = false;
                client.Disconnect(true);
                readColor(pathColor);

                String color = SIMPLE_COLOR.ToString() + "," + colorWheel1.Color.R.ToString() + "," + colorWheel1.Color.G.ToString() + "," + colorWheel1.Color.B.ToString() + ",\n";
                arduino.Write(color);
            }
            else if (metroToggle1.CheckState == CheckState.Checked)
            {
                emailTimer.Enabled = true;
            }

        }        /// <summary>
        
        /// Email notifier.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            /* 5 másodperc után kikapcsoljuk ezt a timert és visszaállítjuk az eredeti színt,
             * hogy ne villogjon a végetelenségig 
             */
            if (cnt == 5)
            {
                timer1.Enabled = false;
                cnt = 1;

                readColor(pathColor);
                String color = SIMPLE_COLOR.ToString() + "," + colorWheel1.Color.R.ToString() + "," + colorWheel1.Color.G.ToString() + "," + colorWheel1.Color.B.ToString() + ",\n";
                arduino.Write(color);
            }

            cnt++;

        }

        private void knightRiderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Call button event from GUI */
            knight_rider_btn_Click(sender, e);
        }

        private void port_names_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            arduino.PortName = port_names_cbox.SelectedItem.ToString();
        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            try
            {
                arduino.Close();
                arduino.Dispose();

                arduino.PortName = port_names_cbox.SelectedItem.ToString();
            
                arduino.Open();

                Style = MetroFramework.MetroColorStyle.Green;
                Refresh();

                metroTabControl1.SelectedTab = metroTabPage1_light;

                saveSerialSettings(pathSerial, arduino.PortName);
            }
            catch (Exception ex)
            {
                Console.Write("HIBA - " + ex.Message);
            }
        }

        private void color_red_tbox_KeyDown(object sender, KeyEventArgs e)
        {
            /* Set color from textboxes */
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Color c = Color.FromArgb(int.Parse(color_red_tbox.Text), int.Parse(color_green_tbox.Text), int.Parse(color_blue_tbox.Text));

                    String color = SIMPLE_COLOR.ToString() + "," + c.R + "," + c.G + "," + c.B + ",\n";
                    colorWheel1.Color = c;

                    arduino.Write(color);
                }
                catch (Exception)
                {

                }
            }
        }

        private void color_green_tbox_KeyDown(object sender, KeyEventArgs e)
        {
            /* Set color from textboxes */
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Color c = Color.FromArgb(int.Parse(color_red_tbox.Text), int.Parse(color_green_tbox.Text), int.Parse(color_blue_tbox.Text));

                    String color = SIMPLE_COLOR.ToString() + "," + c.R + "," + c.G + "," + c.B + ",\n";
                    colorWheel1.Color = c;

                    arduino.Write(color);
                }
                catch (Exception)
                {

                }
            }
        }

        private void color_blue_tbox_KeyDown(object sender, KeyEventArgs e)
        {
            /* Set color from textboxes */
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Color tboxColor = Color.FromArgb(int.Parse(color_red_tbox.Text), int.Parse(color_green_tbox.Text), int.Parse(color_blue_tbox.Text));

                    string color = SIMPLE_COLOR.ToString() + "," + tboxColor.R.ToString() + "," + tboxColor.G.ToString() + "," + tboxColor.B.ToString() + ",\n";
                    colorWheel1.Color = tboxColor;

                    arduino.Write(color);
                }
                catch (Exception)
                {

                }
            }
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                // Disable the LED strip.
                string color = SIMPLE_COLOR.ToString() + ",0,0,0,\n";
                arduino.Write(color);

                System.Threading.Thread.Sleep(100);

                // Disable the Desklight.
                color = OFF_DESK.ToString() + ",0,0,0\n";
                arduino.Write(color);

                System.Threading.Thread.Sleep(100);

                // Disable 3D Printer light.
                color = OFF_PRINTER.ToString() + ",0,0,0\n";
                arduino.Write(color);
            }
            catch (Exception)
            {

            }
        }

        private void deskLight_toggle_CheckedChanged(object sender, EventArgs e)
        {
            if(deskLight_toggle.Checked == true)
            {
                try
                {
                    string color = ON_DESK.ToString() + ",0,0,0\n";
                    arduino.Write(color);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba", ex.Message);
                }
            }

            if (deskLight_toggle.Checked == false)
            {
                try
                {
                    string color = OFF_DESK.ToString() + ",0,0,0\n";
                    arduino.Write(color);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba", ex.Message);
                }
            }
        }

        private void rainbow_cycle_btn_Click(object sender, EventArgs e)
        {
            try
            {
                String color = RAINBOW_CYCLE.ToString() + ",0,0,0\n";
                arduino.Write(color);
            }
            catch (Exception) { }
        }
    }

    class USBDeviceInfo
    {
        public USBDeviceInfo(string deviceID, string pnpDeviceID, string description)
        {
            this.DeviceID = deviceID;
            this.PnpDeviceID = pnpDeviceID;
            this.Description = description;
        }

        public string DeviceID { get; private set; }
        public string PnpDeviceID { get; private set; }
        public string Description { get; private set; }
    }
}