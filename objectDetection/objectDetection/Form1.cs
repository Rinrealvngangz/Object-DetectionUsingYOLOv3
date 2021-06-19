using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
        //YOLOv3
        //https://github.com/pjreddie/darknet/blob/master/cfg/yolov3.cfg
        private const string Cfg = "yolov3-tiny.cfg";

    //  private const string Cfgv3 = "yolov3.cfg";
        //https://pjreddie.com/media/files/yolov3.weights
        private const string Weight = "yolov3-tiny.weights";
   //     private const string Weightv3 = "yolov3.weights";
        //https://github.com/pjreddie/darknet/blob/master/data/coco.names
        private const string Names = "coco.names";
       
        //file location
        private readonly static  string Location = "../../dataset";

        private readonly static string label = Path.Combine(Location, Names);

        private readonly static  string  config = Path.Combine(Location, Cfg);

        private readonly static string weights = Path.Combine(Location, Weight);

     

      //  private readonly static string configv3 = Path.Combine(Location, Cfgv3);

      //  private readonly static string weightsv3 = Path.Combine(Location, Weightv3);

        // Init Yolov3-tiny
        private readonly static YoloWrapper yoloWrapper = new YoloWrapper(config, weights, label);
        // Init Yolov3
    //    private readonly static YoloWrapper yoloV3Wrapper = new YoloWrapper(configv3, weightsv3, label);

        // Color Random
        private static readonly Scalar[] Colors = Enumerable.Repeat(false, 80).Select(x => Scalar.RandomColor()).ToArray();
      //  int countCar, countBicycle, countBus, countMoto, countTruck, countTrain = 0;
      
        private static readonly List<string> Labels = File.ReadAllLines(label).ToList();

        private void playVideo_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "(mp3,wav,mp4,mov,wmv,mpg)|*.mp3;*.wav;*.mp4;*.mov;*.wmv;*.mpg|all files|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string filePathVideo = openFile.FileName;

                CaptureVideo(filePathVideo);
            
            }
        }
        private void btnDetection_Click(object sender, EventArgs e)
        {
            DetecImage();
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

       void CaptureVideo(object filePathVideo)
        {
            // YOLO setting
            int yoloWidth = pictureBoxIpl1.Width, yoloHeight = pictureBoxIpl1.Height;
         
            VideoCapture videocapture;
            Mat image = new Mat();
            WriteableBitmap wb = new WriteableBitmap(yoloWidth, yoloHeight, 96, 96, PixelFormats.Bgr24, null);

            byte[] imageInBytes = new byte[(int)(yoloWidth * yoloHeight * image.Channels())];
            using (videocapture = new VideoCapture((string)filePathVideo))
            {
                int sleepTime = (int)Math.Round(1000 / videocapture.Fps);
                using (Mat imageOriginal = new Mat())
                    {
                    while (true)
                    {
                        // read a single frame and convert the frame into a byte array
                  
                         videocapture.Read(imageOriginal);
                     
                            videocapture.Read(imageOriginal);
                   
                        image = imageOriginal.Resize(new OpenCvSharp.Size(yoloWidth, yoloHeight));
                        if (image.Empty())
                            break;
                        imageInBytes = image.ToBytes();

                        // conduct object detection and display the result
                        var items = yoloWrapper.Detect(imageInBytes);

                        // get result         
                        GetValueInImage(items, image);
                   
                        // display the detection result
                        WriteableBitmapConverter.ToWriteableBitmap(image, wb);
                        //  pictureBoxIpl1.Image = BitmapFromSource(wb);
                        Bitmap bitmap = BitmapFromSource(wb);
                       
                          SetImage(bitmap);
                      
                       
                        Cv2.WaitKey(0);
                  
                    }
                }
               
            }
        }

        delegate void SetImageCallback(Bitmap bitmap);
        private void SetImage(Bitmap bitmap)
        {

            if (this.pictureBoxIpl1.InvokeRequired)
            {
                SetImageCallback d = new SetImageCallback(SetImage);
                pictureBoxIpl1.Invoke(d, new object[] { bitmap });
            }
            else
            {
                pictureBoxIpl1.Image = bitmap;
            }
        }

        void OpenImage()
        {
            
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                filePath = openFile.FileName;
              /*  countCar = 0;
                countBicycle = 0;
                countBus = 0;
                countMoto = 0;
                countTruck = 0;
                countTrain = 0;*/
            }

        }
        private void btnImage_Click_1(object sender, EventArgs e)
        {
            OpenImage();
            if (filePath != string.Empty)
            {
                picBoxImageForDetec.Image = Image.FromFile(filePath);

            }

        }
      

        void DetecImage()
        {

             
                var items = yoloWrapper.Detect(filePath);

            //    var image = Image.FromFile(filePath);
                var org = new Mat(filePath);
                   GetValueInImage(items, org);
                /*  using (var grap = Graphics.FromImage(image))
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

                   }*/
          

                picBoxImageForDetec.Image = BitmapConverter.ToBitmap(org);
            
        }
    
        /// <summary>
        /// Draw result to image
        /// </summary>
        /// <param name="image"></param>
        /// <param name="confidence"></param>
        /// <param name="centerX"></param>
        /// <param name="centerY"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        private static void Draw(Mat image, string item, float confidence,  double centerX, double centerY, double width, double height)
        {
            //label formating
            var label = $"{item} {confidence * 100:0.00}%";
            var ranColor = Labels.IndexOf(item);
            //draw result
            image.Rectangle(new OpenCvSharp.Point(centerX, centerY ), new OpenCvSharp.Point(centerX + width, centerY + height), Colors[ranColor], 2);
            var textSize = Cv2.GetTextSize(label, HersheyFonts.HersheyTriplex, 0.5, 1, out var baseline);
            Cv2.Rectangle(image, new Rect(new OpenCvSharp.Point(centerX, centerY - textSize.Height),
               new OpenCvSharp.Size(textSize.Width, textSize.Height + baseline)), Colors[ranColor], Cv2.FILLED);
            var textColor = Cv2.Mean(Colors[ranColor]).Val0 < 70 ? Scalar.White : Scalar.Black;
            Cv2.PutText(image, label, new OpenCvSharp.Point(centerX, centerY ), HersheyFonts.HersheyTriplex, 0.5, textColor);
        }

        private static void GetValueInImage(IEnumerable<Alturos.Yolo.Model.YoloItem> items ,Mat image)
        {
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
                    Draw(image, type, (float)item.Confidence, x, y, width, height);
                }
            }

        }


    }
}
