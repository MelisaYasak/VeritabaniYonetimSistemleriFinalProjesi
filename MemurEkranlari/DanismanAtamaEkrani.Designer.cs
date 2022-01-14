namespace odevsena
{
    partial class DanismanAtamaEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanismanAtamaEkrani));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_bolum = new System.Windows.Forms.ComboBox();
            this.comboBox_tarih = new System.Windows.Forms.ComboBox();
            this.comboBox_hoca = new System.Windows.Forms.ComboBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(93, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bölüm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(94, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hoca Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(72, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giriş Tairihi";
            // 
            // comboBox_bolum
            // 
            this.comboBox_bolum.FormattingEnabled = true;
            this.comboBox_bolum.Location = new System.Drawing.Point(172, 45);
            this.comboBox_bolum.Name = "comboBox_bolum";
            this.comboBox_bolum.Size = new System.Drawing.Size(121, 23);
            this.comboBox_bolum.TabIndex = 3;
            this.comboBox_bolum.SelectedIndexChanged += new System.EventHandler(this.comboBox_bolum_SelectedIndexChanged);
            // 
            // comboBox_tarih
            // 
            this.comboBox_tarih.FormattingEnabled = true;
            this.comboBox_tarih.Location = new System.Drawing.Point(172, 146);
            this.comboBox_tarih.Name = "comboBox_tarih";
            this.comboBox_tarih.Size = new System.Drawing.Size(121, 23);
            this.comboBox_tarih.TabIndex = 4;
            // 
            // comboBox_hoca
            // 
            this.comboBox_hoca.FormattingEnabled = true;
            this.comboBox_hoca.Location = new System.Drawing.Point(172, 85);
            this.comboBox_hoca.Name = "comboBox_hoca";
            this.comboBox_hoca.Size = new System.Drawing.Size(121, 23);
            this.comboBox_hoca.TabIndex = 5;
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.Azure;
            this.btn_ekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ekle.BackgroundImage")));
            this.btn_ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ekle.Location = new System.Drawing.Point(351, 73);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(91, 70);
            this.btn_ekle.TabIndex = 6;
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(563, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 59);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DanismanAtamaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(671, 232);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.comboBox_hoca);
            this.Controls.Add(this.comboBox_tarih);
            this.Controls.Add(this.comboBox_bolum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DanismanAtamaEkrani";
            this.Text = "Danışman Atama Ekranı";
            this.Load += new System.EventHandler(this.DanismanAtamaEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox_bolum;
        private ComboBox comboBox_tarih;
        private ComboBox comboBox_hoca;
        private Button btn_ekle;
        private Button button1;
    }
}