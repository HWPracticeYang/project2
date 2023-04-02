
namespace WindowsFormsApp1
{
    partial class Easy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Easy));
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblOperation1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblEqual = new System.Windows.Forms.Label();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNum1.Location = new System.Drawing.Point(164, 122);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(43, 30);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "lbl";
            // 
            // lblOperation1
            // 
            this.lblOperation1.AutoSize = true;
            this.lblOperation1.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOperation1.Location = new System.Drawing.Point(251, 121);
            this.lblOperation1.Name = "lblOperation1";
            this.lblOperation1.Size = new System.Drawing.Size(49, 30);
            this.lblOperation1.TabIndex = 1;
            this.lblOperation1.Text = "lb1";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNum2.Location = new System.Drawing.Point(334, 122);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(43, 30);
            this.lblNum2.TabIndex = 2;
            this.lblNum2.Text = "lbl";
            // 
            // lblEqual
            // 
            this.lblEqual.AutoSize = true;
            this.lblEqual.BackColor = System.Drawing.Color.Transparent;
            this.lblEqual.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEqual.Location = new System.Drawing.Point(412, 122);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(29, 30);
            this.lblEqual.TabIndex = 3;
            this.lblEqual.Text = "=";
            // 
            // txtAns
            // 
            this.txtAns.Location = new System.Drawing.Point(469, 123);
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(100, 29);
            this.txtAns.TabIndex = 4;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(615, 121);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(82, 29);
            this.btn.TabIndex = 5;
            this.btn.Text = "確定";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("新細明體", 11F);
            this.lblTime.Location = new System.Drawing.Point(185, 32);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(60, 22);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "label1";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("新細明體", 11F);
            this.lblTitle.Location = new System.Drawing.Point(75, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(104, 22);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "剩餘時間:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Easy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(829, 593);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtAns);
            this.Controls.Add(this.lblEqual);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblOperation1);
            this.Controls.Add(this.lblNum1);
            this.Name = "Easy";
            this.Text = "遊戲畫面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblOperation1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblEqual;
        private System.Windows.Forms.TextBox txtAns;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.Timer timer1;
    }
}