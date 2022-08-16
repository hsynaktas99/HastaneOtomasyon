namespace HastaneOtomasyon.Presentation_Layer
{
    partial class BransEkle
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
            this.textBox_bransAdi = new System.Windows.Forms.TextBox();
            this.button_bransEkle = new System.Windows.Forms.Button();
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
            this.label1.TabIndex = 3;
            this.label1.Text = "BRANŞ EKLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Branş Adı:";
            // 
            // textBox_bransAdi
            // 
            this.textBox_bransAdi.Location = new System.Drawing.Point(414, 153);
            this.textBox_bransAdi.Name = "textBox_bransAdi";
            this.textBox_bransAdi.Size = new System.Drawing.Size(363, 30);
            this.textBox_bransAdi.TabIndex = 0;
            // 
            // button_bransEkle
            // 
            this.button_bransEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_bransEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_bransEkle.Location = new System.Drawing.Point(428, 370);
            this.button_bransEkle.Name = "button_bransEkle";
            this.button_bransEkle.Size = new System.Drawing.Size(202, 55);
            this.button_bransEkle.TabIndex = 5;
            this.button_bransEkle.Text = "EKLE";
            this.button_bransEkle.UseVisualStyleBackColor = false;
            this.button_bransEkle.Click += new System.EventHandler(this.button_bransEkle_Click);
            this.button_bransEkle.MouseLeave += new System.EventHandler(this.button_bransEkle_MouseLeave);
            this.button_bransEkle.MouseHover += new System.EventHandler(this.button_bransEkle_MouseHover);
            // 
            // BransEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1086, 545);
            this.Controls.Add(this.button_bransEkle);
            this.Controls.Add(this.textBox_bransAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BransEkle";
            this.Text = "BransEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_bransAdi;
        private System.Windows.Forms.Button button_bransEkle;
    }
}