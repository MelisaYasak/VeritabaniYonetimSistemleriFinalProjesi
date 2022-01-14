namespace odevsena
{
    partial class OgrenciKayitEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciKayitEkrani));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_no = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pasword = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_bolum_ekle = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox_bolum = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(62, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı - Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(84, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parola:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(75, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kayıt Yılı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(84, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bölümü:";
            // 
            // txt_no
            // 
            this.txt_no.Enabled = false;
            this.txt_no.Location = new System.Drawing.Point(193, 7);
            this.txt_no.Name = "txt_no";
            this.txt_no.Size = new System.Drawing.Size(161, 23);
            this.txt_no.TabIndex = 5;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(193, 36);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(161, 23);
            this.txt_name.TabIndex = 6;
            // 
            // txt_pasword
            // 
            this.txt_pasword.Location = new System.Drawing.Point(193, 65);
            this.txt_pasword.Name = "txt_pasword";
            this.txt_pasword.Size = new System.Drawing.Size(161, 23);
            this.txt_pasword.TabIndex = 7;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(193, 108);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(161, 23);
            this.txt_date.TabIndex = 9;
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ekle.BackgroundImage")));
            this.btn_ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ekle.Location = new System.Drawing.Point(430, 7);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(49, 41);
            this.btn_ekle.TabIndex = 10;
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sil.BackgroundImage")));
            this.btn_sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sil.Location = new System.Drawing.Point(430, 56);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(49, 41);
            this.btn_sil.TabIndex = 11;
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_guncelle.BackgroundImage")));
            this.btn_guncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_guncelle.Location = new System.Drawing.Point(430, 101);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(49, 41);
            this.btn_guncelle.TabIndex = 12;
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_bolum_ekle
            // 
            this.btn_bolum_ekle.BackColor = System.Drawing.Color.Azure;
            this.btn_bolum_ekle.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_bolum_ekle.Location = new System.Drawing.Point(376, 134);
            this.btn_bolum_ekle.Name = "btn_bolum_ekle";
            this.btn_bolum_ekle.Size = new System.Drawing.Size(31, 24);
            this.btn_bolum_ekle.TabIndex = 13;
            this.btn_bolum_ekle.Text = "+";
            this.btn_bolum_ekle.UseVisualStyleBackColor = false;
            this.btn_bolum_ekle.Click += new System.EventHandler(this.btn_bolum_ekle_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Location = new System.Drawing.Point(720, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 41);
            this.button5.TabIndex = 14;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(27, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(756, 257);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // comboBox_bolum
            // 
            this.comboBox_bolum.FormattingEnabled = true;
            this.comboBox_bolum.Location = new System.Drawing.Point(193, 137);
            this.comboBox_bolum.Name = "comboBox_bolum";
            this.comboBox_bolum.Size = new System.Drawing.Size(161, 23);
            this.comboBox_bolum.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(193, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 12);
            this.label6.TabIndex = 34;
            this.label6.Text = "** Parola en fazla 10 karakter olmalıdır!";
            // 
            // OgrenciKayitEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_bolum);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_bolum_ekle);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_pasword);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_no);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OgrenciKayitEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Öğrenci Kayıt Ekranı";
            this.Load += new System.EventHandler(this.OgrenciKayitEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_no;
        private TextBox txt_name;
        private TextBox txt_pasword;
        private TextBox txt_date;
        private Button btn_ekle;
        private Button btn_sil;
        private Button btn_guncelle;
        private Button btn_bolum_ekle;
        private Button button5;
        private DataGridView dataGridView1;
        private ComboBox comboBox_bolum;
        private Label label6;
    }
}