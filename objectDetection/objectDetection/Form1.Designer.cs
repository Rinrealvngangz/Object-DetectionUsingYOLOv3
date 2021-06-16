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
            this.btnImage = new System.Windows.Forms.Button();
            this.btnDetection = new System.Windows.Forms.Button();
            this.picBoxImageForDetec = new System.Windows.Forms.PictureBox();
            this.pictureBoxVideo = new System.Windows.Forms.PictureBox();
            this.playVideo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImageForDetec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(14, 13);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(122, 25);
            this.btnImage.TabIndex = 0;
            this.btnImage.Text = "Open Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnDetection
            // 
            this.btnDetection.Location = new System.Drawing.Point(296, 13);
            this.btnDetection.Name = "btnDetection";
            this.btnDetection.Size = new System.Drawing.Size(110, 25);
            this.btnDetection.TabIndex = 1;
            this.btnDetection.Text = "Detec";
            this.btnDetection.UseVisualStyleBackColor = true;
            this.btnDetection.Click += new System.EventHandler(this.btnDetection_Click);
            // 
            // picBoxImageForDetec
            // 
            this.picBoxImageForDetec.Location = new System.Drawing.Point(14, 61);
            this.picBoxImageForDetec.Name = "picBoxImageForDetec";
            this.picBoxImageForDetec.Size = new System.Drawing.Size(485, 372);
            this.picBoxImageForDetec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxImageForDetec.TabIndex = 2;
            this.picBoxImageForDetec.TabStop = false;
            // 
            // pictureBoxVideo
            // 
            this.pictureBoxVideo.Location = new System.Drawing.Point(539, 61);
            this.pictureBoxVideo.Name = "pictureBoxVideo";
            this.pictureBoxVideo.Size = new System.Drawing.Size(789, 546);
            this.pictureBoxVideo.TabIndex = 3;
            this.pictureBoxVideo.TabStop = false;
            // 
            // playVideo
            // 
            this.playVideo.Location = new System.Drawing.Point(1033, 15);
            this.playVideo.Name = "playVideo";
            this.playVideo.Size = new System.Drawing.Size(75, 23);
            this.playVideo.TabIndex = 4;
            this.playVideo.Text = "Play video";
            this.playVideo.UseVisualStyleBackColor = true;
            this.playVideo.Click += new System.EventHandler(this.playVideo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 619);
            this.Controls.Add(this.playVideo);
            this.Controls.Add(this.pictureBoxVideo);
            this.Controls.Add(this.picBoxImageForDetec);
            this.Controls.Add(this.btnDetection);
            this.Controls.Add(this.btnImage);
            this.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImageForDetec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnDetection;
        private System.Windows.Forms.PictureBox picBoxImageForDetec;
        private System.Windows.Forms.PictureBox pictureBoxVideo;
        private System.Windows.Forms.Button playVideo;
    }
}

