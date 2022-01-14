namespace odev
{
    partial class HocaEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HocaEkrani));
            this.not_girisi = new System.Windows.Forms.Button();
            this.danisman_onay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.profil_goruntule = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cikis_yap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // not_girisi
            // 
            this.not_girisi.BackColor = System.Drawing.Color.Azure;
            this.not_girisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("not_girisi.BackgroundImage")));
            this.not_girisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.not_girisi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.not_girisi.Location = new System.Drawing.Point(45, 256);
            this.not_girisi.Name = "not_girisi";
            this.not_girisi.Size = new System.Drawing.Size(154, 138);
            this.not_girisi.TabIndex = 0;
            this.not_girisi.UseVisualStyleBackColor = false;
            this.not_girisi.Click += new System.EventHandler(this.not_girisi_Click);
            // 
            // danisman_onay
            // 
            this.danisman_onay.BackColor = System.Drawing.Color.Azure;
            this.danisman_onay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("danisman_onay.BackgroundImage")));
            this.danisman_onay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.danisman_onay.Location = new System.Drawing.Point(287, 257);
            this.danisman_onay.Name = "danisman_onay";
            this.danisman_onay.Size = new System.Drawing.Size(154, 138);
            this.danisman_onay.TabIndex = 1;
            this.danisman_onay.UseVisualStyleBackColor = false;
            this.danisman_onay.Click += new System.EventHandler(this.danisman_onay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(231, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // profil_goruntule
            // 
            this.profil_goruntule.BackColor = System.Drawing.Color.Azure;
            this.profil_goruntule.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profil_goruntule.BackgroundImage")));
            this.profil_goruntule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.profil_goruntule.Location = new System.Drawing.Point(524, 256);
            this.profil_goruntule.Name = "profil_goruntule";
            this.profil_goruntule.Size = new System.Drawing.Size(154, 141);
            this.profil_goruntule.TabIndex = 2;
            this.profil_goruntule.UseVisualStyleBackColor = false;
            this.profil_goruntule.Click += new System.EventHandler(this.profil_goruntule_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(54, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 145);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // cikis_yap
            // 
            this.cikis_yap.BackColor = System.Drawing.Color.Azure;
            this.cikis_yap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cikis_yap.BackgroundImage")));
            this.cikis_yap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cikis_yap.Location = new System.Drawing.Point(631, 22);
            this.cikis_yap.Name = "cikis_yap";
            this.cikis_yap.Size = new System.Drawing.Size(92, 78);
            this.cikis_yap.TabIndex = 7;
            this.cikis_yap.UseVisualStyleBackColor = false;
            this.cikis_yap.Click += new System.EventHandler(this.cikis_yap_Click);
            // 
            // HocaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(748, 551);
            this.Controls.Add(this.cikis_yap);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.profil_goruntule);
            this.Controls.Add(this.danisman_onay);
            this.Controls.Add(this.not_girisi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HocaEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOŞ GELDİNİZ";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.hocaEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button not_girisi;
        private System.Windows.Forms.Button danisman_onay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button profil_goruntule;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cikis_yap;
    }
}