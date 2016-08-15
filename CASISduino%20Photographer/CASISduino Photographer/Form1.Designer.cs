namespace CASISduino_Photographer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxVideoDisplay = new System.Windows.Forms.PictureBox();
            this.comboBoxCamSelect = new System.Windows.Forms.ComboBox();
            this.buttonOpenCamera = new System.Windows.Forms.Button();
            this.labelRecentFilename = new System.Windows.Forms.Label();
            this.buttonSavePicture = new System.Windows.Forms.Button();
            this.buttonChageDir = new System.Windows.Forms.Button();
            this.labelDirectory = new System.Windows.Forms.Label();
            this.labelFilePrefix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxCameraProperties = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxResolution = new System.Windows.Forms.ComboBox();
            this.groupBoxFileProperties = new System.Windows.Forms.GroupBox();
            this.directoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.labelErrors = new System.Windows.Forms.Label();
            this.numericHour = new System.Windows.Forms.NumericUpDown();
            this.numericMinute = new System.Windows.Forms.NumericUpDown();
            this.numericSecond = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enableTiming = new System.Windows.Forms.CheckBox();
            this.buttonBeginTiming = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideoDisplay)).BeginInit();
            this.groupBoxCameraProperties.SuspendLayout();
            this.groupBoxFileProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSecond)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxVideoDisplay
            // 
            this.pictureBoxVideoDisplay.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBoxVideoDisplay.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxVideoDisplay.Name = "pictureBoxVideoDisplay";
            this.pictureBoxVideoDisplay.Size = new System.Drawing.Size(640, 360);
            this.pictureBoxVideoDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVideoDisplay.TabIndex = 1;
            this.pictureBoxVideoDisplay.TabStop = false;
            this.pictureBoxVideoDisplay.Click += new System.EventHandler(this.pictureBoxVideoDisplay_Click);
            // 
            // comboBoxCamSelect
            // 
            this.comboBoxCamSelect.FormattingEnabled = true;
            this.comboBoxCamSelect.Location = new System.Drawing.Point(133, 20);
            this.comboBoxCamSelect.Name = "comboBoxCamSelect";
            this.comboBoxCamSelect.Size = new System.Drawing.Size(180, 21);
            this.comboBoxCamSelect.TabIndex = 2;
            this.comboBoxCamSelect.TabStop = false;
            // 
            // buttonOpenCamera
            // 
            this.buttonOpenCamera.Location = new System.Drawing.Point(4, 19);
            this.buttonOpenCamera.Name = "buttonOpenCamera";
            this.buttonOpenCamera.Size = new System.Drawing.Size(113, 23);
            this.buttonOpenCamera.TabIndex = 3;
            this.buttonOpenCamera.TabStop = false;
            this.buttonOpenCamera.Text = "Open Camera";
            this.buttonOpenCamera.UseVisualStyleBackColor = true;
            this.buttonOpenCamera.Click += new System.EventHandler(this.buttonTakePicture_Click);
            // 
            // labelRecentFilename
            // 
            this.labelRecentFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecentFilename.Location = new System.Drawing.Point(4, 98);
            this.labelRecentFilename.Name = "labelRecentFilename";
            this.labelRecentFilename.Size = new System.Drawing.Size(313, 20);
            this.labelRecentFilename.TabIndex = 4;
            this.labelRecentFilename.Text = "Most Recent Filename:";
            this.labelRecentFilename.Click += new System.EventHandler(this.labelTimestamp_Click);
            // 
            // buttonSavePicture
            // 
            this.buttonSavePicture.Location = new System.Drawing.Point(161, 42);
            this.buttonSavePicture.Name = "buttonSavePicture";
            this.buttonSavePicture.Size = new System.Drawing.Size(155, 23);
            this.buttonSavePicture.TabIndex = 5;
            this.buttonSavePicture.TabStop = false;
            this.buttonSavePicture.Text = "Save Picture";
            this.buttonSavePicture.UseVisualStyleBackColor = true;
            this.buttonSavePicture.Click += new System.EventHandler(this.buttonSavePicture_Click);
            // 
            // buttonChageDir
            // 
            this.buttonChageDir.Location = new System.Drawing.Point(4, 42);
            this.buttonChageDir.Name = "buttonChageDir";
            this.buttonChageDir.Size = new System.Drawing.Size(158, 23);
            this.buttonChageDir.TabIndex = 6;
            this.buttonChageDir.TabStop = false;
            this.buttonChageDir.Text = "Change Directory";
            this.buttonChageDir.UseVisualStyleBackColor = true;
            this.buttonChageDir.Click += new System.EventHandler(this.buttonChageDir_Click);
            // 
            // labelDirectory
            // 
            this.labelDirectory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelDirectory.Location = new System.Drawing.Point(3, 68);
            this.labelDirectory.Name = "labelDirectory";
            this.labelDirectory.Size = new System.Drawing.Size(312, 30);
            this.labelDirectory.TabIndex = 7;
            this.labelDirectory.Text = "Directory";
            this.labelDirectory.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelFilePrefix
            // 
            this.labelFilePrefix.Location = new System.Drawing.Point(120, 16);
            this.labelFilePrefix.Name = "labelFilePrefix";
            this.labelFilePrefix.Size = new System.Drawing.Size(194, 20);
            this.labelFilePrefix.TabIndex = 8;
            this.labelFilePrefix.TabStop = false;
            this.labelFilePrefix.Text = "Image";
            this.labelFilePrefix.TextChanged += new System.EventHandler(this.labelFilePrefix_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "File Prefix: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Interval:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBoxCameraProperties
            // 
            this.groupBoxCameraProperties.Controls.Add(this.label3);
            this.groupBoxCameraProperties.Controls.Add(this.buttonOpenCamera);
            this.groupBoxCameraProperties.Controls.Add(this.comboBoxResolution);
            this.groupBoxCameraProperties.Controls.Add(this.comboBoxCamSelect);
            this.groupBoxCameraProperties.Location = new System.Drawing.Point(664, 12);
            this.groupBoxCameraProperties.Name = "groupBoxCameraProperties";
            this.groupBoxCameraProperties.Size = new System.Drawing.Size(320, 76);
            this.groupBoxCameraProperties.TabIndex = 12;
            this.groupBoxCameraProperties.TabStop = false;
            this.groupBoxCameraProperties.Text = "Camera Properties";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Resolution";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBoxResolution
            // 
            this.comboBoxResolution.FormattingEnabled = true;
            this.comboBoxResolution.Location = new System.Drawing.Point(133, 47);
            this.comboBoxResolution.Name = "comboBoxResolution";
            this.comboBoxResolution.Size = new System.Drawing.Size(181, 21);
            this.comboBoxResolution.TabIndex = 13;
            this.comboBoxResolution.TabStop = false;
            this.comboBoxResolution.SelectedIndexChanged += new System.EventHandler(this.comboBoxResolution_SelectedIndexChanged);
            // 
            // groupBoxFileProperties
            // 
            this.groupBoxFileProperties.Controls.Add(this.buttonChageDir);
            this.groupBoxFileProperties.Controls.Add(this.buttonSavePicture);
            this.groupBoxFileProperties.Controls.Add(this.labelFilePrefix);
            this.groupBoxFileProperties.Controls.Add(this.label1);
            this.groupBoxFileProperties.Controls.Add(this.labelRecentFilename);
            this.groupBoxFileProperties.Controls.Add(this.labelDirectory);
            this.groupBoxFileProperties.Location = new System.Drawing.Point(664, 94);
            this.groupBoxFileProperties.Name = "groupBoxFileProperties";
            this.groupBoxFileProperties.Size = new System.Drawing.Size(320, 128);
            this.groupBoxFileProperties.TabIndex = 13;
            this.groupBoxFileProperties.TabStop = false;
            this.groupBoxFileProperties.Text = "File Properties";
            this.groupBoxFileProperties.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // directoryDialog
            // 
            this.directoryDialog.HelpRequest += new System.EventHandler(this.directoryDialog_HelpRequest);
            // 
            // labelErrors
            // 
            this.labelErrors.Location = new System.Drawing.Point(668, 358);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Size = new System.Drawing.Size(316, 14);
            this.labelErrors.TabIndex = 14;
            this.labelErrors.Text = "Errors";
            this.labelErrors.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.labelErrors.Click += new System.EventHandler(this.label4_Click);
            // 
            // numericHour
            // 
            this.numericHour.Location = new System.Drawing.Point(57, 37);
            this.numericHour.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericHour.Name = "numericHour";
            this.numericHour.Size = new System.Drawing.Size(34, 20);
            this.numericHour.TabIndex = 15;
            // 
            // numericMinute
            // 
            this.numericMinute.Location = new System.Drawing.Point(92, 37);
            this.numericMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericMinute.Name = "numericMinute";
            this.numericMinute.Size = new System.Drawing.Size(34, 20);
            this.numericMinute.TabIndex = 16;
            // 
            // numericSecond
            // 
            this.numericSecond.Location = new System.Drawing.Point(127, 37);
            this.numericSecond.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericSecond.Name = "numericSecond";
            this.numericSecond.Size = new System.Drawing.Size(34, 20);
            this.numericSecond.TabIndex = 17;
            this.numericSecond.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enableTiming);
            this.groupBox1.Controls.Add(this.buttonBeginTiming);
            this.groupBox1.Controls.Add(this.numericSecond);
            this.groupBox1.Controls.Add(this.numericMinute);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericHour);
            this.groupBox1.Location = new System.Drawing.Point(664, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 65);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timing";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // enableTiming
            // 
            this.enableTiming.AutoSize = true;
            this.enableTiming.Checked = true;
            this.enableTiming.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableTiming.Location = new System.Drawing.Point(6, 19);
            this.enableTiming.Name = "enableTiming";
            this.enableTiming.Size = new System.Drawing.Size(127, 17);
            this.enableTiming.TabIndex = 19;
            this.enableTiming.TabStop = false;
            this.enableTiming.Text = "Enable Timed Photos";
            this.enableTiming.UseVisualStyleBackColor = true;
            this.enableTiming.CheckedChanged += new System.EventHandler(this.enableTiming_CheckedChanged);
            // 
            // buttonBeginTiming
            // 
            this.buttonBeginTiming.Location = new System.Drawing.Point(167, 19);
            this.buttonBeginTiming.Name = "buttonBeginTiming";
            this.buttonBeginTiming.Size = new System.Drawing.Size(142, 39);
            this.buttonBeginTiming.TabIndex = 19;
            this.buttonBeginTiming.Text = "Begin Logging";
            this.buttonBeginTiming.UseVisualStyleBackColor = true;
            this.buttonBeginTiming.Click += new System.EventHandler(this.buttonBeginTiming_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 383);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelErrors);
            this.Controls.Add(this.groupBoxFileProperties);
            this.Controls.Add(this.groupBoxCameraProperties);
            this.Controls.Add(this.pictureBoxVideoDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CASISduino Photographer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideoDisplay)).EndInit();
            this.groupBoxCameraProperties.ResumeLayout(false);
            this.groupBoxFileProperties.ResumeLayout(false);
            this.groupBoxFileProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSecond)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxVideoDisplay;
        private System.Windows.Forms.ComboBox comboBoxCamSelect;
        private System.Windows.Forms.Button buttonOpenCamera;
        private System.Windows.Forms.Label labelRecentFilename;
        private System.Windows.Forms.Button buttonSavePicture;
        private System.Windows.Forms.Button buttonChageDir;
        private System.Windows.Forms.Label labelDirectory;
        private System.Windows.Forms.TextBox labelFilePrefix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxCameraProperties;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxResolution;
        private System.Windows.Forms.GroupBox groupBoxFileProperties;
        private System.Windows.Forms.FolderBrowserDialog directoryDialog;
        private System.Windows.Forms.Label labelErrors;
        private System.Windows.Forms.NumericUpDown numericHour;
        private System.Windows.Forms.NumericUpDown numericSecond;
        private System.Windows.Forms.NumericUpDown numericMinute;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonBeginTiming;
        private System.Windows.Forms.CheckBox enableTiming;
    }
}

