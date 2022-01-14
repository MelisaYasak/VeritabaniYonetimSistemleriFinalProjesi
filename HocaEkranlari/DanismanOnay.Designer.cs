namespace odev
{
    partial class DanismanOnay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanismanOnay));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dersleri_listele = new System.Windows.Forms.Button();
            this.geri_don = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(774, 351);
            this.dataGridView1.TabIndex = 0;
            // 
            // dersleri_listele
            // 
            this.dersleri_listele.BackColor = System.Drawing.Color.Azure;
            this.dersleri_listele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dersleri_listele.BackgroundImage")));
            this.dersleri_listele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dersleri_listele.Location = new System.Drawing.Point(700, 455);
            this.dersleri_listele.Name = "dersleri_listele";
            this.dersleri_listele.Size = new System.Drawing.Size(85, 78);
            this.dersleri_listele.TabIndex = 1;
            this.dersleri_listele.UseVisualStyleBackColor = false;
            this.dersleri_listele.Click += new System.EventHandler(this.dersleri_listele_Click);
            // 
            // geri_don
            // 
            this.geri_don.BackColor = System.Drawing.Color.Azure;
            this.geri_don.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("geri_don.BackgroundImage")));
            this.geri_don.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.geri_don.Location = new System.Drawing.Point(708, 13);
            this.geri_don.Name = "geri_don";
            this.geri_don.Size = new System.Drawing.Size(77, 69);
            this.geri_don.TabIndex = 2;
            this.geri_don.UseVisualStyleBackColor = false;
            this.geri_don.Click += new System.EventHandler(this.geri_don_Click);
            // 
            // DanismanOnay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(795, 544);
            this.Controls.Add(this.geri_don);
            this.Controls.Add(this.dersleri_listele);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DanismanOnay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANIŞMAN ONAY";
            this.Load += new System.EventHandler(this.danismanOnay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dersleri_listele;
        private System.Windows.Forms.Button geri_don;
    }
}