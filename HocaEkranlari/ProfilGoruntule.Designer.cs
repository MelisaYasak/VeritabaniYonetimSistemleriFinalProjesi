namespace odev
{
    partial class ProfilGoruntule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilGoruntule));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listele = new System.Windows.Forms.Button();
            this.profil_goruntule = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.geri_don = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÖĞRENCİ NO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "AD-SOYAD:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 23);
            this.textBox2.TabIndex = 3;
            // 
            // listele
            // 
            this.listele.BackColor = System.Drawing.Color.Azure;
            this.listele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listele.BackgroundImage")));
            this.listele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.listele.Location = new System.Drawing.Point(254, 38);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(72, 57);
            this.listele.TabIndex = 4;
            this.listele.UseVisualStyleBackColor = false;
            this.listele.Click += new System.EventHandler(this.listele_Click);
            // 
            // profil_goruntule
            // 
            this.profil_goruntule.BackColor = System.Drawing.Color.Azure;
            this.profil_goruntule.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profil_goruntule.BackgroundImage")));
            this.profil_goruntule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.profil_goruntule.Location = new System.Drawing.Point(699, 473);
            this.profil_goruntule.Name = "profil_goruntule";
            this.profil_goruntule.Size = new System.Drawing.Size(74, 71);
            this.profil_goruntule.TabIndex = 6;
            this.profil_goruntule.UseVisualStyleBackColor = false;
            this.profil_goruntule.Click += new System.EventHandler(this.profil_goruntule_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(762, 312);
            this.dataGridView1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 23);
            this.textBox1.TabIndex = 8;
            // 
            // geri_don
            // 
            this.geri_don.BackColor = System.Drawing.Color.Azure;
            this.geri_don.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("geri_don.BackgroundImage")));
            this.geri_don.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.geri_don.Location = new System.Drawing.Point(699, 11);
            this.geri_don.Name = "geri_don";
            this.geri_don.Size = new System.Drawing.Size(74, 64);
            this.geri_don.TabIndex = 9;
            this.geri_don.UseVisualStyleBackColor = false;
            this.geri_don.Click += new System.EventHandler(this.geri_don_Click);
            // 
            // ProfilGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(783, 556);
            this.Controls.Add(this.geri_don);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.profil_goruntule);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProfilGoruntule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ÖĞRENCİ PROFİLİ GÖRÜNTÜLE";
            this.Load += new System.EventHandler(this.profilGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.Button profil_goruntule;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button geri_don;
    }
}