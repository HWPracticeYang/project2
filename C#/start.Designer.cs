
namespace WindowsFormsApp1
{
    partial class start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(start));
            this.btnclose = new System.Windows.Forms.Button();
            this.lblIntroduce = new System.Windows.Forms.Label();
            this.btnIntroduce = new System.Windows.Forms.Button();
            this.picBlue = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picWord = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblwelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(584, 200);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(71, 32);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "關閉";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Visible = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lblIntroduce
            // 
            this.lblIntroduce.BackColor = System.Drawing.Color.MistyRose;
            this.lblIntroduce.Location = new System.Drawing.Point(517, 102);
            this.lblIntroduce.Margin = new System.Windows.Forms.Padding(0);
            this.lblIntroduce.Name = "lblIntroduce";
            this.lblIntroduce.Size = new System.Drawing.Size(210, 139);
            this.lblIntroduce.TabIndex = 0;
            this.lblIntroduce.Text = "aa";
            this.lblIntroduce.Visible = false;
            // 
            // btnIntroduce
            // 
            this.btnIntroduce.BackColor = System.Drawing.Color.White;
            this.btnIntroduce.FlatAppearance.BorderSize = 0;
            this.btnIntroduce.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIntroduce.Location = new System.Drawing.Point(699, 11);
            this.btnIntroduce.Margin = new System.Windows.Forms.Padding(2);
            this.btnIntroduce.Name = "btnIntroduce";
            this.btnIntroduce.Size = new System.Drawing.Size(59, 44);
            this.btnIntroduce.TabIndex = 1;
            this.btnIntroduce.Text = "玩法";
            this.btnIntroduce.UseVisualStyleBackColor = false;
            this.btnIntroduce.Click += new System.EventHandler(this.btnIntroduce_Click);
            // 
            // picBlue
            // 
            this.picBlue.BackColor = System.Drawing.Color.Transparent;
            this.picBlue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBlue.BackgroundImage")));
            this.picBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBlue.Image = ((System.Drawing.Image)(resources.GetObject("picBlue.Image")));
            this.picBlue.Location = new System.Drawing.Point(193, 403);
            this.picBlue.Name = "picBlue";
            this.picBlue.Size = new System.Drawing.Size(246, 171);
            this.picBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBlue.TabIndex = 2;
            this.picBlue.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(288, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picWord
            // 
            this.picWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWord.Image = ((System.Drawing.Image)(resources.GetObject("picWord.Image")));
            this.picWord.Location = new System.Drawing.Point(426, -26);
            this.picWord.Name = "picWord";
            this.picWord.Size = new System.Drawing.Size(376, 386);
            this.picWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWord.TabIndex = 4;
            this.picWord.TabStop = false;
            this.picWord.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-8, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(237, 192);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.BackColor = System.Drawing.Color.MistyRose;
            this.lblwelcome.Font = new System.Drawing.Font("新細明體", 10F);
            this.lblwelcome.ForeColor = System.Drawing.Color.LightCoral;
            this.lblwelcome.Location = new System.Drawing.Point(335, 168);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(25, 20);
            this.lblwelcome.TabIndex = 6;
            this.lblwelcome.Text = "aa";
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(769, 610);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lblIntroduce);
            this.Controls.Add(this.picBlue);
            this.Controls.Add(this.btnIntroduce);
            this.Controls.Add(this.picWord);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "start";
            this.Text = "start";
            ((System.ComponentModel.ISupportInitialize)(this.picBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIntroduce;
        private System.Windows.Forms.Button btnIntroduce;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.PictureBox picBlue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picWord;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblwelcome;
    }
}