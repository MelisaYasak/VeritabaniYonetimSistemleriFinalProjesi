namespace odevOgrenciOtomasyonu
{
    partial class OgrenciEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciEkrani));
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnNotGor = new System.Windows.Forms.Button();
            this.btnOnDers = new System.Windows.Forms.Button();
            this.btnDersKay = new System.Windows.Forms.Button();
            this.lblOgrId = new System.Windows.Forms.Label();
            this.lblOgrAd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Azure;
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGeri.Location = new System.Drawing.Point(684, 29);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(74, 62);
            this.btnGeri.TabIndex = 0;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnNotGor
            // 
            this.btnNotGor.BackColor = System.Drawing.Color.Azure;
            this.btnNotGor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNotGor.BackgroundImage")));
            this.btnNotGor.Location = new System.Drawing.Point(541, 225);
            this.btnNotGor.Name = "btnNotGor";
            this.btnNotGor.Size = new System.Drawing.Size(162, 113);
            this.btnNotGor.TabIndex = 1;
            this.btnNotGor.UseVisualStyleBackColor = false;
            this.btnNotGor.Click += new System.EventHandler(this.btnNotGor_Click_1);
            // 
            // btnOnDers
            // 
            this.btnOnDers.BackColor = System.Drawing.Color.Azure;
            this.btnOnDers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOnDers.BackgroundImage")));
            this.btnOnDers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOnDers.Location = new System.Drawing.Point(300, 225);
            this.btnOnDers.Name = "btnOnDers";
            this.btnOnDers.Size = new System.Drawing.Size(162, 113);
            this.btnOnDers.TabIndex = 2;
            this.btnOnDers.UseVisualStyleBackColor = false;
            this.btnOnDers.Click += new System.EventHandler(this.btnOnDers_Click);
            // 
            // btnDersKay
            // 
            this.btnDersKay.BackColor = System.Drawing.Color.Azure;
            this.btnDersKay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDersKay.BackgroundImage")));
            this.btnDersKay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDersKay.Location = new System.Drawing.Point(68, 225);
            this.btnDersKay.Name = "btnDersKay";
            this.btnDersKay.Size = new System.Drawing.Size(162, 113);
            this.btnDersKay.TabIndex = 3;
            this.btnDersKay.UseVisualStyleBackColor = false;
            this.btnDersKay.Click += new System.EventHandler(this.btnDersKay_Click);
            // 
            // lblOgrId
            // 
            this.lblOgrId.AutoSize = true;
            this.lblOgrId.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblOgrId.Location = new System.Drawing.Point(232, 59);
            this.lblOgrId.Name = "lblOgrId";
            this.lblOgrId.Size = new System.Drawing.Size(42, 16);
            this.lblOgrId.TabIndex = 4;
            this.lblOgrId.Text = "label1";
            // 
            // lblOgrAd
            // 
            this.lblOgrAd.AutoSize = true;
            this.lblOgrAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOgrAd.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblOgrAd.Location = new System.Drawing.Point(230, 98);
            this.lblOgrAd.Name = "lblOgrAd";
            this.lblOgrAd.Size = new System.Drawing.Size(42, 16);
            this.lblOgrAd.TabIndex = 5;
            this.lblOgrAd.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(86, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 88);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // OgrenciEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblOgrAd);
            this.Controls.Add(this.lblOgrId);
            this.Controls.Add(this.btnDersKay);
            this.Controls.Add(this.btnOnDers);
            this.Controls.Add(this.btnNotGor);
            this.Controls.Add(this.btnGeri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OgrenciEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Ekranı";
            this.Load += new System.EventHandler(this.OgrenciEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGeri;
        private Button btnNotGor;
        private Button btnOnDers;
        private Button btnDersKay;
        private Label lblOgrId;
        private Label lblOgrAd;
        private PictureBox pictureBox1;
    }
}