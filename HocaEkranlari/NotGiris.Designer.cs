namespace odev
{
    partial class NotGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotGiris));
            this.listele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ogrenci_listele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.geri_don = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listele
            // 
            this.listele.BackColor = System.Drawing.Color.Azure;
            this.listele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listele.BackgroundImage")));
            this.listele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.listele.Location = new System.Drawing.Point(266, 31);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(76, 70);
            this.listele.TabIndex = 1;
            this.listele.UseVisualStyleBackColor = false;
            this.listele.Click += new System.EventHandler(this.listele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "YIL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "YARIYIL:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // ogrenci_listele
            // 
            this.ogrenci_listele.BackColor = System.Drawing.Color.Azure;
            this.ogrenci_listele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ogrenci_listele.BackgroundImage")));
            this.ogrenci_listele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ogrenci_listele.Location = new System.Drawing.Point(761, 487);
            this.ogrenci_listele.Name = "ogrenci_listele";
            this.ogrenci_listele.Size = new System.Drawing.Size(102, 90);
            this.ogrenci_listele.TabIndex = 7;
            this.ogrenci_listele.UseVisualStyleBackColor = false;
            this.ogrenci_listele.Click += new System.EventHandler(this.ogrenci_listele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(851, 337);
            this.dataGridView1.TabIndex = 8;
            // 
            // geri_don
            // 
            this.geri_don.BackColor = System.Drawing.Color.Azure;
            this.geri_don.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("geri_don.BackgroundImage")));
            this.geri_don.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.geri_don.Location = new System.Drawing.Point(781, 8);
            this.geri_don.Name = "geri_don";
            this.geri_don.Size = new System.Drawing.Size(82, 73);
            this.geri_don.TabIndex = 9;
            this.geri_don.UseVisualStyleBackColor = false;
            this.geri_don.Click += new System.EventHandler(this.geri_don_Click);
            // 
            // NotGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(875, 589);
            this.Controls.Add(this.geri_don);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ogrenci_listele);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listele);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NotGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DERS SEÇİM";
            this.Load += new System.EventHandler(this.notGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ogrenci_listele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button geri_don;
    }
}