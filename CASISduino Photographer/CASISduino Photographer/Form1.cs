using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//for webcam
using AForge.Video;
using AForge.Video.DirectShow;
//screenshots
using System.Drawing.Imaging;


namespace CASISduino_Photographer
{
    public partial class Form1 : Form
    {
        //webcam
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        //screenshot
        private static Bitmap bmpScreenshot;
        private static Graphics gfxScreenshot;
        //default directory
        string directory = "";
        bool flagForSave = false;

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
            buttonSavePicture.Enabled = false;
        }
        private void buttonTakePicture_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
                pictureBoxVideoDisplay.Image = null;//eliminate image
                pictureBoxVideoDisplay.Invalidate();
                buttonSavePicture.Enabled = false;
            }
            else
            {
                buttonOpenCamera.Text = "Close Camera";
                buttonSavePicture.Enabled = true;
                videoSource = new VideoCaptureDevice(videoDevices[comboBoxCamSelect.SelectedIndex].MonikerString);
                videoSource.VideoResolution = videoSource.VideoCapabilities[12];//set to max resolution
                //set NewFrame Event Handler
                videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
                videoSource.Start();
            }
            if (directory == "")//if not changed
            {
                buttonChageDir.PerformClick();
            }
        }
        void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame= (Bitmap)eventArgs.Frame.Clone();
            pictureBoxVideoDisplay.Image = frame;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
            }
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
            string filename = createFilename();
            labelRecentFilename.Text = "Most Recent Filename: " + filename;
            pictureBoxVideoDisplay.Image.Save(directory + filename, ImageFormat.Jpeg);
            /*
            //take screenshot of the windows form and save it
            // Set the bitmap object to the size of the screen
            bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
            // Create a graphics object from the bitmap
            gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            // Take the screenshot from the upper left corner to the right bottom corner
            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
            // Save the screenshot to the specified path that the user has chosen
            bmpScreenshot.Save(directory + Convert.ToChar(92) + filename, ImageFormat.Png);
            */
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
            directory = directoryDialog.SelectedPath + Convert.ToChar(92);
            labelDirectory.Text = directoryDialog.SelectedPath;
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
    }
}
