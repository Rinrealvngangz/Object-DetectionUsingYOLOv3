namespace objectDetection
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
            this.btnDetection = new System.Windows.Forms.Button();
            this.picBoxImageForDetec = new System.Windows.Forms.PictureBox();
            this.tabImage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabVideo = new System.Windows.Forms.TabPage();
            this.pictureBoxIpl1 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.playVideo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbCar = new System.Windows.Forms.Label();
            this.lbBicycle = new System.Windows.Forms.Label();
            this.lbMotobike = new System.Windows.Forms.Label();
            this.lbBus = new System.Windows.Forms.Label();
            this.lbTruck = new System.Windows.Forms.Label();
            this.lbCountBus = new System.Windows.Forms.Label();
            this.lbCountBicycle = new System.Windows.Forms.Label();
            this.lbCountMoto = new System.Windows.Forms.Label();
            this.lbCountTruck = new System.Windows.Forms.Label();
            this.lbCountCar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCountTrain = new System.Windows.Forms.Label();
            this.btnImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImageForDetec)).BeginInit();
            this.tabImage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDetection
            // 
            this.btnDetection.ForeColor = System.Drawing.Color.White;
            this.btnDetection.Location = new System.Drawing.Point(185, 3);
            this.btnDetection.Name = "btnDetection";
            this.btnDetection.Size = new System.Drawing.Size(110, 25);
            this.btnDetection.TabIndex = 1;
            this.btnDetection.Text = "Detec";
            this.btnDetection.UseVisualStyleBackColor = true;
            this.btnDetection.Click += new System.EventHandler(this.btnDetection_Click);
            // 
            // picBoxImageForDetec
            // 
            this.picBoxImageForDetec.BackColor = System.Drawing.Color.Transparent;
            this.picBoxImageForDetec.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picBoxImageForDetec.Location = new System.Drawing.Point(3, 115);
            this.picBoxImageForDetec.Name = "picBoxImageForDetec";
            this.picBoxImageForDetec.Size = new System.Drawing.Size(1354, 541);
            this.picBoxImageForDetec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxImageForDetec.TabIndex = 2;
            this.picBoxImageForDetec.TabStop = false;
            // 
            // tabImage
            // 
            this.tabImage.Controls.Add(this.tabPage1);
            this.tabImage.Controls.Add(this.tabVideo);
            this.tabImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabImage.Location = new System.Drawing.Point(0, 0);
            this.tabImage.Name = "tabImage";
            this.tabImage.SelectedIndex = 0;
            this.tabImage.Size = new System.Drawing.Size(1370, 688);
            this.tabImage.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.picBoxImageForDetec);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1362, 661);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Detec Image";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1354, 100);
            this.panel2.TabIndex = 3;
            // 
            // tabVideo
            // 
            this.tabVideo.Controls.Add(this.pictureBoxIpl1);
            this.tabVideo.Controls.Add(this.panel1);
            this.tabVideo.Location = new System.Drawing.Point(4, 23);
            this.tabVideo.Name = "tabVideo";
            this.tabVideo.Padding = new System.Windows.Forms.Padding(3);
            this.tabVideo.Size = new System.Drawing.Size(1362, 661);
            this.tabVideo.TabIndex = 1;
            this.tabVideo.Text = "Detec Video";
            this.tabVideo.UseVisualStyleBackColor = true;
            // 
            // pictureBoxIpl1
            // 
            this.pictureBoxIpl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBoxIpl1.Location = new System.Drawing.Point(3, 107);
            this.pictureBoxIpl1.Name = "pictureBoxIpl1";
            this.pictureBoxIpl1.Size = new System.Drawing.Size(1356, 551);
            this.pictureBoxIpl1.TabIndex = 6;
            this.pictureBoxIpl1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.playVideo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1356, 98);
            this.panel1.TabIndex = 5;
            // 
            // playVideo
            // 
            this.playVideo.ForeColor = System.Drawing.Color.White;
            this.playVideo.Location = new System.Drawing.Point(7, 18);
            this.playVideo.Name = "playVideo";
            this.playVideo.Size = new System.Drawing.Size(149, 23);
            this.playVideo.TabIndex = 5;
            this.playVideo.Text = "Play video";
            this.playVideo.UseVisualStyleBackColor = true;
            this.playVideo.Click += new System.EventHandler(this.playVideo_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbCountTrain);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lbCountBus);
            this.panel3.Controls.Add(this.lbCountBicycle);
            this.panel3.Controls.Add(this.lbCountMoto);
            this.panel3.Controls.Add(this.lbCountTruck);
            this.panel3.Controls.Add(this.lbCountCar);
            this.panel3.Controls.Add(this.lbTruck);
            this.panel3.Controls.Add(this.lbBus);
            this.panel3.Controls.Add(this.lbMotobike);
            this.panel3.Controls.Add(this.lbBicycle);
            this.panel3.Controls.Add(this.lbCar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(401, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(953, 100);
            this.panel3.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnImage);
            this.flowLayoutPanel1.Controls.Add(this.btnDetection);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(21, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(376, 91);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // lbCar
            // 
            this.lbCar.AutoSize = true;
            this.lbCar.BackColor = System.Drawing.Color.Transparent;
            this.lbCar.Font = new System.Drawing.Font("Meiryo UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCar.ForeColor = System.Drawing.Color.White;
            this.lbCar.Location = new System.Drawing.Point(44, 17);
            this.lbCar.Name = "lbCar";
            this.lbCar.Size = new System.Drawing.Size(80, 23);
            this.lbCar.TabIndex = 0;
            this.lbCar.Text = "Xe ô tô:";
            // 
            // lbBicycle
            // 
            this.lbBicycle.AutoSize = true;
            this.lbBicycle.BackColor = System.Drawing.Color.Transparent;
            this.lbBicycle.Font = new System.Drawing.Font("Meiryo UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBicycle.ForeColor = System.Drawing.Color.White;
            this.lbBicycle.Location = new System.Drawing.Point(316, 56);
            this.lbBicycle.Name = "lbBicycle";
            this.lbBicycle.Size = new System.Drawing.Size(77, 23);
            this.lbBicycle.TabIndex = 1;
            this.lbBicycle.Text = "Xe đạp:";
            // 
            // lbMotobike
            // 
            this.lbMotobike.AutoSize = true;
            this.lbMotobike.BackColor = System.Drawing.Color.Transparent;
            this.lbMotobike.Font = new System.Drawing.Font("Meiryo UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMotobike.ForeColor = System.Drawing.Color.White;
            this.lbMotobike.Location = new System.Drawing.Point(316, 17);
            this.lbMotobike.Name = "lbMotobike";
            this.lbMotobike.Size = new System.Drawing.Size(82, 23);
            this.lbMotobike.TabIndex = 2;
            this.lbMotobike.Text = "Xe máy:";
            // 
            // lbBus
            // 
            this.lbBus.AutoSize = true;
            this.lbBus.BackColor = System.Drawing.Color.Transparent;
            this.lbBus.Font = new System.Drawing.Font("Meiryo UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBus.ForeColor = System.Drawing.Color.White;
            this.lbBus.Location = new System.Drawing.Point(522, 17);
            this.lbBus.Name = "lbBus";
            this.lbBus.Size = new System.Drawing.Size(85, 23);
            this.lbBus.TabIndex = 3;
            this.lbBus.Text = "Xe Buýt:";
            // 
            // lbTruck
            // 
            this.lbTruck.AutoSize = true;
            this.lbTruck.BackColor = System.Drawing.Color.Transparent;
            this.lbTruck.Font = new System.Drawing.Font("Meiryo UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTruck.ForeColor = System.Drawing.Color.White;
            this.lbTruck.Location = new System.Drawing.Point(44, 56);
            this.lbTruck.Name = "lbTruck";
            this.lbTruck.Size = new System.Drawing.Size(67, 23);
            this.lbTruck.TabIndex = 4;
            this.lbTruck.Text = "Xe tải:";
            // 
            // lbCountBus
            // 
            this.lbCountBus.AutoSize = true;
            this.lbCountBus.BackColor = System.Drawing.Color.Transparent;
            this.lbCountBus.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountBus.ForeColor = System.Drawing.Color.White;
            this.lbCountBus.Location = new System.Drawing.Point(613, 20);
            this.lbCountBus.Name = "lbCountBus";
            this.lbCountBus.Size = new System.Drawing.Size(19, 20);
            this.lbCountBus.TabIndex = 5;
            this.lbCountBus.Text = "0";
            // 
            // lbCountBicycle
            // 
            this.lbCountBicycle.AutoSize = true;
            this.lbCountBicycle.BackColor = System.Drawing.Color.Transparent;
            this.lbCountBicycle.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountBicycle.ForeColor = System.Drawing.Color.White;
            this.lbCountBicycle.Location = new System.Drawing.Point(404, 59);
            this.lbCountBicycle.Name = "lbCountBicycle";
            this.lbCountBicycle.Size = new System.Drawing.Size(19, 20);
            this.lbCountBicycle.TabIndex = 5;
            this.lbCountBicycle.Text = "0";
            // 
            // lbCountMoto
            // 
            this.lbCountMoto.AutoSize = true;
            this.lbCountMoto.BackColor = System.Drawing.Color.Transparent;
            this.lbCountMoto.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountMoto.ForeColor = System.Drawing.Color.White;
            this.lbCountMoto.Location = new System.Drawing.Point(404, 17);
            this.lbCountMoto.Name = "lbCountMoto";
            this.lbCountMoto.Size = new System.Drawing.Size(19, 20);
            this.lbCountMoto.TabIndex = 5;
            this.lbCountMoto.Text = "0";
            // 
            // lbCountTruck
            // 
            this.lbCountTruck.AutoSize = true;
            this.lbCountTruck.BackColor = System.Drawing.Color.Transparent;
            this.lbCountTruck.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountTruck.ForeColor = System.Drawing.Color.White;
            this.lbCountTruck.Location = new System.Drawing.Point(130, 60);
            this.lbCountTruck.Name = "lbCountTruck";
            this.lbCountTruck.Size = new System.Drawing.Size(19, 20);
            this.lbCountTruck.TabIndex = 5;
            this.lbCountTruck.Text = "0";
            // 
            // lbCountCar
            // 
            this.lbCountCar.AutoSize = true;
            this.lbCountCar.BackColor = System.Drawing.Color.Transparent;
            this.lbCountCar.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountCar.ForeColor = System.Drawing.Color.White;
            this.lbCountCar.Location = new System.Drawing.Point(130, 18);
            this.lbCountCar.Name = "lbCountCar";
            this.lbCountCar.Size = new System.Drawing.Size(19, 20);
            this.lbCountCar.TabIndex = 5;
            this.lbCountCar.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(526, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tàu lửa:";
            // 
            // lbCountTrain
            // 
            this.lbCountTrain.AutoSize = true;
            this.lbCountTrain.BackColor = System.Drawing.Color.Transparent;
            this.lbCountTrain.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountTrain.ForeColor = System.Drawing.Color.White;
            this.lbCountTrain.Location = new System.Drawing.Point(613, 59);
            this.lbCountTrain.Name = "lbCountTrain";
            this.lbCountTrain.Size = new System.Drawing.Size(19, 20);
            this.lbCountTrain.TabIndex = 7;
            this.lbCountTrain.Text = "0";
            // 
            // btnImage
            // 
            this.btnImage.ForeColor = System.Drawing.Color.White;
            this.btnImage.Location = new System.Drawing.Point(3, 3);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(176, 23);
            this.btnImage.TabIndex = 2;
            this.btnImage.Text = "Select Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 688);
            this.Controls.Add(this.tabImage);
            this.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImageForDetec)).EndInit();
            this.tabImage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabVideo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDetection;
        private System.Windows.Forms.PictureBox picBoxImageForDetec;
        private System.Windows.Forms.TabControl tabImage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tabVideo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button playVideo;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbTruck;
        private System.Windows.Forms.Label lbBus;
        private System.Windows.Forms.Label lbMotobike;
        private System.Windows.Forms.Label lbBicycle;
        private System.Windows.Forms.Label lbCar;
        private System.Windows.Forms.Label lbCountBus;
        private System.Windows.Forms.Label lbCountBicycle;
        private System.Windows.Forms.Label lbCountMoto;
        private System.Windows.Forms.Label lbCountTruck;
        private System.Windows.Forms.Label lbCountCar;
        private System.Windows.Forms.Label lbCountTrain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImage;
    }
}

