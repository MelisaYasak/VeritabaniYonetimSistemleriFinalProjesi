namespace odev
{
    partial class Onayla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Onayla));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_onayla = new System.Windows.Forms.Button();
            this.geri_don = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(885, 374);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_onayla
            // 
            this.btn_onayla.BackColor = System.Drawing.Color.Azure;
            this.btn_onayla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_onayla.BackgroundImage")));
            this.btn_onayla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_onayla.Location = new System.Drawing.Point(804, 508);
            this.btn_onayla.Name = "btn_onayla";
            this.btn_onayla.Size = new System.Drawing.Size(93, 69);
            this.btn_onayla.TabIndex = 1;
            this.btn_onayla.UseVisualStyleBackColor = false;
            this.btn_onayla.Click += new System.EventHandler(this.btn_onayla_Click);
            // 
            // geri_don
            // 
            this.geri_don.BackColor = System.Drawing.Color.Azure;
            this.geri_don.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("geri_don.BackgroundImage")));
            this.geri_don.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.geri_don.Location = new System.Drawing.Point(804, 21);
            this.geri_don.Name = "geri_don";
            this.geri_don.Size = new System.Drawing.Size(86, 71);
            this.geri_don.TabIndex = 2;
            this.geri_don.UseVisualStyleBackColor = false;
            this.geri_don.Click += new System.EventHandler(this.geri_don_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Onayla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(909, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.geri_don);
            this.Controls.Add(this.btn_onayla);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Onayla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ONAY";
            this.Load += new System.EventHandler(this.onayla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_onayla;
        private System.Windows.Forms.Button geri_don;
        private System.Windows.Forms.Label label1;
    }
}