
namespace WindowsFormsApp1
{
    partial class pic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pic));
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picLevel1 = new System.Windows.Forms.PictureBox();
            this.lblEasy = new System.Windows.Forms.Label();
            this.lblNormal = new System.Windows.Forms.Label();
            this.lblDifficult = new System.Windows.Forms.Label();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLevel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.Color.Transparent;
            this.pic1.Image = ((System.Drawing.Image)(resources.GetObject("pic1.Image")));
            this.pic1.Location = new System.Drawing.Point(152, 433);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(228, 179);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.BackColor = System.Drawing.Color.Transparent;
            this.pic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic2.Image = ((System.Drawing.Image)(resources.GetObject("pic2.Image")));
            this.pic2.Location = new System.Drawing.Point(351, 422);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(211, 174);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 1;
            this.pic2.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Curlz MT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblTitle.Location = new System.Drawing.Point(316, 116);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(269, 53);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "SELECT LEVEL";
            // 
            // picLevel1
            // 
            this.picLevel1.BackColor = System.Drawing.Color.Transparent;
            this.picLevel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLevel1.Image = ((System.Drawing.Image)(resources.GetObject("picLevel1.Image")));
            this.picLevel1.Location = new System.Drawing.Point(106, 202);
            this.picLevel1.Name = "picLevel1";
            this.picLevel1.Size = new System.Drawing.Size(180, 164);
            this.picLevel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLevel1.TabIndex = 3;
            this.picLevel1.TabStop = false;
            this.picLevel1.Click += new System.EventHandler(this.picLevel1_Click);
            // 
            // lblEasy
            // 
            this.lblEasy.AutoSize = true;
            this.lblEasy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblEasy.Font = new System.Drawing.Font("華康談楷體W5(P)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEasy.ForeColor = System.Drawing.Color.Olive;
            this.lblEasy.Location = new System.Drawing.Point(176, 277);
            this.lblEasy.Name = "lblEasy";
            this.lblEasy.Size = new System.Drawing.Size(56, 24);
            this.lblEasy.TabIndex = 8;
            this.lblEasy.Text = "Easy";
            this.lblEasy.Click += new System.EventHandler(this.lblEasy_Click);
            // 
            // lblNormal
            // 
            this.lblNormal.AutoSize = true;
            this.lblNormal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNormal.Font = new System.Drawing.Font("華康談楷體W5(P)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNormal.ForeColor = System.Drawing.Color.Olive;
            this.lblNormal.Location = new System.Drawing.Point(414, 277);
            this.lblNormal.Name = "lblNormal";
            this.lblNormal.Size = new System.Drawing.Size(77, 24);
            this.lblNormal.TabIndex = 9;
            this.lblNormal.Text = "Normal";
            this.lblNormal.Click += new System.EventHandler(this.lblNormal_Click);
            // 
            // lblDifficult
            // 
            this.lblDifficult.AutoSize = true;
            this.lblDifficult.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDifficult.Font = new System.Drawing.Font("華康談楷體W5(P)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDifficult.ForeColor = System.Drawing.Color.Olive;
            this.lblDifficult.Location = new System.Drawing.Point(656, 277);
            this.lblDifficult.Name = "lblDifficult";
            this.lblDifficult.Size = new System.Drawing.Size(94, 24);
            this.lblDifficult.TabIndex = 10;
            this.lblDifficult.Text = "Difficult";
            this.lblDifficult.Click += new System.EventHandler(this.lblDifficult_Click);
            // 
            // picBack
            // 
            this.picBack.BackColor = System.Drawing.Color.Transparent;
            this.picBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBack.Image = ((System.Drawing.Image)(resources.GetObject("picBack.Image")));
            this.picBack.Location = new System.Drawing.Point(-9, -3);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(89, 78);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBack.TabIndex = 13;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(351, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(601, 202);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 164);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(871, 624);
            this.Controls.Add(this.picBack);
            this.Controls.Add(this.lblDifficult);
            this.Controls.Add(this.lblNormal);
            this.Controls.Add(this.lblEasy);
            this.Controls.Add(this.picLevel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "pic";
            this.Text = "level";
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLevel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picLevel1;
        private System.Windows.Forms.Label lblEasy;
        private System.Windows.Forms.Label lblNormal;
        private System.Windows.Forms.Label lblDifficult;
        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}