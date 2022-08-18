namespace UDD_Launcher_v0._2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loadingBox = new System.Windows.Forms.PictureBox();
            this.loadingBox1 = new System.Windows.Forms.PictureBox();
            this.loadingBox2 = new System.Windows.Forms.PictureBox();
            this.loadingBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loadingBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // loadingBox
            // 
            this.loadingBox.BackColor = System.Drawing.Color.Transparent;
            this.loadingBox.Image = ((System.Drawing.Image)(resources.GetObject("loadingBox.Image")));
            this.loadingBox.Location = new System.Drawing.Point(230, 240);
            this.loadingBox.Name = "loadingBox";
            this.loadingBox.Size = new System.Drawing.Size(272, 93);
            this.loadingBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingBox.TabIndex = 0;
            this.loadingBox.TabStop = false;
            // 
            // loadingBox1
            // 
            this.loadingBox1.BackColor = System.Drawing.Color.Transparent;
            this.loadingBox1.Image = ((System.Drawing.Image)(resources.GetObject("loadingBox1.Image")));
            this.loadingBox1.Location = new System.Drawing.Point(238, 240);
            this.loadingBox1.Name = "loadingBox1";
            this.loadingBox1.Size = new System.Drawing.Size(272, 93);
            this.loadingBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingBox1.TabIndex = 1;
            this.loadingBox1.TabStop = false;
            // 
            // loadingBox2
            // 
            this.loadingBox2.BackColor = System.Drawing.Color.Transparent;
            this.loadingBox2.Image = ((System.Drawing.Image)(resources.GetObject("loadingBox2.Image")));
            this.loadingBox2.Location = new System.Drawing.Point(247, 240);
            this.loadingBox2.Name = "loadingBox2";
            this.loadingBox2.Size = new System.Drawing.Size(272, 93);
            this.loadingBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingBox2.TabIndex = 2;
            this.loadingBox2.TabStop = false;
            // 
            // loadingBox3
            // 
            this.loadingBox3.BackColor = System.Drawing.Color.Transparent;
            this.loadingBox3.Image = ((System.Drawing.Image)(resources.GetObject("loadingBox3.Image")));
            this.loadingBox3.Location = new System.Drawing.Point(256, 240);
            this.loadingBox3.Name = "loadingBox3";
            this.loadingBox3.Size = new System.Drawing.Size(272, 93);
            this.loadingBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingBox3.TabIndex = 3;
            this.loadingBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadingBox3);
            this.Controls.Add(this.loadingBox2);
            this.Controls.Add(this.loadingBox1);
            this.Controls.Add(this.loadingBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadingBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox loadingBox;
        private System.Windows.Forms.PictureBox loadingBox1;
        private System.Windows.Forms.PictureBox loadingBox2;
        private System.Windows.Forms.PictureBox loadingBox3;
    }
}

