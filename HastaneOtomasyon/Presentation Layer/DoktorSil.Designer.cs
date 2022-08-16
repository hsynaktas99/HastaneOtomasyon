namespace HastaneOtomasyon.Presentation_Layer
{
    partial class DoktorSil
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
            this.textBox_doktorAdSoyad = new System.Windows.Forms.TextBox();
            this.textBox_doktorId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_doktorEkle = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(187, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "DOKTOR SİL";
            // 
            // dataGridView_mevcutDoktorlar
            // 
            this.dataGridView_mevcutDoktorlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_mevcutDoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_mevcutDoktorlar.Location = new System.Drawing.Point(12, 68);
            this.dataGridView_mevcutDoktorlar.Name = "dataGridView_mevcutDoktorlar";
            this.dataGridView_mevcutDoktorlar.RowTemplate.Height = 24;
            this.dataGridView_mevcutDoktorlar.Size = new System.Drawing.Size(1062, 303);
            this.dataGridView_mevcutDoktorlar.TabIndex = 7;
            this.dataGridView_mevcutDoktorlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_mevcutDoktorlar_CellClick);
            // 
            // textBox_doktorAdSoyad
            // 
            this.textBox_doktorAdSoyad.Enabled = false;
            this.textBox_doktorAdSoyad.Location = new System.Drawing.Point(495, 434);
            this.textBox_doktorAdSoyad.Name = "textBox_doktorAdSoyad";
            this.textBox_doktorAdSoyad.Size = new System.Drawing.Size(287, 30);
            this.textBox_doktorAdSoyad.TabIndex = 10;
            // 
            // textBox_doktorId
            // 
            this.textBox_doktorId.Enabled = false;
            this.textBox_doktorId.Location = new System.Drawing.Point(495, 385);
            this.textBox_doktorId.Name = "textBox_doktorId";
            this.textBox_doktorId.Size = new System.Drawing.Size(100, 30);
            this.textBox_doktorId.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Doktor Adı ve Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Doktor ID:";
            // 
            // button_doktorEkle
            // 
            this.button_doktorEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_doktorEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_doktorEkle.Location = new System.Drawing.Point(457, 478);
            this.button_doktorEkle.Name = "button_doktorEkle";
            this.button_doktorEkle.Size = new System.Drawing.Size(202, 55);
            this.button_doktorEkle.TabIndex = 13;
            this.button_doktorEkle.Text = "SİL";
            this.button_doktorEkle.UseVisualStyleBackColor = false;
            this.button_doktorEkle.Click += new System.EventHandler(this.button_doktorEkle_Click);
            this.button_doktorEkle.MouseLeave += new System.EventHandler(this.button_doktorEkle_MouseLeave);
            this.button_doktorEkle.MouseHover += new System.EventHandler(this.button_doktorEkle_MouseHover);
            // 
            // label_adet
            // 
            this.label_adet.AutoSize = true;
            this.label_adet.BackColor = System.Drawing.Color.White;
            this.label_adet.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_adet.ForeColor = System.Drawing.Color.Red;
            this.label_adet.Location = new System.Drawing.Point(33, 31);
            this.label_adet.Name = "label_adet";
            this.label_adet.Size = new System.Drawing.Size(47, 19);
            this.label_adet.TabIndex = 16;
            this.label_adet.Text = "label2";
            // 
            // DoktorSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1086, 545);
            this.Controls.Add(this.label_adet);
            this.Controls.Add(this.button_doktorEkle);
            this.Controls.Add(this.textBox_doktorAdSoyad);
            this.Controls.Add(this.textBox_doktorId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_mevcutDoktorlar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DoktorSil";
            this.Text = "DoktorSil";
            this.Load += new System.EventHandler(this.DoktorSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mevcutDoktorlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_mevcutDoktorlar;
        private System.Windows.Forms.TextBox textBox_doktorAdSoyad;
        private System.Windows.Forms.TextBox textBox_doktorId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_doktorEkle;
        private System.Windows.Forms.Label label_adet;
    }
}