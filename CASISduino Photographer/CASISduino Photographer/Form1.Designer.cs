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
            this.directoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.labelDirectory = new System.Windows.Forms.Label();
            this.labelFilePrefix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxInterval = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxCameraProperties = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBoxFileProperties = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideoDisplay)).BeginInit();
            this.groupBoxCameraProperties.SuspendLayout();
            this.groupBoxFileProperties.SuspendLayout();
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
            // 
            // buttonOpenCamera
            // 
            this.buttonOpenCamera.Location = new System.Drawing.Point(6, 19);
            this.buttonOpenCamera.Name = "buttonOpenCamera";
            this.buttonOpenCamera.Size = new System.Drawing.Size(113, 23);
            this.buttonOpenCamera.TabIndex = 3;
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
            this.buttonSavePicture.Text = "Save Picture";
            this.buttonSavePicture.UseVisualStyleBackColor = true;
            this.buttonSavePicture.Click += new System.EventHandler(this.buttonSavePicture_Click);
            // 
            // buttonChageDir
            // 
            this.buttonChageDir.Location = new System.Drawing.Point(3, 42);
            this.buttonChageDir.Name = "buttonChageDir";
            this.buttonChageDir.Size = new System.Drawing.Size(158, 23);
            this.buttonChageDir.TabIndex = 6;
            this.buttonChageDir.Text = "Change Directory";
            this.buttonChageDir.UseVisualStyleBackColor = true;
            this.buttonChageDir.Click += new System.EventHandler(this.buttonChageDir_Click);
            // 
            // labelDirectory
            // 
            this.labelDirectory.Location = new System.Drawing.Point(3, 68);
            this.labelDirectory.Name = "labelDirectory";
            this.labelDirectory.Size = new System.Drawing.Size(312, 30);
            this.labelDirectory.TabIndex = 7;
            this.labelDirectory.Text = "No Directory Selected";
            this.labelDirectory.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelFilePrefix
            // 
            this.labelFilePrefix.Location = new System.Drawing.Point(120, 16);
            this.labelFilePrefix.Name = "labelFilePrefix";
            this.labelFilePrefix.Size = new System.Drawing.Size(194, 20);
            this.labelFilePrefix.TabIndex = 8;
            this.labelFilePrefix.Text = "Image";
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
            // comboBoxInterval
            // 
            this.comboBoxInterval.FormattingEnabled = true;
            this.comboBoxInterval.Location = new System.Drawing.Point(161, 118);
            this.comboBoxInterval.Name = "comboBoxInterval";
            this.comboBoxInterval.Size = new System.Drawing.Size(155, 21);
            this.comboBoxInterval.TabIndex = 10;
            this.comboBoxInterval.SelectedIndexChanged += new System.EventHandler(this.comboBoxInterval_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "Interval Between Pictures\r\n(Custom Allowed)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBoxCameraProperties
            // 
            this.groupBoxCameraProperties.Controls.Add(this.label3);
            this.groupBoxCameraProperties.Controls.Add(this.buttonOpenCamera);
            this.groupBoxCameraProperties.Controls.Add(this.comboBox1);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(133, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // groupBoxFileProperties
            // 
            this.groupBoxFileProperties.Controls.Add(this.buttonChageDir);
            this.groupBoxFileProperties.Controls.Add(this.buttonSavePicture);
            this.groupBoxFileProperties.Controls.Add(this.label2);
            this.groupBoxFileProperties.Controls.Add(this.comboBoxInterval);
            this.groupBoxFileProperties.Controls.Add(this.labelFilePrefix);
            this.groupBoxFileProperties.Controls.Add(this.label1);
            this.groupBoxFileProperties.Controls.Add(this.labelRecentFilename);
            this.groupBoxFileProperties.Controls.Add(this.labelDirectory);
            this.groupBoxFileProperties.Location = new System.Drawing.Point(664, 94);
            this.groupBoxFileProperties.Name = "groupBoxFileProperties";
            this.groupBoxFileProperties.Size = new System.Drawing.Size(320, 188);
            this.groupBoxFileProperties.TabIndex = 13;
            this.groupBoxFileProperties.TabStop = false;
            this.groupBoxFileProperties.Text = "File Properties";
            this.groupBoxFileProperties.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 383);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxVideoDisplay;
        private System.Windows.Forms.ComboBox comboBoxCamSelect;
        private System.Windows.Forms.Button buttonOpenCamera;
        private System.Windows.Forms.Label labelRecentFilename;
        private System.Windows.Forms.Button buttonSavePicture;
        private System.Windows.Forms.Button buttonChageDir;
        private System.Windows.Forms.FolderBrowserDialog directoryDialog;
        private System.Windows.Forms.Label labelDirectory;
        private System.Windows.Forms.TextBox labelFilePrefix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxCameraProperties;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBoxFileProperties;
    }
}

