namespace HastaneOtomasyon.Presentation_Layer
{
    partial class MevcutBranslar
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
            this.dataGridView_mevcutBranslar = new System.Windows.Forms.DataGridView();
            this.label_adet = new System.Windows.Forms.Label();
            this.button_bransAdinaGoreBuyuktenKucuge = new System.Windows.Forms.Button();
            this.button_bransAdiKucuktenBuyuge = new System.Windows.Forms.Button();
            this.textBox_arama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mevcutBranslar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(375, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "MEVCUT BRANŞLAR";
            // 
            // dataGridView_mevcutBranslar
            // 
            this.dataGridView_mevcutBranslar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_mevcutBranslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_mevcutBranslar.Location = new System.Drawing.Point(12, 83);
            this.dataGridView_mevcutBranslar.Name = "dataGridView_mevcutBranslar";
            this.dataGridView_mevcutBranslar.RowTemplate.Height = 24;
            this.dataGridView_mevcutBranslar.Size = new System.Drawing.Size(1062, 295);
            this.dataGridView_mevcutBranslar.TabIndex = 3;
            // 
            // label_adet
            // 
            this.label_adet.AutoSize = true;
            this.label_adet.BackColor = System.Drawing.Color.White;
            this.label_adet.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_adet.ForeColor = System.Drawing.Color.Red;
            this.label_adet.Location = new System.Drawing.Point(39, 52);
            this.label_adet.Name = "label_adet";
            this.label_adet.Size = new System.Drawing.Size(47, 19);
            this.label_adet.TabIndex = 8;
            this.label_adet.Text = "label2";
            // 
            // button_bransAdinaGoreBuyuktenKucuge
            // 
            this.button_bransAdinaGoreBuyuktenKucuge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_bransAdinaGoreBuyuktenKucuge.Location = new System.Drawing.Point(223, 468);
            this.button_bransAdinaGoreBuyuktenKucuge.Name = "button_bransAdinaGoreBuyuktenKucuge";
            this.button_bransAdinaGoreBuyuktenKucuge.Size = new System.Drawing.Size(277, 65);
            this.button_bransAdinaGoreBuyuktenKucuge.TabIndex = 11;
            this.button_bransAdinaGoreBuyuktenKucuge.Text = "Branş Adına Göre Büyükten Küçüğe Sırala";
            this.button_bransAdinaGoreBuyuktenKucuge.UseVisualStyleBackColor = false;
            this.button_bransAdinaGoreBuyuktenKucuge.Click += new System.EventHandler(this.button_bransAdinaGoreBuyuktenKucuge_Click);
            this.button_bransAdinaGoreBuyuktenKucuge.MouseLeave += new System.EventHandler(this.button_bransAdinaGoreBuyuktenKucuge_MouseLeave);
            this.button_bransAdinaGoreBuyuktenKucuge.MouseHover += new System.EventHandler(this.button_bransAdinaGoreBuyuktenKucuge_MouseHover);
            // 
            // button_bransAdiKucuktenBuyuge
            // 
            this.button_bransAdiKucuktenBuyuge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_bransAdiKucuktenBuyuge.Location = new System.Drawing.Point(223, 397);
            this.button_bransAdiKucuktenBuyuge.Name = "button_bransAdiKucuktenBuyuge";
            this.button_bransAdiKucuktenBuyuge.Size = new System.Drawing.Size(277, 65);
            this.button_bransAdiKucuktenBuyuge.TabIndex = 10;
            this.button_bransAdiKucuktenBuyuge.Text = "Branş Adına Göre Küçükten Büyüğe Sırala";
            this.button_bransAdiKucuktenBuyuge.UseVisualStyleBackColor = false;
            this.button_bransAdiKucuktenBuyuge.Click += new System.EventHandler(this.button_bransAdiKucuktenBuyuge_Click);
            this.button_bransAdiKucuktenBuyuge.MouseLeave += new System.EventHandler(this.button_bransAdiKucuktenBuyuge_MouseLeave);
            this.button_bransAdiKucuktenBuyuge.MouseHover += new System.EventHandler(this.button_bransAdiKucuktenBuyuge_MouseHover);
            // 
            // textBox_arama
            // 
            this.textBox_arama.Location = new System.Drawing.Point(558, 446);
            this.textBox_arama.Name = "textBox_arama";
            this.textBox_arama.Size = new System.Drawing.Size(351, 30);
            this.textBox_arama.TabIndex = 13;
            this.textBox_arama.TextChanged += new System.EventHandler(this.textBox_arama_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Branş Adına Göre Arama";
            // 
            // MevcutBranslar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1086, 545);
            this.Controls.Add(this.textBox_arama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_bransAdinaGoreBuyuktenKucuge);
            this.Controls.Add(this.button_bransAdiKucuktenBuyuge);
            this.Controls.Add(this.label_adet);
            this.Controls.Add(this.dataGridView_mevcutBranslar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MevcutBranslar";
            this.Text = "MevcutBranslar";
            this.Load += new System.EventHandler(this.MevcutBranslar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mevcutBranslar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_mevcutBranslar;
        private System.Windows.Forms.Label label_adet;
        private System.Windows.Forms.Button button_bransAdinaGoreBuyuktenKucuge;
        private System.Windows.Forms.Button button_bransAdiKucuktenBuyuge;
        private System.Windows.Forms.TextBox textBox_arama;
        private System.Windows.Forms.Label label3;
    }
}