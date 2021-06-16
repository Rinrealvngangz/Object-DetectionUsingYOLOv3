using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Alturos.Yolo;
using OpenCvSharp;
using OpenCvSharp.Extensions;
namespace objectDetection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const string UNKOWN = "unknown key";
        const string PERSON = "person";
        string filePath = "";
      
        int countCar, countBicycle, countBus, countMoto, countTruck, countTrain = 0;

        private void playVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "(mp3,wav,mp4,mov,wmv,mpg)|*.mp3;*.wav;*.mp4;*.mov;*.wmv;*.mpg|all files|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
              string  filePathVideo = openFile.FileName;
                CaptureVideo(filePathVideo);
            }
                
        }
        Bitmap BitmapFromSource(BitmapSource bitmapsource)
        {
            Bitmap bitmap;
            using (MemoryStream outStream = new MemoryStream())
            {
                BitmapEncoder enc = new BmpBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create(bitmapsource));
                enc.Save(outStream);
                bitmap = new Bitmap(outStream);
            }
            return bitmap;
        }
        void CaptureVideo(string filePathVideo)
        {
            // YOLO setting
            int yoloWidth = 608, yoloHeight = 608;
          //  var configurationDetector = new YoloConfigurationDetector();
           // var config = configurationDetector.Detect();
            YoloWrapper yoloWrapperVideo = new YoloWrapper("yolov3.cfg", "yolov3.weights", "coco.names");

            VideoCapture videocapture;
            Mat image = new Mat();
            WriteableBitmap wb = new WriteableBitmap(yoloWidth, yoloHeight, 96, 96, PixelFormats.Bgr24, null);

            byte[] imageInBytes = new byte[(int)(yoloWidth * yoloHeight * image.Channels())];
            using (videocapture = new VideoCapture(filePathVideo))
            {
                int sleepTime = (int)Math.Round(1000 / videocapture.Fps);
                using (Mat imageOriginal = new Mat())
                    {
                    while (true)
                    {
                        // read a single frame and convert the frame into a byte array
                        videocapture.Read(imageOriginal);

                        image = imageOriginal.Resize(new OpenCvSharp.Size(yoloWidth, yoloHeight));
                        if (image.Empty())
                            break;
                        imageInBytes = image.ToBytes();

                        // conduct object detection and display the result
                        var items = yoloWrapperVideo.Detect(imageInBytes);

                        foreach (var item in items)
                        {
                            if (item.Type != UNKOWN && item.Type != PERSON)
                            {
                                var x = item.X;
                                var y = item.Y;
                                var width = item.Width;
                                var height = item.Height;
                                var type = item.Type;  // class name of the object

                                // draw a bounding box for the detected object
                                // you can set different colors for different classes
                                Cv2.Rectangle(image, new OpenCvSharp.Rect(x, y, width, height), Scalar.Green, 3);
                            }
                        }
                        
                    

                        // display the detection result
                        WriteableBitmapConverter.ToWriteableBitmap(image, wb);

                        pictureBoxVideo.Image = BitmapFromSource(wb);
                        Cv2.WaitKey(sleepTime);
                    }
                }
               
            }
        }
        void OpenImage()
        {
            
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                filePath = openFile.FileName;
                countCar = 0;
                countBicycle = 0;
                countBus = 0;
                countMoto = 0;
                countTruck = 0;
                countTrain = 0;
            }

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenImage();
            if (filePath != string.Empty)
            {
                picBoxImageForDetec.Image = Image.FromFile(filePath);

            }

        }

        void DetecImage()
        {

            // var configurationDetector = new YoloConfigurationDetector();
            //  var config = configurationDetector.Detect();
            using (var yoloWrapper = new YoloWrapper("yolov3.cfg", "yolov3.weights", "coco.names"))
            {
                
                var items = yoloWrapper.Detect(filePath);

                var image = Image.FromFile(filePath);
                using (var grap = Graphics.FromImage(image))
                {
                    ArrayList listVehicle = new ArrayList();
                    foreach (var item in items.ToList())
                    {
                        if (!listVehicle.Contains(item.Type))
                        {
                            listVehicle.Add(item.Type);
                        }
                        if (item.Type != UNKOWN && item.Type != PERSON)
                        {
                            switch (item.Type)
                            {
                                case "car":
                                    countCar++;
                                    break;
                                case "bus":
                                    countBus++;
                                    break;
                                case "bicycle":
                                    countBicycle++;
                                    break;
                                case "motorbike":
                                    countMoto++;
                                    break;
                                case "train":
                                    countTrain++;
                                    break;
                                case "truck":
                                    countTruck++;
                                    break;
                                default:
                                    break;
                            }

                            using (var pen = new System.Drawing.Pen(System.Drawing.Color.Red, 3))
                            {
                                grap.DrawRectangle(pen, item.X, item.Y, item.Width, item.Height);
                                Font font = new Font("Meiryo UI", 15);
                                SolidBrush brush = new SolidBrush(System.Drawing.Color.Green);
                                grap.DrawString(item.Type.ToString(), font, brush, item.X, item.Y);
                                grap.DrawString(Math.Round(item.Confidence * 100).ToString() + "%", new Font("Meiryo UI", 25), new SolidBrush(System.Drawing.Color.Purple), item.X + (item.Width - 50), item.Y + (item.Height / 2));
                                grap.Flush();
                            }
                        }

                    }
                    int index = 0;
                    for (int i = 0; i < listVehicle.Count; i++)
                    {

                        switch (listVehicle[i])
                        {

                            case "car":
                                grap.DrawString(listVehicle[i] + ": " + countCar, new Font("Meiryo UI", 24), new SolidBrush(System.Drawing.Color.Red), 0, index);
                                index += 40;
                                break;
                            case "bus":
                                grap.DrawString(listVehicle[i] + ": " + countBus, new Font("Meiryo UI", 24), new SolidBrush(System.Drawing.Color.Red), 0, index);
                                index += 40;
                                break;
                            case "bicycle":
                                grap.DrawString(listVehicle[i] + ": " + countBicycle, new Font("Meiryo UI", 24), new SolidBrush(System.Drawing.Color.Red), 0, index);
                                index += 40;
                                break;
                            case "motorbike":
                                grap.DrawString(listVehicle[i] + ": " + countMoto, new Font("Meiryo UI", 24), new SolidBrush(System.Drawing.Color.Red), 0, index);
                                index += 40;
                                break;
                            case "train":
                                grap.DrawString(listVehicle[i] + ": " + countTrain, new Font("Meiryo UI", 24), new SolidBrush(System.Drawing.Color.Red), 0, index);
                                index += 40;
                                break;
                            case "truck":
                                grap.DrawString(listVehicle[i] + ": " + countTruck, new Font("Meiryo UI", 24), new SolidBrush(System.Drawing.Color.Red), 0, index);
                                index += 40;
                                break;
                            default:
                                break;
                        }

                    }

                }

                picBoxImageForDetec.Image = image;
            }
        }

        private void btnDetection_Click(object sender, EventArgs e)
        {
            DetecImage();
        }
    }
}
