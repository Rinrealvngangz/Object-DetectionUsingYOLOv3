using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alturos.Yolo;
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

                            using (var pen = new Pen(Color.Red, 3))
                            {
                                grap.DrawRectangle(pen, item.X, item.Y, item.Width, item.Height);
                                Font font = new Font("Meiryo UI", 15);
                                SolidBrush brush = new SolidBrush(Color.Green);
                                grap.DrawString(item.Type.ToString(), font, brush, item.X, item.Y);
                                grap.DrawString(Math.Round(item.Confidence * 100).ToString() + "%", new Font("Meiryo UI", 25), new SolidBrush(Color.Purple), item.X + (item.Width - 50), item.Y + (item.Height / 2));
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
                                grap.DrawString(listVehicle[i] + ": " + countCar, new Font("Meiryo UI", 24), new SolidBrush(Color.Red), 0, index);
                                index += 40;
                                break;
                            case "bus":
                                grap.DrawString(listVehicle[i] + ": " + countBus, new Font("Meiryo UI", 24), new SolidBrush(Color.Red), 0, index);
                                index += 40;
                                break;
                            case "bicycle":
                                grap.DrawString(listVehicle[i] + ": " + countBicycle, new Font("Meiryo UI", 24), new SolidBrush(Color.Red), 0, index);
                                index += 40;
                                break;
                            case "motorbike":
                                grap.DrawString(listVehicle[i] + ": " + countMoto, new Font("Meiryo UI", 24), new SolidBrush(Color.Red), 0, index);
                                index += 40;
                                break;
                            case "train":
                                grap.DrawString(listVehicle[i] + ": " + countTrain, new Font("Meiryo UI", 24), new SolidBrush(Color.Red), 0, index);
                                index += 40;
                                break;
                            case "truck":
                                grap.DrawString(listVehicle[i] + ": " + countTruck, new Font("Meiryo UI", 24), new SolidBrush(Color.Red), 0, index);
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
