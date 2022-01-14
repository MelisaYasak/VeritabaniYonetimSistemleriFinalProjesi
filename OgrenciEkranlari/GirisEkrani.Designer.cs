namespace odevOgrenciOtomasyonu
{
    partial class GirisEkrani
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtKulAdi = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.lblKulAd = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.cboxSifreGoster = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Azure;
            this.btnGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGiris.BackgroundImage")));
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGiris.Location = new System.Drawing.Point(549, 230);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(151, 80);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtKulAdi
            // 
            this.txtKulAdi.Location = new System.Drawing.Point(514, 123);
            this.txtKulAdi.Name = "txtKulAdi";
            this.txtKulAdi.Size = new System.Drawing.Size(186, 23);
            this.txtKulAdi.TabIndex = 1;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(514, 171);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(186, 23);
            this.txtParola.TabIndex = 2;
            // 
            // lblKulAd
            // 
            this.lblKulAd.AutoSize = true;
            this.lblKulAd.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblKulAd.Location = new System.Drawing.Point(360, 125);
            this.lblKulAd.Name = "lblKulAd";
            this.lblKulAd.Size = new System.Drawing.Size(128, 23);
            this.lblKulAd.TabIndex = 3;
            this.lblKulAd.Text = "Kullanıcı Adı";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblParola.Location = new System.Drawing.Point(385, 173);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(69, 23);
            this.lblParola.TabIndex = 4;
            this.lblParola.Text = "Parola";
            // 
            // cboxSifreGoster
            // 
            this.cboxSifreGoster.AutoSize = true;
            this.cboxSifreGoster.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cboxSifreGoster.Location = new System.Drawing.Point(372, 261);
            this.cboxSifreGoster.Name = "cboxSifreGoster";
            this.cboxSifreGoster.Size = new System.Drawing.Size(97, 20);
            this.cboxSifreGoster.TabIndex = 5;
            this.cboxSifreGoster.Text = "Şifre Göster";
            this.cboxSifreGoster.UseVisualStyleBackColor = true;
            this.cboxSifreGoster.CheckedChanged += new System.EventHandler(this.cboxSifreGoster_CheckedChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(83, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 188);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboxSifreGoster);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblKulAd);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtKulAdi);
            this.Controls.Add(this.btnGiris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.GirisEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGiris;
        private TextBox txtKulAdi;
        private TextBox txtParola;
        private Label lblKulAd;
        private Label lblParola;
        private CheckBox cboxSifreGoster;
        private PictureBox pictureBox1;
    }
}