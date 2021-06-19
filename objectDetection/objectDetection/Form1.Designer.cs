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
            this.panel1 = new System.Windows.Forms.Panel();
            this.playVideo = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.pictureBoxIpl1 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImageForDetec)).BeginInit();
            this.tabImage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabVideo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetection
            // 
            this.btnDetection.Location = new System.Drawing.Point(311, 14);
            this.btnDetection.Name = "btnDetection";
            this.btnDetection.Size = new System.Drawing.Size(110, 25);
            this.btnDetection.TabIndex = 1;
            this.btnDetection.Text = "Detec";
            this.btnDetection.UseVisualStyleBackColor = true;
            this.btnDetection.Click += new System.EventHandler(this.btnDetection_Click);
            // 
            // picBoxImageForDetec
            // 
            this.picBoxImageForDetec.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picBoxImageForDetec.Location = new System.Drawing.Point(3, 103);
            this.picBoxImageForDetec.Name = "picBoxImageForDetec";
            this.picBoxImageForDetec.Size = new System.Drawing.Size(1356, 555);
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
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.picBoxImageForDetec);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1362, 661);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Detec Image";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnImage);
            this.panel2.Controls.Add(this.btnDetection);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1356, 100);
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
            this.playVideo.Location = new System.Drawing.Point(7, 18);
            this.playVideo.Name = "playVideo";
            this.playVideo.Size = new System.Drawing.Size(149, 23);
            this.playVideo.TabIndex = 5;
            this.playVideo.Text = "Play video";
            this.playVideo.UseVisualStyleBackColor = true;
            this.playVideo.Click += new System.EventHandler(this.playVideo_Click_1);
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(22, 16);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(176, 23);
            this.btnImage.TabIndex = 2;
            this.btnImage.Text = "Select Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click_1);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 688);
            this.Controls.Add(this.tabImage);
            this.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImageForDetec)).EndInit();
            this.tabImage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabVideo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).EndInit();
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
        private System.Windows.Forms.Button btnImage;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl1;
    }
}

