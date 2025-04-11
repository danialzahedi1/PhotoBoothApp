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
            this.comboBoxCameras = new System.Windows.Forms.ComboBox();
            this.pictureBoxLive = new System.Windows.Forms.PictureBox();
            this.btnTakePhoto = new System.Windows.Forms.Button();
            this.btnScanDevices = new System.Windows.Forms.Button();
            this.comboBoxPrinters = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpSetup = new System.Windows.Forms.TabPage();
            this.tpPhotobooth = new System.Windows.Forms.TabPage();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLive)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpSetup.SuspendLayout();
            this.tpPhotobooth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCameras
            // 
            this.comboBoxCameras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCameras.FormattingEnabled = true;
            this.comboBoxCameras.Location = new System.Drawing.Point(120, 36);
            this.comboBoxCameras.Name = "comboBoxCameras";
            this.comboBoxCameras.Size = new System.Drawing.Size(256, 24);
            this.comboBoxCameras.TabIndex = 0;
            this.comboBoxCameras.SelectedIndexChanged += new System.EventHandler(this.comboBoxCameras_SelectedIndexChanged);
            // 
            // pictureBoxLive
            // 
            this.pictureBoxLive.BackColor = System.Drawing.Color.DimGray;
            this.pictureBoxLive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLive.Location = new System.Drawing.Point(6, 6);
            this.pictureBoxLive.Name = "pictureBoxLive";
            this.pictureBoxLive.Size = new System.Drawing.Size(620, 408);
            this.pictureBoxLive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLive.TabIndex = 1;
            this.pictureBoxLive.TabStop = false;
            // 
            // btnTakePhoto
            // 
            this.btnTakePhoto.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTakePhoto.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakePhoto.Location = new System.Drawing.Point(182, 429);
            this.btnTakePhoto.Name = "btnTakePhoto";
            this.btnTakePhoto.Size = new System.Drawing.Size(257, 62);
            this.btnTakePhoto.TabIndex = 2;
            this.btnTakePhoto.Text = "Take Photo";
            this.btnTakePhoto.UseVisualStyleBackColor = false;
            this.btnTakePhoto.Click += new System.EventHandler(this.btnTakePhoto_Click);
            // 
            // btnScanDevices
            // 
            this.btnScanDevices.Location = new System.Drawing.Point(6, 6);
            this.btnScanDevices.Name = "btnScanDevices";
            this.btnScanDevices.Size = new System.Drawing.Size(108, 29);
            this.btnScanDevices.TabIndex = 3;
            this.btnScanDevices.Text = "Scan Devices";
            this.btnScanDevices.UseVisualStyleBackColor = true;
            this.btnScanDevices.Click += new System.EventHandler(this.btnScanDevices_Click);
            // 
            // comboBoxPrinters
            // 
            this.comboBoxPrinters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrinters.FormattingEnabled = true;
            this.comboBoxPrinters.Location = new System.Drawing.Point(120, 6);
            this.comboBoxPrinters.Name = "comboBoxPrinters";
            this.comboBoxPrinters.Size = new System.Drawing.Size(256, 24);
            this.comboBoxPrinters.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpSetup);
            this.tabControl1.Controls.Add(this.tpPhotobooth);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 537);
            this.tabControl1.TabIndex = 7;
            // 
            // tpSetup
            // 
            this.tpSetup.Controls.Add(this.pictureBoxPreview);
            this.tpSetup.Controls.Add(this.btnScanDevices);
            this.tpSetup.Controls.Add(this.comboBoxPrinters);
            this.tpSetup.Controls.Add(this.comboBoxCameras);
            this.tpSetup.Location = new System.Drawing.Point(4, 25);
            this.tpSetup.Name = "tpSetup";
            this.tpSetup.Padding = new System.Windows.Forms.Padding(3);
            this.tpSetup.Size = new System.Drawing.Size(632, 508);
            this.tpSetup.TabIndex = 0;
            this.tpSetup.Text = "Setup";
            this.tpSetup.UseVisualStyleBackColor = true;
            // 
            // tpPhotobooth
            // 
            this.tpPhotobooth.Controls.Add(this.pictureBoxLive);
            this.tpPhotobooth.Controls.Add(this.btnTakePhoto);
            this.tpPhotobooth.Location = new System.Drawing.Point(4, 25);
            this.tpPhotobooth.Name = "tpPhotobooth";
            this.tpPhotobooth.Padding = new System.Windows.Forms.Padding(3);
            this.tpPhotobooth.Size = new System.Drawing.Size(632, 508);
            this.tpPhotobooth.TabIndex = 1;
            this.tpPhotobooth.Text = "Photobooth";
            this.tpPhotobooth.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BackColor = System.Drawing.Color.DimGray;
            this.pictureBoxPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPreview.Location = new System.Drawing.Point(382, 6);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(244, 157);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPreview.TabIndex = 5;
            this.pictureBoxPreview.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(664, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "PhotoBoothApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLive)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpSetup.ResumeLayout(false);
            this.tpPhotobooth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Timer photoTimer;
        private System.Windows.Forms.PictureBox pictureBoxLive;
        private System.Windows.Forms.Button btnTakePhoto;
        private System.Windows.Forms.ComboBox comboBoxCameras;
        private System.Windows.Forms.Button btnScanDevices;
        private System.Windows.Forms.ComboBox comboBoxPrinters;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpSetup;
        private System.Windows.Forms.TabPage tpPhotobooth;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
    }
}

