namespace HastaneOtomasyon.Presentation_Layer
{
    partial class DoktorGuncelle
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_doktorId = new System.Windows.Forms.TextBox();
            this.textBox_doktorAdSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton_erkek = new System.Windows.Forms.RadioButton();
            this.radioButton_kadin = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_brans = new System.Windows.Forms.ComboBox();
            this.button_doktorGuncelle = new System.Windows.Forms.Button();
            this.label_adet = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(293, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "DOKTOR GÜNCELLE";
            // 
            // dataGridView_mevcutDoktorlar
            // 
            this.dataGridView_mevcutDoktorlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_mevcutDoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_mevcutDoktorlar.Location = new System.Drawing.Point(12, 63);
            this.dataGridView_mevcutDoktorlar.Name = "dataGridView_mevcutDoktorlar";
            this.dataGridView_mevcutDoktorlar.RowTemplate.Height = 24;
            this.dataGridView_mevcutDoktorlar.Size = new System.Drawing.Size(1062, 303);
            this.dataGridView_mevcutDoktorlar.TabIndex = 6;
            this.dataGridView_mevcutDoktorlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_mevcutDoktorlar_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Doktor ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Doktor Adı ve Soyadı:";
            // 
            // textBox_doktorId
            // 
            this.textBox_doktorId.Enabled = false;
            this.textBox_doktorId.Location = new System.Drawing.Point(248, 393);
            this.textBox_doktorId.Name = "textBox_doktorId";
            this.textBox_doktorId.Size = new System.Drawing.Size(100, 30);
            this.textBox_doktorId.TabIndex = 0;
            // 
            // textBox_doktorAdSoyad
            // 
            this.textBox_doktorAdSoyad.Location = new System.Drawing.Point(248, 442);
            this.textBox_doktorAdSoyad.Name = "textBox_doktorAdSoyad";
            this.textBox_doktorAdSoyad.Size = new System.Drawing.Size(287, 30);
            this.textBox_doktorAdSoyad.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Doktor Cinsiyeti:";
            // 
            // radioButton_erkek
            // 
            this.radioButton_erkek.AutoSize = true;
            this.radioButton_erkek.Location = new System.Drawing.Point(696, 394);
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
            this.radioButton_kadin.Location = new System.Drawing.Point(774, 392);
            this.radioButton_kadin.Name = "radioButton_kadin";
            this.radioButton_kadin.Size = new System.Drawing.Size(74, 27);
            this.radioButton_kadin.TabIndex = 3;
            this.radioButton_kadin.TabStop = true;
            this.radioButton_kadin.Text = "Kadın";
            this.radioButton_kadin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(573, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Doktor Branşı:";
            // 
            // comboBox_brans
            // 
            this.comboBox_brans.FormattingEnabled = true;
            this.comboBox_brans.Location = new System.Drawing.Point(696, 442);
            this.comboBox_brans.Name = "comboBox_brans";
            this.comboBox_brans.Size = new System.Drawing.Size(320, 31);
            this.comboBox_brans.TabIndex = 4;
            // 
            // button_doktorGuncelle
            // 
            this.button_doktorGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_doktorGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_doktorGuncelle.Location = new System.Drawing.Point(466, 494);
            this.button_doktorGuncelle.Name = "button_doktorGuncelle";
            this.button_doktorGuncelle.Size = new System.Drawing.Size(202, 39);
            this.button_doktorGuncelle.TabIndex = 5;
            this.button_doktorGuncelle.Text = "GÜNCELLE";
            this.button_doktorGuncelle.UseVisualStyleBackColor = false;
            this.button_doktorGuncelle.Click += new System.EventHandler(this.button_doktorGuncelle_Click);
            this.button_doktorGuncelle.MouseLeave += new System.EventHandler(this.button_doktorGuncelle_MouseLeave);
            this.button_doktorGuncelle.MouseHover += new System.EventHandler(this.button_doktorGuncelle_MouseHover);
            // 
            // label_adet
            // 
            this.label_adet.AutoSize = true;
            this.label_adet.BackColor = System.Drawing.Color.White;
            this.label_adet.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_adet.ForeColor = System.Drawing.Color.Red;
            this.label_adet.Location = new System.Drawing.Point(28, 28);
            this.label_adet.Name = "label_adet";
            this.label_adet.Size = new System.Drawing.Size(47, 19);
            this.label_adet.TabIndex = 15;
            this.label_adet.Text = "label2";
            // 
            // DoktorGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1086, 545);
            this.Controls.Add(this.label_adet);
            this.Controls.Add(this.button_doktorGuncelle);
            this.Controls.Add(this.comboBox_brans);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton_kadin);
            this.Controls.Add(this.radioButton_erkek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_doktorAdSoyad);
            this.Controls.Add(this.textBox_doktorId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_mevcutDoktorlar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DoktorGuncelle";
            this.Text = "DoktorGuncelle";
            this.Load += new System.EventHandler(this.DoktorGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mevcutDoktorlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_mevcutDoktorlar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_doktorId;
        private System.Windows.Forms.TextBox textBox_doktorAdSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton_erkek;
        private System.Windows.Forms.RadioButton radioButton_kadin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_brans;
        private System.Windows.Forms.Button button_doktorGuncelle;
        private System.Windows.Forms.Label label_adet;
    }
}