using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace PhotoBoothApp
{
    public partial class Form1 : Form
    {
        private List<VideoCapture> cameras = new List<VideoCapture>();
        private VideoCapture currentCamera;
        private Mat currentFrame = new Mat();
        private Bitmap previewImage;
        private bool isRunning = false;

        private List<Bitmap> capturedImages = new List<Bitmap>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ScanForCameras();
            LoadInstalledPrinters();
        }

        private void ScanForCameras()
        {
            foreach (var cam in cameras)
            {
                cam.Release();
            }
            cameras.Clear();
            comboBoxCameras.Items.Clear();

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    var cam = new VideoCapture(i);
                    if (cam.IsOpened())
                    {
                        cameras.Add(cam);
                        comboBoxCameras.Items.Add($"Camera {i}");
                    }
                    else
                    {
                        cam.Release();
                    }
                }
                catch { }
            }

            if (cameras.Count > 0)
            {
                comboBoxCameras.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("❌ No cameras found.");
            }
        }

        private void LoadInstalledPrinters()
        {
            comboBoxPrinters.Items.Clear();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                comboBoxPrinters.Items.Add(printer);
            }

            PrintDocument pd = new PrintDocument();
            comboBoxPrinters.SelectedItem = pd.PrinterSettings.PrinterName;
        }

        private void comboBoxCameras_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartCamera(comboBoxCameras.SelectedIndex);
        }

        private void StartCamera(int index)
        {
            StopCamera();

            currentCamera = cameras[index];
            isRunning = true;

            Task.Run(() =>
            {
                while (isRunning)
                {
                    currentCamera.Read(currentFrame);
                    if (!currentFrame.Empty())
                    {
                        Mat flippedFrame = new Mat();
                        Cv2.Flip(currentFrame, flippedFrame, FlipMode.Y); // Flip horizontally

                        previewImage = BitmapConverter.ToBitmap(flippedFrame);

                        if (pictureBoxLive.InvokeRequired)
                        {
                            pictureBoxLive.Invoke(new Action(() =>
                            {
                                pictureBoxLive.Image?.Dispose();
                                pictureBoxLive.Image = (Bitmap)previewImage.Clone();
                            }));
                        }

                        if (pictureBoxPreview.InvokeRequired)
                        {
                            pictureBoxPreview.Invoke(new Action(() =>
                            {
                                pictureBoxPreview.Image?.Dispose();
                                pictureBoxPreview.Image = (Bitmap)previewImage.Clone();
                            }));
                        }
                    }
                }
            });
        }

        private void StopCamera()
        {
            isRunning = false;
            if (currentCamera != null)
            {
                currentCamera.Release();
            }
        }

        private async void btnTakePhoto_Click(object sender, EventArgs e)
        {
            capturedImages.Clear();

            for (int i = 0; i < 3; i++)
            {
                if (previewImage != null)
                {
                    capturedImages.Add((Bitmap)previewImage.Clone());
                }
                await Task.Delay(1000);
            }

            PrintCapturedImages();
        }

        private void PrintCapturedImages()
        {
            if (capturedImages.Count == 0) return;

            string selectedPrinter = comboBoxPrinters.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedPrinter))
            {
                MessageBox.Show("Please select a printer first.");
                return;
            }

            PrintDocument printDoc = new PrintDocument();
            printDoc.PrinterSettings.PrinterName = selectedPrinter;

            printDoc.PrintPage += (s, e) =>
            {
                int imageCount = capturedImages.Count;
                int spacing = 20; // space between images
                int availableHeight = e.MarginBounds.Height;
                int availableWidth = e.MarginBounds.Width;

                // Total spacing height
                int totalSpacing = spacing * (imageCount + 1);

                // Max height available for all images
                int maxImageHeightTotal = availableHeight - totalSpacing;
                int maxImageHeightEach = maxImageHeightTotal / imageCount;

                int y = e.MarginBounds.Top + spacing;

                foreach (Bitmap img in capturedImages)
                {
                    // Calculate new size preserving aspect ratio
                    float ratio = (float)img.Width / img.Height;
                    int newHeight = maxImageHeightEach;
                    int newWidth = (int)(newHeight * ratio);

                    // Center horizontally
                    int x = e.MarginBounds.Left + (availableWidth - newWidth) / 2;

                    e.Graphics.DrawImage(img, new Rectangle(x, y, newWidth, newHeight));
                    y += newHeight + spacing;
                }

                // Optional: Draw label at the bottom
                string footer = "PhotoBooth App 2025!";
                Font font = new Font("Arial", 16, FontStyle.Bold);
                SizeF textSize = e.Graphics.MeasureString(footer, font);
                float textX = e.MarginBounds.Left + (availableWidth - textSize.Width) / 2;
                float textY = y;

                e.Graphics.DrawString(footer, font, Brushes.Black, textX, textY);
            };

            try
            {
                printDoc.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Print failed: {ex.Message}");
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCamera();
        }

        private void btnScanDevices_Click(object sender, EventArgs e)
        {
            ScanForCameras();
            LoadInstalledPrinters();
        }
    }
}
