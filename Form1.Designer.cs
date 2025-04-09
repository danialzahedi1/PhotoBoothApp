namespace PhotoBoothApp
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxLive = new System.Windows.Forms.PictureBox();
            this.btnTakePhoto = new System.Windows.Forms.Button();
            this.photoTimer = new System.Windows.Forms.Timer(this.components);
            this.comboBoxCameras = new System.Windows.Forms.ComboBox();
            this.btnScanDevices = new System.Windows.Forms.Button();
            this.btnInitCamera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLive)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLive
            // 
            this.pictureBoxLive.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxLive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLive.Location = new System.Drawing.Point(371, 151);
            this.pictureBoxLive.Name = "pictureBoxLive";
            this.pictureBoxLive.Size = new System.Drawing.Size(693, 396);
            this.pictureBoxLive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLive.TabIndex = 0;
            this.pictureBoxLive.TabStop = false;
            // 
            // btnTakePhoto
            // 
            this.btnTakePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakePhoto.Location = new System.Drawing.Point(420, 600);
            this.btnTakePhoto.Name = "btnTakePhoto";
            this.btnTakePhoto.Size = new System.Drawing.Size(241, 67);
            this.btnTakePhoto.TabIndex = 1;
            this.btnTakePhoto.Text = "Take Photo";
            this.btnTakePhoto.UseVisualStyleBackColor = true;
            this.btnTakePhoto.Click += new System.EventHandler(this.btnTakePhoto_Click);
            // 
            // comboBoxCameras
            // 
            this.comboBoxCameras.AllowDrop = true;
            this.comboBoxCameras.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCameras.FormattingEnabled = true;
            this.comboBoxCameras.Location = new System.Drawing.Point(433, 98);
            this.comboBoxCameras.Name = "comboBoxCameras";
            this.comboBoxCameras.Size = new System.Drawing.Size(215, 37);
            this.comboBoxCameras.TabIndex = 2;
            // 
            // btnScanDevices
            // 
            this.btnScanDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScanDevices.Location = new System.Drawing.Point(433, 34);
            this.btnScanDevices.Name = "btnScanDevices";
            this.btnScanDevices.Size = new System.Drawing.Size(215, 58);
            this.btnScanDevices.TabIndex = 3;
            this.btnScanDevices.Text = "Scan Devices";
            this.btnScanDevices.UseVisualStyleBackColor = true;
            this.btnScanDevices.Click += new System.EventHandler(this.btnScanDevices_Click);
            // 
            // btnInitCamera
            // 
            this.btnInitCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitCamera.Location = new System.Drawing.Point(731, 56);
            this.btnInitCamera.Name = "btnInitCamera";
            this.btnInitCamera.Size = new System.Drawing.Size(215, 58);
            this.btnInitCamera.TabIndex = 4;
            this.btnInitCamera.Text = "Start Cam";
            this.btnInitCamera.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 850);
            this.Controls.Add(this.btnInitCamera);
            this.Controls.Add(this.btnScanDevices);
            this.Controls.Add(this.comboBoxCameras);
            this.Controls.Add(this.btnTakePhoto);
            this.Controls.Add(this.pictureBoxLive);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLive;
        private System.Windows.Forms.Button btnTakePhoto;
        private System.Windows.Forms.Timer photoTimer;
        private System.Windows.Forms.ComboBox comboBoxCameras;
        private System.Windows.Forms.Button btnScanDevices;
        private System.Windows.Forms.Button btnInitCamera;
    }
}

