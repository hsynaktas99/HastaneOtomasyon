namespace HastaneOtomasyon.Presentation_Layer
{
    partial class MevcutDoktorlar
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_mevcutDoktorlar = new System.Windows.Forms.DataGridView();
            this.label_adet = new System.Windows.Forms.Label();
            this.textBox_arama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_doktorAdinaGoreBuyuktenKucuge = new System.Windows.Forms.Button();
            this.button_doktorAdiKucuktenBuyuge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mevcutDoktorlar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(375, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "MEVCUT DOKTORLAR";
            // 
            // dataGridView_mevcutDoktorlar
            // 
            this.dataGridView_mevcutDoktorlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_mevcutDoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_mevcutDoktorlar.Location = new System.Drawing.Point(13, 58);
            this.dataGridView_mevcutDoktorlar.Name = "dataGridView_mevcutDoktorlar";
            this.dataGridView_mevcutDoktorlar.RowTemplate.Height = 24;
            this.dataGridView_mevcutDoktorlar.Size = new System.Drawing.Size(1062, 299);
            this.dataGridView_mevcutDoktorlar.TabIndex = 2;
            // 
            // label_adet
            // 
            this.label_adet.AutoSize = true;
            this.label_adet.BackColor = System.Drawing.Color.White;
            this.label_adet.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_adet.ForeColor = System.Drawing.Color.Red;
            this.label_adet.Location = new System.Drawing.Point(25, 28);
            this.label_adet.Name = "label_adet";
            this.label_adet.Size = new System.Drawing.Size(47, 19);
            this.label_adet.TabIndex = 8;
            this.label_adet.Text = "label2";
            // 
            // textBox_arama
            // 
            this.textBox_arama.Location = new System.Drawing.Point(532, 428);
            this.textBox_arama.Name = "textBox_arama";
            this.textBox_arama.Size = new System.Drawing.Size(351, 30);
            this.textBox_arama.TabIndex = 17;
            this.textBox_arama.TextChanged += new System.EventHandler(this.textBox_arama_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(566, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Doktor Adına Göre Arama";
            // 
            // button_doktorAdinaGoreBuyuktenKucuge
            // 
            this.button_doktorAdinaGoreBuyuktenKucuge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_doktorAdinaGoreBuyuktenKucuge.Location = new System.Drawing.Point(197, 450);
            this.button_doktorAdinaGoreBuyuktenKucuge.Name = "button_doktorAdinaGoreBuyuktenKucuge";
            this.button_doktorAdinaGoreBuyuktenKucuge.Size = new System.Drawing.Size(277, 65);
            this.button_doktorAdinaGoreBuyuktenKucuge.TabIndex = 15;
            this.button_doktorAdinaGoreBuyuktenKucuge.Text = "Doktor Adına Göre Büyükten Küçüğe Sırala";
            this.button_doktorAdinaGoreBuyuktenKucuge.UseVisualStyleBackColor = false;
            this.button_doktorAdinaGoreBuyuktenKucuge.Click += new System.EventHandler(this.button_doktorAdinaGoreBuyuktenKucuge_Click);
            this.button_doktorAdinaGoreBuyuktenKucuge.MouseLeave += new System.EventHandler(this.button_doktorAdinaGoreBuyuktenKucuge_MouseLeave);
            this.button_doktorAdinaGoreBuyuktenKucuge.MouseHover += new System.EventHandler(this.button_doktorAdinaGoreBuyuktenKucuge_MouseHover);
            // 
            // button_doktorAdiKucuktenBuyuge
            // 
            this.button_doktorAdiKucuktenBuyuge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_doktorAdiKucuktenBuyuge.Location = new System.Drawing.Point(197, 379);
            this.button_doktorAdiKucuktenBuyuge.Name = "button_doktorAdiKucuktenBuyuge";
            this.button_doktorAdiKucuktenBuyuge.Size = new System.Drawing.Size(277, 65);
            this.button_doktorAdiKucuktenBuyuge.TabIndex = 14;
            this.button_doktorAdiKucuktenBuyuge.Text = "Doktor Adına Göre Küçükten Büyüğe Sırala";
            this.button_doktorAdiKucuktenBuyuge.UseVisualStyleBackColor = false;
            this.button_doktorAdiKucuktenBuyuge.Click += new System.EventHandler(this.button_doktorAdiKucuktenBuyuge_Click);
            this.button_doktorAdiKucuktenBuyuge.MouseLeave += new System.EventHandler(this.button_doktorAdiKucuktenBuyuge_MouseLeave);
            this.button_doktorAdiKucuktenBuyuge.MouseHover += new System.EventHandler(this.button_doktorAdiKucuktenBuyuge_MouseHover);
            // 
            // MevcutDoktorlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1086, 545);
            this.Controls.Add(this.textBox_arama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_doktorAdinaGoreBuyuktenKucuge);
            this.Controls.Add(this.button_doktorAdiKucuktenBuyuge);
            this.Controls.Add(this.label_adet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_mevcutDoktorlar);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MevcutDoktorlar";
            this.Text = "MevcutDoktorlar";
            this.Load += new System.EventHandler(this.MevcutDoktorlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mevcutDoktorlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_mevcutDoktorlar;
        private System.Windows.Forms.Label label_adet;
        private System.Windows.Forms.TextBox textBox_arama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_doktorAdinaGoreBuyuktenKucuge;
        private System.Windows.Forms.Button button_doktorAdiKucuktenBuyuge;
    }
}