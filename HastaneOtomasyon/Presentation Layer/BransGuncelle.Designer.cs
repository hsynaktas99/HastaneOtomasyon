namespace HastaneOtomasyon.Presentation_Layer
{
    partial class BransGuncelle
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
            this.dataGridView_mevcutBranslar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_bransGuncelle = new System.Windows.Forms.Button();
            this.textBox_bransAdi = new System.Windows.Forms.TextBox();
            this.textBox_bransId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_adet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mevcutBranslar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_mevcutBranslar
            // 
            this.dataGridView_mevcutBranslar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_mevcutBranslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_mevcutBranslar.Location = new System.Drawing.Point(12, 61);
            this.dataGridView_mevcutBranslar.Name = "dataGridView_mevcutBranslar";
            this.dataGridView_mevcutBranslar.RowTemplate.Height = 24;
            this.dataGridView_mevcutBranslar.Size = new System.Drawing.Size(1062, 303);
            this.dataGridView_mevcutBranslar.TabIndex = 8;
            this.dataGridView_mevcutBranslar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_mevcutBranslar_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(375, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 41);
            this.label1.TabIndex = 7;
            this.label1.Text = "BRANŞ GÜNCELLE";
            // 
            // button_bransGuncelle
            // 
            this.button_bransGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_bransGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_bransGuncelle.Location = new System.Drawing.Point(441, 494);
            this.button_bransGuncelle.Name = "button_bransGuncelle";
            this.button_bransGuncelle.Size = new System.Drawing.Size(202, 39);
            this.button_bransGuncelle.TabIndex = 2;
            this.button_bransGuncelle.Text = "GÜNCELLE";
            this.button_bransGuncelle.UseVisualStyleBackColor = false;
            this.button_bransGuncelle.Click += new System.EventHandler(this.button_bransGuncelle_Click);
            this.button_bransGuncelle.MouseLeave += new System.EventHandler(this.button_bransGuncelle_MouseLeave);
            this.button_bransGuncelle.MouseHover += new System.EventHandler(this.button_bransGuncelle_MouseHover);
            // 
            // textBox_bransAdi
            // 
            this.textBox_bransAdi.Location = new System.Drawing.Point(487, 436);
            this.textBox_bransAdi.Name = "textBox_bransAdi";
            this.textBox_bransAdi.Size = new System.Drawing.Size(287, 30);
            this.textBox_bransAdi.TabIndex = 1;
            // 
            // textBox_bransId
            // 
            this.textBox_bransId.Enabled = false;
            this.textBox_bransId.Location = new System.Drawing.Point(487, 387);
            this.textBox_bransId.Name = "textBox_bransId";
            this.textBox_bransId.Size = new System.Drawing.Size(100, 30);
            this.textBox_bransId.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Branş Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Branş ID:";
            // 
            // label_adet
            // 
            this.label_adet.AutoSize = true;
            this.label_adet.BackColor = System.Drawing.Color.White;
            this.label_adet.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_adet.ForeColor = System.Drawing.Color.Red;
            this.label_adet.Location = new System.Drawing.Point(36, 28);
            this.label_adet.Name = "label_adet";
            this.label_adet.Size = new System.Drawing.Size(47, 19);
            this.label_adet.TabIndex = 14;
            this.label_adet.Text = "label2";
            // 
            // BransGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1086, 545);
            this.Controls.Add(this.label_adet);
            this.Controls.Add(this.textBox_bransAdi);
            this.Controls.Add(this.textBox_bransId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_bransGuncelle);
            this.Controls.Add(this.dataGridView_mevcutBranslar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BransGuncelle";
            this.Text = "BransGuncelle";
            this.Load += new System.EventHandler(this.BransGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mevcutBranslar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_mevcutBranslar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_bransGuncelle;
        private System.Windows.Forms.TextBox textBox_bransAdi;
        private System.Windows.Forms.TextBox textBox_bransId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_adet;
    }
}