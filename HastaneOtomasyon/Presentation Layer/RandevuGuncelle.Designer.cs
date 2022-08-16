namespace HastaneOtomasyon.Presentation_Layer
{
    partial class RandevuGuncelle
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
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_randevular = new System.Windows.Forms.DataGridView();
            this.button_randevuGuncelle = new System.Windows.Forms.Button();
            this.textBox_randevuId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_hastaAdi = new System.Windows.Forms.TextBox();
            this.textBox_hastaSoyadi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton_erkek = new System.Windows.Forms.RadioButton();
            this.radioButton_kadin = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_hastaYasi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_hastaBransi = new System.Windows.Forms.ComboBox();
            this.comboBox_hastaDoktoru = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker_randevuTarihi = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label_adet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_randevular)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(375, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 41);
            this.label3.TabIndex = 6;
            this.label3.Text = "RANDEVU GÜNCELLE";
            // 
            // dataGridView_randevular
            // 
            this.dataGridView_randevular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_randevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_randevular.Location = new System.Drawing.Point(12, 53);
            this.dataGridView_randevular.Name = "dataGridView_randevular";
            this.dataGridView_randevular.RowTemplate.Height = 24;
            this.dataGridView_randevular.Size = new System.Drawing.Size(1062, 252);
            this.dataGridView_randevular.TabIndex = 7;
            this.dataGridView_randevular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_randevular_CellClick);
            // 
            // button_randevuGuncelle
            // 
            this.button_randevuGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_randevuGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_randevuGuncelle.Location = new System.Drawing.Point(846, 408);
            this.button_randevuGuncelle.Name = "button_randevuGuncelle";
            this.button_randevuGuncelle.Size = new System.Drawing.Size(202, 55);
            this.button_randevuGuncelle.TabIndex = 8;
            this.button_randevuGuncelle.Text = "GÜNCELLE";
            this.button_randevuGuncelle.UseVisualStyleBackColor = false;
            this.button_randevuGuncelle.Click += new System.EventHandler(this.button_randevuGuncelle_Click);
            this.button_randevuGuncelle.MouseLeave += new System.EventHandler(this.button_randevuGuncelle_MouseLeave);
            this.button_randevuGuncelle.MouseHover += new System.EventHandler(this.button_randevuGuncelle_MouseHover);
            // 
            // textBox_randevuId
            // 
            this.textBox_randevuId.Enabled = false;
            this.textBox_randevuId.Location = new System.Drawing.Point(129, 329);
            this.textBox_randevuId.Name = "textBox_randevuId";
            this.textBox_randevuId.Size = new System.Drawing.Size(102, 30);
            this.textBox_randevuId.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Randevu ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hasta Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hasta Soyadı:";
            // 
            // textBox_hastaAdi
            // 
            this.textBox_hastaAdi.Location = new System.Drawing.Point(129, 375);
            this.textBox_hastaAdi.Name = "textBox_hastaAdi";
            this.textBox_hastaAdi.Size = new System.Drawing.Size(228, 30);
            this.textBox_hastaAdi.TabIndex = 0;
            // 
            // textBox_hastaSoyadi
            // 
            this.textBox_hastaSoyadi.Location = new System.Drawing.Point(129, 419);
            this.textBox_hastaSoyadi.Name = "textBox_hastaSoyadi";
            this.textBox_hastaSoyadi.Size = new System.Drawing.Size(228, 30);
            this.textBox_hastaSoyadi.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 473);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Hasta Cinsiyeti:";
            // 
            // radioButton_erkek
            // 
            this.radioButton_erkek.AutoSize = true;
            this.radioButton_erkek.Location = new System.Drawing.Point(146, 471);
            this.radioButton_erkek.Name = "radioButton_erkek";
            this.radioButton_erkek.Size = new System.Drawing.Size(71, 27);
            this.radioButton_erkek.TabIndex = 2;
            this.radioButton_erkek.TabStop = true;
            this.radioButton_erkek.Text = "Erkek";
            this.radioButton_erkek.UseVisualStyleBackColor = true;
            // 
            // radioButton_kadin
            // 
            this.radioButton_kadin.AutoSize = true;
            this.radioButton_kadin.Location = new System.Drawing.Point(223, 471);
            this.radioButton_kadin.Name = "radioButton_kadin";
            this.radioButton_kadin.Size = new System.Drawing.Size(74, 27);
            this.radioButton_kadin.TabIndex = 3;
            this.radioButton_kadin.TabStop = true;
            this.radioButton_kadin.Text = "Kadın";
            this.radioButton_kadin.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "Hasta Yaşı:";
            // 
            // textBox_hastaYasi
            // 
            this.textBox_hastaYasi.Location = new System.Drawing.Point(496, 332);
            this.textBox_hastaYasi.Name = "textBox_hastaYasi";
            this.textBox_hastaYasi.Size = new System.Drawing.Size(56, 30);
            this.textBox_hastaYasi.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(382, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Hasta Branşı:";
            // 
            // comboBox_hastaBransi
            // 
            this.comboBox_hastaBransi.FormattingEnabled = true;
            this.comboBox_hastaBransi.Location = new System.Drawing.Point(496, 376);
            this.comboBox_hastaBransi.Name = "comboBox_hastaBransi";
            this.comboBox_hastaBransi.Size = new System.Drawing.Size(258, 31);
            this.comboBox_hastaBransi.TabIndex = 5;
            this.comboBox_hastaBransi.SelectedIndexChanged += new System.EventHandler(this.comboBox_hastaBransi_SelectedIndexChanged);
            // 
            // comboBox_hastaDoktoru
            // 
            this.comboBox_hastaDoktoru.FormattingEnabled = true;
            this.comboBox_hastaDoktoru.Location = new System.Drawing.Point(496, 423);
            this.comboBox_hastaDoktoru.Name = "comboBox_hastaDoktoru";
            this.comboBox_hastaDoktoru.Size = new System.Drawing.Size(258, 31);
            this.comboBox_hastaDoktoru.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(366, 426);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 23);
            this.label10.TabIndex = 25;
            this.label10.Text = "Hasta Doktoru:";
            // 
            // dateTimePicker_randevuTarihi
            // 
            this.dateTimePicker_randevuTarihi.CustomFormat = "dd/MM/yyyy     HH:mm:ss";
            this.dateTimePicker_randevuTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_randevuTarihi.Location = new System.Drawing.Point(496, 470);
            this.dateTimePicker_randevuTarihi.Name = "dateTimePicker_randevuTarihi";
            this.dateTimePicker_randevuTarihi.Size = new System.Drawing.Size(320, 30);
            this.dateTimePicker_randevuTarihi.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(365, 473);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 23);
            this.label11.TabIndex = 27;
            this.label11.Text = "Randevu Tarihi:";
            // 
            // label_adet
            // 
            this.label_adet.AutoSize = true;
            this.label_adet.BackColor = System.Drawing.Color.White;
            this.label_adet.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_adet.ForeColor = System.Drawing.Color.Red;
            this.label_adet.Location = new System.Drawing.Point(38, 28);
            this.label_adet.Name = "label_adet";
            this.label_adet.Size = new System.Drawing.Size(47, 19);
            this.label_adet.TabIndex = 28;
            this.label_adet.Text = "label2";
            // 
            // RandevuGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1086, 545);
            this.Controls.Add(this.label_adet);
            this.Controls.Add(this.dateTimePicker_randevuTarihi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox_hastaDoktoru);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox_hastaBransi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_hastaYasi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radioButton_kadin);
            this.Controls.Add(this.radioButton_erkek);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_hastaSoyadi);
            this.Controls.Add(this.textBox_hastaAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_randevuId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_randevuGuncelle);
            this.Controls.Add(this.dataGridView_randevular);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RandevuGuncelle";
            this.Text = "RandevuGuncelle";
            this.Load += new System.EventHandler(this.RandevuGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_randevular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_randevular;
        private System.Windows.Forms.Button button_randevuGuncelle;
        private System.Windows.Forms.TextBox textBox_randevuId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_hastaAdi;
        private System.Windows.Forms.TextBox textBox_hastaSoyadi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton_erkek;
        private System.Windows.Forms.RadioButton radioButton_kadin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_hastaYasi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_hastaBransi;
        private System.Windows.Forms.ComboBox comboBox_hastaDoktoru;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker_randevuTarihi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_adet;
    }
}