namespace jBooth
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.pnlBack = new System.Windows.Forms.Panel();
            this.pnlCaptureBar = new System.Windows.Forms.Panel();
            this.lblTimerEnabled = new System.Windows.Forms.Label();
            this.btnTimer = new System.Windows.Forms.Button();
            this.lblCaptureFormat = new System.Windows.Forms.Label();
            this.lblAvailableDevices = new System.Windows.Forms.Label();
            this.btnCapture = new System.Windows.Forms.Button();
            this.cbxAvailableDevices = new System.Windows.Forms.ComboBox();
            this.pnlWebcam = new System.Windows.Forms.Panel();
            this.pbxWebcam = new System.Windows.Forms.PictureBox();
            this.pnlMenuBar = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnVideoMode = new System.Windows.Forms.Button();
            this.btnPhotoMode = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.sfdSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.ttpHelper = new System.Windows.Forms.ToolTip(this.components);
            this.pnlBack.SuspendLayout();
            this.pnlCaptureBar.SuspendLayout();
            this.pnlWebcam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWebcam)).BeginInit();
            this.pnlMenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBack
            // 
            this.pnlBack.AutoSize = true;
            this.pnlBack.Controls.Add(this.pnlCaptureBar);
            this.pnlBack.Controls.Add(this.pnlWebcam);
            this.pnlBack.Controls.Add(this.pnlMenuBar);
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(0, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(1004, 600);
            this.pnlBack.TabIndex = 0;
            // 
            // pnlCaptureBar
            // 
            this.pnlCaptureBar.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlCaptureBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCaptureBar.Controls.Add(this.lblTimerEnabled);
            this.pnlCaptureBar.Controls.Add(this.btnTimer);
            this.pnlCaptureBar.Controls.Add(this.lblCaptureFormat);
            this.pnlCaptureBar.Controls.Add(this.lblAvailableDevices);
            this.pnlCaptureBar.Controls.Add(this.btnCapture);
            this.pnlCaptureBar.Controls.Add(this.cbxAvailableDevices);
            this.pnlCaptureBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCaptureBar.Location = new System.Drawing.Point(150, 450);
            this.pnlCaptureBar.Name = "pnlCaptureBar";
            this.pnlCaptureBar.Size = new System.Drawing.Size(854, 150);
            this.pnlCaptureBar.TabIndex = 1;
            // 
            // lblTimerEnabled
            // 
            this.lblTimerEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTimerEnabled.AutoSize = true;
            this.lblTimerEnabled.BackColor = System.Drawing.Color.Transparent;
            this.lblTimerEnabled.Font = new System.Drawing.Font("Eurostile LT Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimerEnabled.ForeColor = System.Drawing.Color.White;
            this.lblTimerEnabled.Location = new System.Drawing.Point(13, 107);
            this.lblTimerEnabled.Name = "lblTimerEnabled";
            this.lblTimerEnabled.Size = new System.Drawing.Size(215, 25);
            this.lblTimerEnabled.TabIndex = 6;
            this.lblTimerEnabled.Text = "Timer Enabled: False";
            // 
            // btnTimer
            // 
            this.btnTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimer.BackColor = System.Drawing.Color.Transparent;
            this.btnTimer.BackgroundImage = global::jBooth.Properties.Resources.stopwatch;
            this.btnTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimer.FlatAppearance.BorderSize = 0;
            this.btnTimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimer.Location = new System.Drawing.Point(752, 37);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(72, 72);
            this.btnTimer.TabIndex = 5;
            this.btnTimer.UseVisualStyleBackColor = false;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            this.btnTimer.MouseEnter += new System.EventHandler(this.btnTimer_MouseEnter);
            this.btnTimer.MouseLeave += new System.EventHandler(this.btnTimer_MouseLeave);
            // 
            // lblCaptureFormat
            // 
            this.lblCaptureFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCaptureFormat.AutoSize = true;
            this.lblCaptureFormat.BackColor = System.Drawing.Color.Transparent;
            this.lblCaptureFormat.Font = new System.Drawing.Font("Eurostile LT Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCaptureFormat.ForeColor = System.Drawing.Color.White;
            this.lblCaptureFormat.Location = new System.Drawing.Point(13, 85);
            this.lblCaptureFormat.Name = "lblCaptureFormat";
            this.lblCaptureFormat.Size = new System.Drawing.Size(243, 25);
            this.lblCaptureFormat.TabIndex = 3;
            this.lblCaptureFormat.Text = "Capture Format: Photo";
            // 
            // lblAvailableDevices
            // 
            this.lblAvailableDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAvailableDevices.AutoSize = true;
            this.lblAvailableDevices.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailableDevices.Font = new System.Drawing.Font("Eurostile LT Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAvailableDevices.ForeColor = System.Drawing.Color.White;
            this.lblAvailableDevices.Location = new System.Drawing.Point(13, 9);
            this.lblAvailableDevices.Name = "lblAvailableDevices";
            this.lblAvailableDevices.Size = new System.Drawing.Size(247, 25);
            this.lblAvailableDevices.TabIndex = 2;
            this.lblAvailableDevices.Text = "Available Video Devices:";
            // 
            // btnCapture
            // 
            this.btnCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCapture.BackColor = System.Drawing.Color.Transparent;
            this.btnCapture.BackgroundImage = global::jBooth.Properties.Resources.capture;
            this.btnCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCapture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapture.FlatAppearance.BorderSize = 0;
            this.btnCapture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCapture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapture.Font = new System.Drawing.Font("Eurostile LT Std", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCapture.Location = new System.Drawing.Point(331, 8);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(128, 128);
            this.btnCapture.TabIndex = 1;
            this.btnCapture.UseVisualStyleBackColor = false;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // cbxAvailableDevices
            // 
            this.cbxAvailableDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxAvailableDevices.BackColor = System.Drawing.Color.DarkGray;
            this.cbxAvailableDevices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxAvailableDevices.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxAvailableDevices.Font = new System.Drawing.Font("Eurostile LT Std Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbxAvailableDevices.FormattingEnabled = true;
            this.cbxAvailableDevices.Location = new System.Drawing.Point(13, 41);
            this.cbxAvailableDevices.Name = "cbxAvailableDevices";
            this.cbxAvailableDevices.Size = new System.Drawing.Size(273, 33);
            this.cbxAvailableDevices.TabIndex = 0;
            // 
            // pnlWebcam
            // 
            this.pnlWebcam.BackColor = System.Drawing.Color.DarkGray;
            this.pnlWebcam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlWebcam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlWebcam.Controls.Add(this.pbxWebcam);
            this.pnlWebcam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWebcam.Location = new System.Drawing.Point(150, 0);
            this.pnlWebcam.Name = "pnlWebcam";
            this.pnlWebcam.Size = new System.Drawing.Size(854, 600);
            this.pnlWebcam.TabIndex = 3;
            // 
            // pbxWebcam
            // 
            this.pbxWebcam.BackColor = System.Drawing.Color.Transparent;
            this.pbxWebcam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxWebcam.Location = new System.Drawing.Point(0, 0);
            this.pbxWebcam.Name = "pbxWebcam";
            this.pbxWebcam.Size = new System.Drawing.Size(850, 596);
            this.pbxWebcam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxWebcam.TabIndex = 0;
            this.pbxWebcam.TabStop = false;
            // 
            // pnlMenuBar
            // 
            this.pnlMenuBar.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlMenuBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMenuBar.Controls.Add(this.btnSettings);
            this.pnlMenuBar.Controls.Add(this.btnVideoMode);
            this.pnlMenuBar.Controls.Add(this.btnPhotoMode);
            this.pnlMenuBar.Controls.Add(this.pbxLogo);
            this.pnlMenuBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuBar.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuBar.Name = "pnlMenuBar";
            this.pnlMenuBar.Size = new System.Drawing.Size(150, 600);
            this.pnlMenuBar.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackgroundImage = global::jBooth.Properties.Resources.settings;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(25, 475);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(96, 96);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnVideoMode
            // 
            this.btnVideoMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVideoMode.BackColor = System.Drawing.Color.Transparent;
            this.btnVideoMode.BackgroundImage = global::jBooth.Properties.Resources.video;
            this.btnVideoMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVideoMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVideoMode.FlatAppearance.BorderSize = 0;
            this.btnVideoMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVideoMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVideoMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideoMode.Location = new System.Drawing.Point(25, 325);
            this.btnVideoMode.Name = "btnVideoMode";
            this.btnVideoMode.Size = new System.Drawing.Size(96, 96);
            this.btnVideoMode.TabIndex = 6;
            this.btnVideoMode.UseVisualStyleBackColor = false;
            this.btnVideoMode.Click += new System.EventHandler(this.btnVideoMode_Click);
            // 
            // btnPhotoMode
            // 
            this.btnPhotoMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPhotoMode.BackColor = System.Drawing.Color.Transparent;
            this.btnPhotoMode.BackgroundImage = global::jBooth.Properties.Resources.photo;
            this.btnPhotoMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPhotoMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhotoMode.FlatAppearance.BorderSize = 0;
            this.btnPhotoMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPhotoMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPhotoMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhotoMode.Location = new System.Drawing.Point(25, 175);
            this.btnPhotoMode.Name = "btnPhotoMode";
            this.btnPhotoMode.Size = new System.Drawing.Size(96, 96);
            this.btnPhotoMode.TabIndex = 5;
            this.btnPhotoMode.UseVisualStyleBackColor = false;
            this.btnPhotoMode.Click += new System.EventHandler(this.btnPhotoMode_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxLogo.Image = global::jBooth.Properties.Resources.logo;
            this.pbxLogo.Location = new System.Drawing.Point(25, 25);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(96, 96);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 1;
            this.pbxLogo.TabStop = false;
            // 
            // ttpHelper
            // 
            this.ttpHelper.BackColor = System.Drawing.Color.SteelBlue;
            this.ttpHelper.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttpHelper.ToolTipTitle = "jBooth Help";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1004, 600);
            this.Controls.Add(this.pnlBack);
            this.Font = new System.Drawing.Font("Eurostile LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "jBooth";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.pnlBack.ResumeLayout(false);
            this.pnlCaptureBar.ResumeLayout(false);
            this.pnlCaptureBar.PerformLayout();
            this.pnlWebcam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxWebcam)).EndInit();
            this.pnlMenuBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Panel pnlMenuBar;
        public Panel pnlCaptureBar;
        public Panel pnlBack;
        public ComboBox cbxAvailableDevices;
        public PictureBox pbxLogo;
        public Button btnCapture;
        public Button btnSettings;
        public Button btnVideoMode;
        public Button btnPhotoMode;
        public SaveFileDialog sfdSaveFile;
        public Label lblCaptureFormat;
        public Label lblAvailableDevices;
        public Panel pnlWebcam;
        public PictureBox pbxWebcam;
        public Button btnTimer;
        public ToolTip ttpHelper;
        public Label lblTimerEnabled;
    }
}