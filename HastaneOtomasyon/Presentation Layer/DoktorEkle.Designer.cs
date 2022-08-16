namespace HastaneOtomasyon.Presentation_Layer
{
    partial class DoktorEkle
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_doktorAdSoyad = new System.Windows.Forms.TextBox();
            this.radioButton_erkek = new System.Windows.Forms.RadioButton();
            this.radioButton_kadin = new System.Windows.Forms.RadioButton();
            this.comboBox_doktorBransi = new System.Windows.Forms.ComboBox();
            this.button_doktorEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(375, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "DOKTOR EKLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Doktor Adı ve Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Doktor Cinsiyeti:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Doktor Branşı:";
            // 
            // textBox_doktorAdSoyad
            // 
            this.textBox_doktorAdSoyad.Location = new System.Drawing.Point(437, 139);
            this.textBox_doktorAdSoyad.Name = "textBox_doktorAdSoyad";
            this.textBox_doktorAdSoyad.Size = new System.Drawing.Size(349, 30);
            this.textBox_doktorAdSoyad.TabIndex = 0;
            // 
            // radioButton_erkek
            // 
            this.radioButton_erkek.AutoSize = true;
            this.radioButton_erkek.Location = new System.Drawing.Point(437, 205);
            this.radioButton_erkek.Name = "radioButton_erkek";
            this.radioButton_erkek.Size = new System.Drawing.Size(71, 27);
            this.radioButton_erkek.TabIndex = 1;
            this.radioButton_erkek.TabStop = true;
            this.radioButton_erkek.Text = "Erkek";
            this.radioButton_erkek.UseVisualStyleBackColor = true;
            // 
            // radioButton_kadin
            // 
            this.radioButton_kadin.AutoSize = true;
            this.radioButton_kadin.Location = new System.Drawing.Point(527, 205);
            this.radioButton_kadin.Name = "radioButton_kadin";
            this.radioButton_kadin.Size = new System.Drawing.Size(74, 27);
            this.radioButton_kadin.TabIndex = 2;
            this.radioButton_kadin.TabStop = true;
            this.radioButton_kadin.Text = "Kadın";
            this.radioButton_kadin.UseVisualStyleBackColor = true;
            // 
            // comboBox_doktorBransi
            // 
            this.comboBox_doktorBransi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_doktorBransi.FormattingEnabled = true;
            this.comboBox_doktorBransi.Location = new System.Drawing.Point(437, 261);
            this.comboBox_doktorBransi.Name = "comboBox_doktorBransi";
            this.comboBox_doktorBransi.Size = new System.Drawing.Size(347, 31);
            this.comboBox_doktorBransi.TabIndex = 3;
            // 
            // button_doktorEkle
            // 
            this.button_doktorEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_doktorEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_doktorEkle.Location = new System.Drawing.Point(458, 370);
            this.button_doktorEkle.Name = "button_doktorEkle";
            this.button_doktorEkle.Size = new System.Drawing.Size(202, 55);
            this.button_doktorEkle.TabIndex = 4;
            this.button_doktorEkle.Text = "EKLE";
            this.button_doktorEkle.UseVisualStyleBackColor = false;
            this.button_doktorEkle.Click += new System.EventHandler(this.button_doktorEkle_Click);
            this.button_doktorEkle.MouseLeave += new System.EventHandler(this.button_doktorEkle_MouseLeave);
            this.button_doktorEkle.MouseHover += new System.EventHandler(this.button_doktorEkle_MouseHover);
            // 
            // DoktorEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1086, 545);
            this.Controls.Add(this.button_doktorEkle);
            this.Controls.Add(this.comboBox_doktorBransi);
            this.Controls.Add(this.radioButton_kadin);
            this.Controls.Add(this.radioButton_erkek);
            this.Controls.Add(this.textBox_doktorAdSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DoktorEkle";
            this.Text = "DoktorEkle";
            this.Load += new System.EventHandler(this.DoktorEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_doktorAdSoyad;
        private System.Windows.Forms.RadioButton radioButton_erkek;
        private System.Windows.Forms.RadioButton radioButton_kadin;
        private System.Windows.Forms.ComboBox comboBox_doktorBransi;
        private System.Windows.Forms.Button button_doktorEkle;
    }
}