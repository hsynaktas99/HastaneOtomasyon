namespace HastaneOtomasyon.Presentation_Layer
{
    partial class MevcutRandevular
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
            this.dataGridView_mevcutRandevular = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_randevuTarihiKucuktenBuyuge = new System.Windows.Forms.Button();
            this.button_randevuTarihiBuyuktenKucuge = new System.Windows.Forms.Button();
            this.button_hastaAdinaGoreBuyuktenKucuge = new System.Windows.Forms.Button();
            this.button_hastaAdiKucuktenBuyuge = new System.Windows.Forms.Button();
            this.label_adet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_arama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mevcutRandevular)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_mevcutRandevular
            // 
            this.dataGridView_mevcutRandevular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_mevcutRandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_mevcutRandevular.Location = new System.Drawing.Point(12, 58);
            this.dataGridView_mevcutRandevular.Name = "dataGridView_mevcutRandevular";
            this.dataGridView_mevcutRandevular.RowTemplate.Height = 24;
            this.dataGridView_mevcutRandevular.Size = new System.Drawing.Size(1062, 327);
            this.dataGridView_mevcutRandevular.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(375, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "MEVCUT RANDEVULAR";
            // 
            // button_randevuTarihiKucuktenBuyuge
            // 
            this.button_randevuTarihiKucuktenBuyuge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_randevuTarihiKucuktenBuyuge.Location = new System.Drawing.Point(37, 401);
            this.button_randevuTarihiKucuktenBuyuge.Name = "button_randevuTarihiKucuktenBuyuge";
            this.button_randevuTarihiKucuktenBuyuge.Size = new System.Drawing.Size(277, 65);
            this.button_randevuTarihiKucuktenBuyuge.TabIndex = 1;
            this.button_randevuTarihiKucuktenBuyuge.Text = "Randevu Tarihine Göre Küçükten Büyüğe Sırala";
            this.button_randevuTarihiKucuktenBuyuge.UseVisualStyleBackColor = false;
            this.button_randevuTarihiKucuktenBuyuge.Click += new System.EventHandler(this.button_randevuTarihiKucuktenBuyuge_Click);
            this.button_randevuTarihiKucuktenBuyuge.MouseLeave += new System.EventHandler(this.button_randevuTarihiKucuktenBuyuge_MouseLeave);
            this.button_randevuTarihiKucuktenBuyuge.MouseHover += new System.EventHandler(this.button_randevuTarihiKucuktenBuyuge_MouseHover);
            // 
            // button_randevuTarihiBuyuktenKucuge
            // 
            this.button_randevuTarihiBuyuktenKucuge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_randevuTarihiBuyuktenKucuge.Location = new System.Drawing.Point(37, 472);
            this.button_randevuTarihiBuyuktenKucuge.Name = "button_randevuTarihiBuyuktenKucuge";
            this.button_randevuTarihiBuyuktenKucuge.Size = new System.Drawing.Size(277, 65);
            this.button_randevuTarihiBuyuktenKucuge.TabIndex = 3;
            this.button_randevuTarihiBuyuktenKucuge.Text = "Randevu Tarihine Göre Büyükten Küçüğe Sırala";
            this.button_randevuTarihiBuyuktenKucuge.UseVisualStyleBackColor = false;
            this.button_randevuTarihiBuyuktenKucuge.Click += new System.EventHandler(this.button_randevuTarihiBuyuktenKucuge_Click);
            this.button_randevuTarihiBuyuktenKucuge.MouseLeave += new System.EventHandler(this.button_randevuTarihiBuyuktenKucuge_MouseLeave);
            this.button_randevuTarihiBuyuktenKucuge.MouseHover += new System.EventHandler(this.button_randevuTarihiBuyuktenKucuge_MouseHover);
            // 
            // button_hastaAdinaGoreBuyuktenKucuge
            // 
            this.button_hastaAdinaGoreBuyuktenKucuge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_hastaAdinaGoreBuyuktenKucuge.Location = new System.Drawing.Point(335, 472);
            this.button_hastaAdinaGoreBuyuktenKucuge.Name = "button_hastaAdinaGoreBuyuktenKucuge";
            this.button_hastaAdinaGoreBuyuktenKucuge.Size = new System.Drawing.Size(277, 65);
            this.button_hastaAdinaGoreBuyuktenKucuge.TabIndex = 5;
            this.button_hastaAdinaGoreBuyuktenKucuge.Text = "Hasta Adına Göre Büyükten Küçüğe Sırala";
            this.button_hastaAdinaGoreBuyuktenKucuge.UseVisualStyleBackColor = false;
            this.button_hastaAdinaGoreBuyuktenKucuge.Click += new System.EventHandler(this.button_hastaAdinaGoreBuyuktenKucuge_Click);
            this.button_hastaAdinaGoreBuyuktenKucuge.MouseLeave += new System.EventHandler(this.button_hastaAdinaGoreBuyuktenKucuge_MouseLeave);
            this.button_hastaAdinaGoreBuyuktenKucuge.MouseHover += new System.EventHandler(this.button_hastaAdinaGoreBuyuktenKucuge_MouseHover);
            // 
            // button_hastaAdiKucuktenBuyuge
            // 
            this.button_hastaAdiKucuktenBuyuge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_hastaAdiKucuktenBuyuge.Location = new System.Drawing.Point(335, 401);
            this.button_hastaAdiKucuktenBuyuge.Name = "button_hastaAdiKucuktenBuyuge";
            this.button_hastaAdiKucuktenBuyuge.Size = new System.Drawing.Size(277, 65);
            this.button_hastaAdiKucuktenBuyuge.TabIndex = 4;
            this.button_hastaAdiKucuktenBuyuge.Text = "Hasta Adına Göre Küçükten Büyüğe Sırala";
            this.button_hastaAdiKucuktenBuyuge.UseVisualStyleBackColor = false;
            this.button_hastaAdiKucuktenBuyuge.Click += new System.EventHandler(this.button_hastaAdiKucuktenBuyuge_Click);
            this.button_hastaAdiKucuktenBuyuge.MouseLeave += new System.EventHandler(this.button_hastaAdiKucuktenBuyuge_MouseLeave);
            this.button_hastaAdiKucuktenBuyuge.MouseHover += new System.EventHandler(this.button_hastaAdiKucuktenBuyuge_MouseHover);
            // 
            // label_adet
            // 
            this.label_adet.AutoSize = true;
            this.label_adet.BackColor = System.Drawing.Color.White;
            this.label_adet.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_adet.ForeColor = System.Drawing.Color.Red;
            this.label_adet.Location = new System.Drawing.Point(20, 28);
            this.label_adet.Name = "label_adet";
            this.label_adet.Size = new System.Drawing.Size(47, 19);
            this.label_adet.TabIndex = 6;
            this.label_adet.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(717, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hasta Adına Göre Arama";
            // 
            // textBox_arama
            // 
            this.textBox_arama.Location = new System.Drawing.Point(683, 448);
            this.textBox_arama.Name = "textBox_arama";
            this.textBox_arama.Size = new System.Drawing.Size(351, 30);
            this.textBox_arama.TabIndex = 9;
            this.textBox_arama.TextChanged += new System.EventHandler(this.textBox_arama_TextChanged);
            // 
            // MevcutRandevular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1086, 545);
            this.Controls.Add(this.textBox_arama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_adet);
            this.Controls.Add(this.button_hastaAdinaGoreBuyuktenKucuge);
            this.Controls.Add(this.button_hastaAdiKucuktenBuyuge);
            this.Controls.Add(this.button_randevuTarihiBuyuktenKucuge);
            this.Controls.Add(this.button_randevuTarihiKucuktenBuyuge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_mevcutRandevular);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MevcutRandevular";
            this.Text = "MevcutRandevular";
            this.Load += new System.EventHandler(this.MevcutRandevular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mevcutRandevular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_mevcutRandevular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_randevuTarihiKucuktenBuyuge;
        private System.Windows.Forms.Button button_randevuTarihiBuyuktenKucuge;
        private System.Windows.Forms.Button button_hastaAdinaGoreBuyuktenKucuge;
        private System.Windows.Forms.Button button_hastaAdiKucuktenBuyuge;
        private System.Windows.Forms.Label label_adet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_arama;
    }
}