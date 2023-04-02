
namespace WindowsFormsApp1
{
    partial class register
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.lblRegister = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pic = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.BackColor = System.Drawing.Color.Transparent;
            this.lblRegister.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRegister.Location = new System.Drawing.Point(349, 80);
            this.lblRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(75, 30);
            this.lblRegister.TabIndex = 0;
            this.lblRegister.Text = "註冊";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblAccount.Font = new System.Drawing.Font("新細明體", 10F);
            this.lblAccount.Location = new System.Drawing.Point(281, 150);
            this.lblAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(54, 20);
            this.lblAccount.TabIndex = 1;
            this.lblAccount.Text = "帳號:";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(345, 141);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(2);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(192, 29);
            this.txtAccount.TabIndex = 2;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.Font = new System.Drawing.Font("新細明體", 10F);
            this.lblpassword.Location = new System.Drawing.Point(281, 260);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(54, 20);
            this.lblpassword.TabIndex = 3;
            this.lblpassword.Text = "密碼:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(345, 251);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(192, 29);
            this.txtPassword.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("新細明體", 10F);
            this.label1.Location = new System.Drawing.Point(201, 316);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "重新確認密碼:";
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(345, 307);
            this.txtPassword2.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(192, 29);
            this.txtPassword2.TabIndex = 6;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(345, 366);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(65, 40);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "註冊";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "左箭.png");
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.Transparent;
            this.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.Location = new System.Drawing.Point(-11, -2);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(86, 67);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 8;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("新細明體", 10F);
            this.lblName.Location = new System.Drawing.Point(261, 204);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 20);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "玩家名:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(345, 195);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(192, 29);
            this.txtname.TabIndex = 10;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(234)))), ((int)(((byte)(252)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(799, 501);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "register";
            this.Text = "register";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtname;
    }
}