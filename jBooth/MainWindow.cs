using AForge;
using Accord;
using AForge.Video;
using AForge.Video.DirectShow;
using Accord.Video.VFW;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Timers;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Diagnostics;

namespace jBooth
{
    public partial class MainWindow : Form
    {
        private bool captureClicked;
        private string captureFormat;
        private int width;
        private int height;
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCaptureDevices;
        private Bitmap videoFrame;
        private System.Timers.Timer captureTimer;
        private bool timerEnabled;
        private bool timerRunning;
        int counter = 0;
        public MainWindow()
        {
            InitializeComponent();
            pnlCaptureBar.BackColor = ColorTranslator.FromHtml("#054686");
            pnlMenuBar.BackColor = ColorTranslator.FromHtml("#054686");
            StartWebcamCapture();
        }
        private void StartWebcamCapture()
        {
            // get width and height of webcam picture box
            width = pbxWebcam.Width;
            height = pbxWebcam.Height;
            // set capture format to photo by default
            captureFormat = "photo";
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cbxAvailableDevices.Items.Add(filterInfo.Name);
                cbxAvailableDevices.SelectedIndex = 0;
                videoCaptureDevices = new VideoCaptureDevice();
            }
            videoCaptureDevices = new VideoCaptureDevice(filterInfoCollection[cbxAvailableDevices.SelectedIndex].MonikerString);
            videoCaptureDevices.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevices.Start();
        }
        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (captureFormat == "photo")
            {
                pbxWebcam.Image = (Bitmap)eventArgs.Frame.Clone();
            }
            else if (captureFormat == "video")
            {
                pbxWebcam.Image = (Bitmap)eventArgs.Frame.Clone();
                videoFrame = (Bitmap)pbxWebcam.Image;
            }
        }
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevices.IsRunning == true)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit jBooth", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    videoCaptureDevices.SignalToStop();
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
        private void TakeCapture()
        {
            if (captureClicked == false && captureFormat == "photo")
            {
                captureClicked = true;
                Bitmap capture = new Bitmap(pbxWebcam.Image, width * 2, height * 2);
                string currentFolder = Directory.GetCurrentDirectory();
                string photosFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                string captureFolderPath = string.Format("{0}\\jBooth\\captures", photosFolder);
                Directory.CreateDirectory(captureFolderPath);
                Directory.SetCurrentDirectory(captureFolderPath);
                string datetime = DateTime.Now.ToString("s");
                datetime = datetime.Replace(":", "-");
                sfdSaveFile.FileName = string.Format("img_{0}", datetime);
                sfdSaveFile.Filter = "Bitmap Image|*.bmp|JPG Image|*.jpg|PNG Image|*.png";
                sfdSaveFile.Title = "Save Image Capture";
                // use invoke action to prevent cross-thread access error when showing the save file dialog
                Invoke((Action)(() => { sfdSaveFile.ShowDialog(); }));
                FileStream fs = (FileStream)sfdSaveFile.OpenFile();
                switch (sfdSaveFile.FilterIndex)
                {
                    case 1:
                        capture.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 2:
                        capture.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 3:
                        capture.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    // use JPG as default image file format
                    default:
                        capture.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                }
                fs.Close();
                Directory.SetCurrentDirectory(currentFolder);
                // set 'captureClicked' back to false so additional captures can be taken if desired
                captureClicked = false;
            }
            else if (captureClicked == false && captureFormat == "video")
            {
                captureClicked = true;
                string datetime = DateTime.Now.ToString("s");
                datetime = datetime.Replace(":", "-");
                sfdSaveFile.FileName = string.Format("img_{0}", datetime);
                sfdSaveFile.Filter = "MP4 Video|*.mp4|AVI Video|*.avi";
                sfdSaveFile.Title = "Save Video Capture";
                // use invoke action to prevent cross-thread access error when showing the save file dialog
                Invoke((Action)(() => { sfdSaveFile.ShowDialog(); }));
                btnCapture.BackgroundImage = Properties.Resources.stop;
            }
            else if (captureClicked == true && captureFormat == "video")
            {
                captureClicked = false;
                btnCapture.BackgroundImage = Properties.Resources.capture;
            }
        }
        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (timerEnabled == true)
            {
                captureTimer = new System.Timers.Timer(1000);
                captureTimer.Start();
                captureTimer.Enabled = true;
                timerRunning = true;
                captureTimer.Elapsed += OnTimedEvent;
            }
            else
            {
                TakeCapture();
            }
        }
        private void btnPhotoMode_Click(object sender, EventArgs e)
        {
            captureFormat = "photo";
            lblCaptureFormat.Text = "Capture Format: Photo";
        }

        private void btnVideoMode_Click(object sender, EventArgs e)
        {
            captureFormat = "video";
            lblCaptureFormat.Text = "Capture Format: Video";
            MessageBox.Show("Video capture is still being developed", "Work In Progress", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTimer_MouseEnter(object sender, EventArgs e)
        {
            ttpHelper.Show("Clicking this stopwatch will allow you to set a 3 second timer before the webcam image is captured", btnTimer);
        }

        private void btnTimer_MouseLeave(object sender, EventArgs e)
        {
            ttpHelper.Hide(btnTimer);
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            if (timerEnabled == false && timerRunning == false)
            {
                timerEnabled = true;
                lblTimerEnabled.Text = "Timer Enabled: True";
            }
            else if (timerEnabled == true && timerRunning == false)
            {
                timerEnabled = false;
                lblTimerEnabled.Text = "Timer Enabled: False";
            }
            else if (timerEnabled == false && timerRunning == true)
            {
                timerEnabled = false;
                lblTimerEnabled.Text = "Timer Enabled: False";
            }
            else if (timerEnabled == true && timerRunning == true)
            {
                MessageBox.Show("Countdown timer is already running", "Countdown Timer Running", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// runs the 'ShowCountdown' method every second, incrementing the counter variable by '1' with each elapsed event
        /// if the counter reaches '3', then it will run the 'TakeCapture' method as the countdown would have ended
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            if (counter == 0)
            {
                ShowCountdown(0);
                counter = counter + 1;
            }
            else if (counter == 1)
            {
                ShowCountdown(1);
                counter++;
            }
            else if (counter == 2)
            {
                ShowCountdown(2);
                counter++;
            }
            else if (counter == 3)
            {
                ShowCountdown(3);
                TakeCapture();
                captureTimer.Stop();
                captureTimer.Enabled = false;
                captureTimer.Dispose();
                timerEnabled = false;
                timerRunning = false;
                counter = 0;
                // use invoke action to prevent cross-thread access error
                Invoke((Action)(() => { lblTimerEnabled.Text = "Timer Enabled: False"; }));
            }
        }
        /// <summary>
        /// shows the current timer countdown by updating the text of the capture button;
        /// uses a switch statement with a counter as a parameter
        /// </summary>
        /// <param name="counter"></param>
        private void ShowCountdown(int counter)
        {
            switch (counter)
            {
                // use invoke actions to prevent cross-thread access errors
                case 0:
                    Invoke((Action)(() => { btnCapture.Text = "3"; }));
                    break;
                case 1:
                    Invoke((Action)(() => { btnCapture.Text = "2"; }));
                    break;
                case 2:
                    Invoke((Action)(() => { btnCapture.Text = "1"; }));
                    break;
                case 3:
                    Invoke((Action)(() => { btnCapture.Text = ""; }));
                    break;
            }
        }
        /// <summary>
        /// opens the form to configure the settings of jBooth
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSettings_Click(object sender, EventArgs e)
        {
            var settings = new Settings(this);
            settings.Show();
        }
    }
}