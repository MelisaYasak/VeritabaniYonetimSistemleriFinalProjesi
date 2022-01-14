namespace odevOgrenciOtomasyonu
{
    partial class OnayDers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnayDers));
            this.dgvOnayDers = new System.Windows.Forms.DataGridView();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOnayDers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOnayDers
            // 
            this.dgvOnayDers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOnayDers.BackgroundColor = System.Drawing.Color.White;
            this.dgvOnayDers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOnayDers.Location = new System.Drawing.Point(26, 116);
            this.dgvOnayDers.Name = "dgvOnayDers";
            this.dgvOnayDers.RowTemplate.Height = 25;
            this.dgvOnayDers.Size = new System.Drawing.Size(747, 322);
            this.dgvOnayDers.TabIndex = 0;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Azure;
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGeri.Location = new System.Drawing.Point(673, 31);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(68, 62);
            this.btnGeri.TabIndex = 14;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // OnayDers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.dgvOnayDers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OnayDers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Onaylanan Dersleri Görüntüleme Ekranı";
            this.Load += new System.EventHandler(this.OnayDers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOnayDers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvOnayDers;
        private Button btnGeri;
    }
}