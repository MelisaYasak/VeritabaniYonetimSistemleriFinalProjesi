namespace odevsena
{
    partial class YeniBolumHocaEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniBolumHocaEkrani));
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.txt_bolum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.White;
            this.btn_kaydet.Location = new System.Drawing.Point(115, 102);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(163, 48);
            this.btn_kaydet.TabIndex = 3;
            this.btn_kaydet.Text = "EKLE";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // txt_bolum
            // 
            this.txt_bolum.Location = new System.Drawing.Point(90, 62);
            this.txt_bolum.Name = "txt_bolum";
            this.txt_bolum.Size = new System.Drawing.Size(222, 23);
            this.txt_bolum.TabIndex = 2;
            // 
            // YeniBolumHocaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(455, 222);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_bolum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YeniBolumHocaEkrani";
            this.Text = "Hoca / Yeni Bölüm Ekleme Ekramı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_kaydet;
        private TextBox txt_bolum;
    }
}