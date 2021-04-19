using System;
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
     
       
        string filePath = "";
        
        void OpenImage()
        {
          
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
               filePath =  openFile.FileName;

            }
            
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
             OpenImage();
            if(filePath != string.Empty)
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
                 foreach(var item in items.ToList())
                {
                        using (var pen = new Pen(Color.Red,3))
                        {
                            grap.DrawRectangle(pen, item.X, item.Y, item.Width, item.Height);
                            Font font = new Font("Meiryo UI",12);
                            SolidBrush brush = new SolidBrush(Color.Green);
                            grap.DrawString(item.Type.ToString(), font, brush, item.X, item.Y);
                            grap.Flush();
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
