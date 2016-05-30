namespace ImageShowByUrl
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.myURLImage1 = new ImageShowByUrl.MyURLImage();
            this.myURLImage2 = new ImageShowByUrl.MyURLImage();
            this.myURLImage3 = new ImageShowByUrl.MyURLImage();
            ((System.ComponentModel.ISupportInitialize)(this.myURLImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myURLImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myURLImage3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "加载图片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 21);
            this.textBox1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "清空";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // myURLImage1
            // 
            this.myURLImage1.ImageUrl = "";
            this.myURLImage1.Location = new System.Drawing.Point(12, 121);
            this.myURLImage1.Name = "myURLImage1";
            this.myURLImage1.Size = new System.Drawing.Size(253, 234);
            this.myURLImage1.TabIndex = 5;
            this.myURLImage1.TabStop = false;
            // 
            // myURLImage2
            // 
            this.myURLImage2.ImageUrl = "";
            this.myURLImage2.Location = new System.Drawing.Point(281, 121);
            this.myURLImage2.Name = "myURLImage2";
            this.myURLImage2.Size = new System.Drawing.Size(258, 234);
            this.myURLImage2.TabIndex = 5;
            this.myURLImage2.TabStop = false;
            // 
            // myURLImage3
            // 
            this.myURLImage3.ImageUrl = "";
            this.myURLImage3.Location = new System.Drawing.Point(424, 12);
            this.myURLImage3.Name = "myURLImage3";
            this.myURLImage3.Size = new System.Drawing.Size(115, 103);
            this.myURLImage3.TabIndex = 5;
            this.myURLImage3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 392);
            this.Controls.Add(this.myURLImage3);
            this.Controls.Add(this.myURLImage2);
            this.Controls.Add(this.myURLImage1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myURLImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myURLImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myURLImage3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private MyURLImage myURLImage1;
        private MyURLImage myURLImage2;
        private MyURLImage myURLImage3;
    }
}

