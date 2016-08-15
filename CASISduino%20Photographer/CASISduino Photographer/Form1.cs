using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;//text file
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//for webcam
using AForge.Video;
using AForge.Video.DirectShow;
//screenshots
using System.Drawing.Imaging;
using System.Timers;


namespace CASISduino_Photographer
{
    public partial class Form1 : Form
    {
        //webcam
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        //default directory
        string directory = "";
        int nextPic = 0;
        private static System.Timers.Timer aTimer;


        public void print(string str)
        {
            System.Diagnostics.Debug.WriteLine(str);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo device in videoDevices)
            {
                comboBoxCamSelect.Items.Add(device.Name);
            }
            comboBoxCamSelect.SelectedIndex = 0;
            videoSource = new VideoCaptureDevice();
            labelRecentFilename.Text = "Most Recent Filename: None";
            loadPreferences();
            comboBoxResolution.Enabled = false;
            labelErrors.Text = "";
            numericHour.Value = 0;
            numericMinute.Value = 30;
            numericSecond.Value = 0;
            enableTiming.Checked = false;
        }
        private void buttonTakePicture_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                /*do not allow device closing
                //device is closed
                buttonOpenCamera.Text = "Open Camera";
                videoSource.Stop();
                pictureBoxVideoDisplay.Image = null;//eliminate image
                pictureBoxVideoDisplay.Invalidate();
                comboBoxResolution.Enabled = false;*/
            }
            else
            {
                //device is opened
                //buttonOpenCamera.Text = "Close Camera";
                buttonOpenCamera.Enabled = false;
                comboBoxResolution.Enabled = true;
                videoSource = new VideoCaptureDevice(videoDevices[comboBoxCamSelect.SelectedIndex].MonikerString);
                //set NewFrame Event Handler
                videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
                videoSource.Start();
                //set available resolutions
                for (int i = 0; i < videoSource.VideoCapabilities.Length; i++)
                {
                    string index = Convert.ToString(i);
                    string width = videoSource.VideoCapabilities[i].FrameSize.Width.ToString();
                    string height = videoSource.VideoCapabilities[i].FrameSize.Height.ToString();
                    comboBoxResolution.Items.Add("(" + index + ")"+height +"x"+width);
                }
                loadPreferences();
            }
        }
        void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame= (Bitmap)eventArgs.Frame.Clone();
            pictureBoxVideoDisplay.Image = frame;
            //incTimeBar();
        }
        private void comboBoxResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            videoSource.Stop();
            videoSource.VideoResolution = videoSource.VideoCapabilities[comboBoxResolution.SelectedIndex];
            videoSource.Start();
            savePreferences();
        }
        

        private void pictureBoxVideoDisplay_Click(object sender, EventArgs e)
        {

        }
        string createFilename()
        {
            string timestampStr = Convert.ToString(DateTime.Now);
            string timestampStr2 = timestampStr.Replace('/', '-');
            string timestampStr3 = timestampStr2.Replace(' ', '_');
            string timestamp = timestampStr3.Replace(':', '-');
            string filename = labelFilePrefix.Text+ "_" + timestamp + ".jpeg";

            return filename;
        } 
        
        private void buttonSavePicture_Click(object sender, EventArgs e)
        {
            if (comboBoxResolution.Enabled == true)
            {
                string filename = createFilename();
                labelRecentFilename.Text = "Most Recent Filename: " + filename;
                pictureBoxVideoDisplay.Image.Save(directory + filename, ImageFormat.Jpeg);
                labelErrors.Text = "Picture saved to directory";
            }
            else
            {
                labelErrors.Text = "Please Open a Camera";
            }
        }
        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest_1(object sender, EventArgs e)
        {

        }

        private void saveScreenshot_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonChageDir_Click(object sender, EventArgs e)
        {
            directoryDialog.Description = "Select a folder to which all photos will be saved";
            directoryDialog.ShowNewFolderButton = true;
            directoryDialog.ShowDialog();
            if (directoryDialog.SelectedPath != "")
            {
                directory = directoryDialog.SelectedPath + Convert.ToChar(92);
                labelDirectory.Text = directoryDialog.SelectedPath;
                savePreferences();
                loadPreferences();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelTimestamp_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxInterval_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        void loadPreferences()
        {
            //resolution
            if (comboBoxResolution.Enabled == true)
            {
                string defaultRes = Properties.Settings.Default.defaultResolution;
                for (int i = 0; i <= comboBoxResolution.Items.Count - 1; i++)
                {
                    if (comboBoxResolution.Items[i].ToString() == defaultRes)
                    {
                        comboBoxResolution.SelectedIndex = i;
                    }
                }
            }
            //prefix
            labelFilePrefix.Text = Properties.Settings.Default.defaultPrefix.ToString();
            //directory
            if (directory == "" & Properties.Settings.Default.defaultDirectory != "")
            {
                directory = Properties.Settings.Default.defaultDirectory;
                labelDirectory.Text = directory;
                buttonSavePicture.Enabled = true;
            }
            else if(directory == "")//if directory has no content, and/or no content is available
            {
                labelDirectory.Text = "No Directory Selected";
                buttonSavePicture.Enabled = false;
            }
            print("prefs loaded");
        }
        void savePreferences()
        {
            if (comboBoxResolution.Items.Count != 0)
            {
                Properties.Settings.Default.defaultResolution = comboBoxResolution.Items[comboBoxResolution.SelectedIndex].ToString();
            }
            Properties.Settings.Default.defaultPrefix = labelFilePrefix.Text.ToString();
            if (directory != "")
            {
                Properties.Settings.Default.defaultDirectory = directory;
            }
            print("prefs saved");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
            }
        }

        private void directoryDialog_HelpRequest(object sender, EventArgs e)
        {

        }

        private void labelFilePrefix_TextChanged(object sender, EventArgs e)
        {
            savePreferences();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void enableTiming_CheckedChanged(object sender, EventArgs e)
        {
            bool state = enableTiming.Checked;
            buttonBeginTiming.Enabled = state;
            numericHour.Enabled = state;
            numericMinute.Enabled = state;
            numericSecond.Enabled = state;
            //progressBarTime.Enabled = state;
        }

        int seconds1970(DateTime aTime)
        {
            double now = aTime.Subtract(new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
            int val = Convert.ToInt32(now);
            return val;
        }
        int interval = 1;

        void buttonBeginTiming_Click(object sender, EventArgs e)
        {
            interval = Convert.ToInt32(numericHour.Value * 3600 + numericMinute.Value * 60 + numericSecond.Value);//seconds
            aTimer = new System.Timers.Timer(interval);
            aTimer.AutoReset = true;
            aTimer.Elapsed += takeTimedPicture;
            aTimer.Enabled = true;
        }
        void takeTimedPicture(Object source, System.Timers.ElapsedEventArgs e)
        {
            //REALLY messy timer crap
            if (this.pictureBoxVideoDisplay.InvokeRequired)
                this.pictureBoxVideoDisplay.Invoke((MethodInvoker)delegate ()
                {
                    if (comboBoxResolution.Enabled == true)
                {
                    string filename = createFilename();
                    labelRecentFilename.Text = "Most Recent Filename: " + filename;
                    pictureBoxVideoDisplay.Image.Save(directory + filename, ImageFormat.Jpeg);
                    labelErrors.Text = "Picture saved to directory";
                }
                else
                {
                    labelErrors.Text = "Please Open a Camera";
                }
                });

            interval = Convert.ToInt32(numericHour.Value * 3600 + numericMinute.Value * 60 + numericSecond.Value);//seconds
            if (interval*1000 != aTimer.Interval)
            {
                aTimer.Interval = interval*1000;
            }
        }
    }
}
