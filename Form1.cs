using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoBoothApp
{
    public partial class Form1 : Form
    {
        private VideoCapture currentCamera;
        private Bitmap previewImage;
        private bool isRunning = false;
        private List<VideoCapture> cameras = new List<VideoCapture>();
        private List<Bitmap> capturedImages = new List<Bitmap>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize camera list and populate ComboBox
            ScanForCameras();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCamera();
        }

        private void btnScanDevices_Click(object sender, EventArgs e)
        {
            ScanForCameras();
        }

        private void btnInitCamera_Click(object sender, EventArgs e)
        {
            // Start selected camera
            if (comboBoxCameras.SelectedIndex >= 0)
            {
                StartCamera(comboBoxCameras.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a camera first.");
            }
        }

        private void btnTakePhoto_Click(object sender, EventArgs e)
        {
            _ = TakePhotosAsync();
        }

        // Scan for cameras and add them to ComboBox
        private void ScanForCameras()
        {
            StopCamera();
            cameras.Clear();
            comboBoxCameras.Items.Clear();

            // Check up to 5 camera indices (adjust this number if needed)
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    VideoCapture cam = new VideoCapture(i);
                    if (cam.IsOpened())
                    {
                        cameras.Add(cam);
                        comboBoxCameras.Items.Add($"Camera {i}");
                        Console.WriteLine($"Camera {i} is available.");
                    }
                    else
                    {
                        cam.Release();
                    }
                }
                catch
                {
                    // If a camera is not available, we catch the error
                    Console.WriteLine($"Camera {i} is not available.");
                }
            }

            if (comboBoxCameras.Items.Count > 0)
            {
                comboBoxCameras.SelectedIndex = 0; // Select the first available camera by default
            }
            else
            {
                MessageBox.Show("❌ No cameras found.");
            }
        }

        // Start the camera feed when selected from ComboBox
        private void StartCamera(int index)
        {
            StopCamera();

            if (index < 0 || index >= cameras.Count)
            {
                MessageBox.Show("Invalid camera selected.");
                return;
            }

            currentCamera = cameras[index];
            isRunning = true;

            Task.Run(() =>
            {
                while (isRunning)
                {
                    using (Mat frame = new Mat())
                    {
                        currentCamera.Read(frame);
                        if (!frame.Empty())
                        {
                            previewImage = BitmapConverter.ToBitmap(frame);

                            // Ensure the PictureBox gets updated on the UI thread
                            if (pictureBoxLive.InvokeRequired)
                            {
                                pictureBoxLive.Invoke(new Action(() =>
                                {
                                    pictureBoxLive.Image?.Dispose();
                                    pictureBoxLive.Image = new Bitmap(previewImage);
                                }));
                            }
                            else
                            {
                                pictureBoxLive.Image?.Dispose();
                                pictureBoxLive.Image = new Bitmap(previewImage);
                            }
                        }
                    }
                }
            });
        }

        // Stop the camera feed
        private void StopCamera()
        {
            isRunning = false;
            if (currentCamera != null)
            {
                currentCamera.Release();
                currentCamera.Dispose();
                currentCamera = null;
            }

            pictureBoxLive.Image?.Dispose();
            pictureBoxLive.Image = null;
        }

        // Take 3 photos with a 1-second delay between each
        private async Task TakePhotosAsync()
        {
            capturedImages.Clear();

            for (int i = 0; i < 3; i++)
            {
                if (previewImage != null)
                {
                    capturedImages.Add((Bitmap)previewImage.Clone());
                }
                await Task.Delay(1000); // Delay of 1 second between photos
            }

            PrintCapturedImages();
        }

        // Print captured images (stacked vertically)
        private void PrintCapturedImages()
        {
            if (capturedImages.Count == 0) return;

            int width = capturedImages[0].Width;
            int height = capturedImages[0].Height;
            Bitmap combined = new Bitmap(width, height * 3);

            using (Graphics g = Graphics.FromImage(combined))
            {
                for (int i = 0; i < capturedImages.Count; i++)
                {
                    g.DrawImage(capturedImages[i], 0, i * height);
                }
            }

            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += (s, e) =>
            {
                e.Graphics.DrawImage(combined, 0, 0);
            };

            printDoc.Print();
        }
    }
}
