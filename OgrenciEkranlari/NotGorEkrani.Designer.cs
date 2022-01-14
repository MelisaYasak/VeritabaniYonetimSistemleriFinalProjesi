namespace odevOgrenciOtomasyonu
{
    partial class NotGorEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotGorEkrani));
            this.btnGeri = new System.Windows.Forms.Button();
            this.dgwNotGorEkran = new System.Windows.Forms.DataGridView();
            this.cbYil = new System.Windows.Forms.ComboBox();
            this.lblyil = new System.Windows.Forms.Label();
            this.cbyariyil = new System.Windows.Forms.ComboBox();
            this.lblyariyil = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNotGorEkran)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Azure;
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGeri.Location = new System.Drawing.Point(675, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(72, 54);
            this.btnGeri.TabIndex = 0;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // dgwNotGorEkran
            // 
            this.dgwNotGorEkran.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwNotGorEkran.BackgroundColor = System.Drawing.Color.White;
            this.dgwNotGorEkran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwNotGorEkran.Location = new System.Drawing.Point(25, 160);
            this.dgwNotGorEkran.Name = "dgwNotGorEkran";
            this.dgwNotGorEkran.RowTemplate.Height = 25;
            this.dgwNotGorEkran.Size = new System.Drawing.Size(750, 265);
            this.dgwNotGorEkran.TabIndex = 1;
            // 
            // cbYil
            // 
            this.cbYil.FormattingEnabled = true;
            this.cbYil.Location = new System.Drawing.Point(96, 107);
            this.cbYil.Name = "cbYil";
            this.cbYil.Size = new System.Drawing.Size(121, 23);
            this.cbYil.TabIndex = 2;
            this.cbYil.SelectedIndexChanged += new System.EventHandler(this.cbYil_SelectedIndexChanged);
            // 
            // lblyil
            // 
            this.lblyil.AutoSize = true;
            this.lblyil.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblyil.Location = new System.Drawing.Point(47, 109);
            this.lblyil.Name = "lblyil";
            this.lblyil.Size = new System.Drawing.Size(24, 16);
            this.lblyil.TabIndex = 3;
            this.lblyil.Text = "Yıl";
            // 
            // cbyariyil
            // 
            this.cbyariyil.FormattingEnabled = true;
            this.cbyariyil.Location = new System.Drawing.Point(354, 112);
            this.cbyariyil.Name = "cbyariyil";
            this.cbyariyil.Size = new System.Drawing.Size(121, 23);
            this.cbyariyil.TabIndex = 4;
            this.cbyariyil.SelectedIndexChanged += new System.EventHandler(this.cbyariyil_SelectedIndexChanged);
            // 
            // lblyariyil
            // 
            this.lblyariyil.AutoSize = true;
            this.lblyariyil.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblyariyil.Location = new System.Drawing.Point(260, 114);
            this.lblyariyil.Name = "lblyariyil";
            this.lblyariyil.Size = new System.Drawing.Size(48, 16);
            this.lblyariyil.TabIndex = 5;
            this.lblyariyil.Text = "Yarıyıl";
            // 
            // NotGorEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblyariyil);
            this.Controls.Add(this.cbyariyil);
            this.Controls.Add(this.lblyil);
            this.Controls.Add(this.cbYil);
            this.Controls.Add(this.dgwNotGorEkran);
            this.Controls.Add(this.btnGeri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NotGorEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Not Görüntüleme Ekranı";
            this.Load += new System.EventHandler(this.NotGorEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwNotGorEkran)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGeri;
        private DataGridView dgwNotGorEkran;
        private ComboBox cbYil;
        private Label lblyil;
        private ComboBox cbyariyil;
        private Label lblyariyil;
    }
}