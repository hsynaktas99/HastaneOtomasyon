namespace HastaneOtomasyon.Presentation_Layer
{
    partial class RandevuSil
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
            this.dataGridView_randevular = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_randevuId = new System.Windows.Forms.TextBox();
            this.textBox_randevuSahibi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_randevuSil = new System.Windows.Forms.Button();
            this.label_adet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_randevular)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_randevular
            // 
            this.dataGridView_randevular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_randevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_randevular.Location = new System.Drawing.Point(12, 59);
            this.dataGridView_randevular.Name = "dataGridView_randevular";
            this.dataGridView_randevular.RowTemplate.Height = 24;
            this.dataGridView_randevular.Size = new System.Drawing.Size(1062, 293);
            this.dataGridView_randevular.TabIndex = 0;
            this.dataGridView_randevular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_randevular_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Randevu ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Randevu Sahibi:";
            // 
            // textBox_randevuId
            // 
            this.textBox_randevuId.Enabled = false;
            this.textBox_randevuId.Location = new System.Drawing.Point(451, 372);
            this.textBox_randevuId.Name = "textBox_randevuId";
            this.textBox_randevuId.Size = new System.Drawing.Size(102, 30);
            this.textBox_randevuId.TabIndex = 3;
            // 
            // textBox_randevuSahibi
            // 
            this.textBox_randevuSahibi.Enabled = false;
            this.textBox_randevuSahibi.Location = new System.Drawing.Point(451, 416);
            this.textBox_randevuSahibi.Name = "textBox_randevuSahibi";
            this.textBox_randevuSahibi.Size = new System.Drawing.Size(317, 30);
            this.textBox_randevuSahibi.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(375, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "RANDEVU SİL";
            // 
            // button_randevuSil
            // 
            this.button_randevuSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_randevuSil.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_randevuSil.Location = new System.Drawing.Point(451, 473);
            this.button_randevuSil.Name = "button_randevuSil";
            this.button_randevuSil.Size = new System.Drawing.Size(230, 49);
            this.button_randevuSil.TabIndex = 1;
            this.button_randevuSil.Text = "SİL";
            this.button_randevuSil.UseVisualStyleBackColor = false;
            this.button_randevuSil.Click += new System.EventHandler(this.button_randevuSil_Click);
            this.button_randevuSil.MouseLeave += new System.EventHandler(this.button_randevuSil_MouseLeave);
            this.button_randevuSil.MouseHover += new System.EventHandler(this.button_randevuSil_MouseHover);
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
            this.label_adet.TabIndex = 7;
            this.label_adet.Text = "label2";
            // 
            // RandevuSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1086, 545);
            this.Controls.Add(this.label_adet);
            this.Controls.Add(this.button_randevuSil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_randevuSahibi);
            this.Controls.Add(this.textBox_randevuId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_randevular);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RandevuSil";
            this.Text = "RandevuSil";
            this.Load += new System.EventHandler(this.RandevuSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_randevular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_randevular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_randevuId;
        private System.Windows.Forms.TextBox textBox_randevuSahibi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_randevuSil;
        private System.Windows.Forms.Label label_adet;
    }
}