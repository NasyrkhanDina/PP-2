namespace Paint_Form
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.penchik = new System.Windows.Forms.Button();
            this.rectanglechik = new System.Windows.Forms.Button();
            this.circlechik = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Fill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(644, 302);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // penchik
            // 
            this.penchik.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("penchik.BackgroundImage")));
            this.penchik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.penchik.Location = new System.Drawing.Point(12, 13);
            this.penchik.Name = "penchik";
            this.penchik.Size = new System.Drawing.Size(55, 41);
            this.penchik.TabIndex = 1;
            this.penchik.UseVisualStyleBackColor = true;
            this.penchik.Click += new System.EventHandler(this.penchik_Click);
            // 
            // rectanglechik
            // 
            this.rectanglechik.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rectanglechik.BackgroundImage")));
            this.rectanglechik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectanglechik.Location = new System.Drawing.Point(73, 12);
            this.rectanglechik.Name = "rectanglechik";
            this.rectanglechik.Size = new System.Drawing.Size(55, 41);
            this.rectanglechik.TabIndex = 2;
            this.rectanglechik.UseVisualStyleBackColor = true;
            this.rectanglechik.Click += new System.EventHandler(this.rectanglechik_Click);
            // 
            // circlechik
            // 
            this.circlechik.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.circlechik.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circlechik.BackgroundImage")));
            this.circlechik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circlechik.Location = new System.Drawing.Point(134, 12);
            this.circlechik.Name = "circlechik";
            this.circlechik.Size = new System.Drawing.Size(55, 41);
            this.circlechik.TabIndex = 3;
            this.circlechik.UseVisualStyleBackColor = false;
            this.circlechik.Click += new System.EventHandler(this.circlechik_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(195, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "save";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(276, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 20);
            this.button5.TabIndex = 5;
            this.button5.Text = "open";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(357, 12);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 6;
            // 
            // Fill
            // 
            this.Fill.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Fill.Location = new System.Drawing.Point(467, 12);
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(45, 41);
            this.Fill.TabIndex = 7;
            this.Fill.Text = "Fill";
            this.Fill.UseVisualStyleBackColor = false;
            this.Fill.Click += new System.EventHandler(this.Fill_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 373);
            this.Controls.Add(this.Fill);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.circlechik);
            this.Controls.Add(this.rectanglechik);
            this.Controls.Add(this.penchik);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.Text = " /";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button penchik;
        private System.Windows.Forms.Button rectanglechik;
        private System.Windows.Forms.Button circlechik;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button Fill;
    }
}

