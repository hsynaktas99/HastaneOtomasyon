namespace HastaneOtomasyon
{
    partial class AnaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.menuStrip_ustMenu = new System.Windows.Forms.MenuStrip();
            this.randevuİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mevcutRandevularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.branşİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.branşlarListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.branşEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.branşGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.branşSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istatistiklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bRANŞLARAGÖREDOKTORSAYISIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bRANŞLARAGÖREHASTASAYISIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dOKTORLARINCİNSİYETDAĞILIMIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hASTALARINCİNSİYETDAĞILIMIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hASTALARINYAŞARALIĞIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ımageList = new System.Windows.Forms.ImageList(this.components);
            this.panel_anaPanel = new System.Windows.Forms.Panel();
            this.menuStrip_ustMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_ustMenu
            // 
            this.menuStrip_ustMenu.BackColor = System.Drawing.Color.Red;
            this.menuStrip_ustMenu.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip_ustMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_ustMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevuİşlemleriToolStripMenuItem,
            this.doktorİşlemleriToolStripMenuItem,
            this.branşİşlemleriToolStripMenuItem,
            this.istatistiklerToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip_ustMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_ustMenu.Name = "menuStrip_ustMenu";
            this.menuStrip_ustMenu.Size = new System.Drawing.Size(1086, 31);
            this.menuStrip_ustMenu.TabIndex = 0;
            this.menuStrip_ustMenu.Text = "menuStrip";
            this.menuStrip_ustMenu.MouseLeave += new System.EventHandler(this.menuStrip_ustMenu_MouseLeave);
            this.menuStrip_ustMenu.MouseHover += new System.EventHandler(this.menuStrip_ustMenu_MouseHover);
            // 
            // randevuİşlemleriToolStripMenuItem
            // 
            this.randevuİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mevcutRandevularToolStripMenuItem,
            this.randevuOluşturToolStripMenuItem,
            this.randevuSilToolStripMenuItem,
            this.randevuDüzenleToolStripMenuItem});
            this.randevuİşlemleriToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.randevuİşlemleriToolStripMenuItem.Name = "randevuİşlemleriToolStripMenuItem";
            this.randevuİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(185, 27);
            this.randevuİşlemleriToolStripMenuItem.Text = "Randevu İşlemleri";
            // 
            // mevcutRandevularToolStripMenuItem
            // 
            this.mevcutRandevularToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mevcutRandevularToolStripMenuItem.Image")));
            this.mevcutRandevularToolStripMenuItem.Name = "mevcutRandevularToolStripMenuItem";
            this.mevcutRandevularToolStripMenuItem.Size = new System.Drawing.Size(266, 28);
            this.mevcutRandevularToolStripMenuItem.Text = "Mevcut Randevular";
            this.mevcutRandevularToolStripMenuItem.Click += new System.EventHandler(this.mevcutRandevularToolStripMenuItem_Click);
            // 
            // randevuOluşturToolStripMenuItem
            // 
            this.randevuOluşturToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("randevuOluşturToolStripMenuItem.Image")));
            this.randevuOluşturToolStripMenuItem.Name = "randevuOluşturToolStripMenuItem";
            this.randevuOluşturToolStripMenuItem.Size = new System.Drawing.Size(266, 28);
            this.randevuOluşturToolStripMenuItem.Text = "Randevu Oluştur";
            this.randevuOluşturToolStripMenuItem.Click += new System.EventHandler(this.randevuOluşturToolStripMenuItem_Click);
            // 
            // randevuSilToolStripMenuItem
            // 
            this.randevuSilToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("randevuSilToolStripMenuItem.Image")));
            this.randevuSilToolStripMenuItem.Name = "randevuSilToolStripMenuItem";
            this.randevuSilToolStripMenuItem.Size = new System.Drawing.Size(266, 28);
            this.randevuSilToolStripMenuItem.Text = "Randevu Sil";
            this.randevuSilToolStripMenuItem.Click += new System.EventHandler(this.randevuSilToolStripMenuItem_Click);
            // 
            // randevuDüzenleToolStripMenuItem
            // 
            this.randevuDüzenleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("randevuDüzenleToolStripMenuItem.Image")));
            this.randevuDüzenleToolStripMenuItem.Name = "randevuDüzenleToolStripMenuItem";
            this.randevuDüzenleToolStripMenuItem.Size = new System.Drawing.Size(266, 28);
            this.randevuDüzenleToolStripMenuItem.Text = "Randevu Güncelle";
            this.randevuDüzenleToolStripMenuItem.Click += new System.EventHandler(this.randevuDüzenleToolStripMenuItem_Click);
            // 
            // doktorİşlemleriToolStripMenuItem
            // 
            this.doktorİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doktorEkleToolStripMenuItem,
            this.doktorListesiToolStripMenuItem,
            this.doktorGüncelleToolStripMenuItem,
            this.doktorSilToolStripMenuItem});
            this.doktorİşlemleriToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.doktorİşlemleriToolStripMenuItem.Name = "doktorİşlemleriToolStripMenuItem";
            this.doktorİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(163, 27);
            this.doktorİşlemleriToolStripMenuItem.Text = "Doktor İşlemleri";
            // 
            // doktorEkleToolStripMenuItem
            // 
            this.doktorEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("doktorEkleToolStripMenuItem.Image")));
            this.doktorEkleToolStripMenuItem.Name = "doktorEkleToolStripMenuItem";
            this.doktorEkleToolStripMenuItem.Size = new System.Drawing.Size(235, 28);
            this.doktorEkleToolStripMenuItem.Text = "Doktor Listesi";
            this.doktorEkleToolStripMenuItem.Click += new System.EventHandler(this.doktorEkleToolStripMenuItem_Click);
            // 
            // doktorListesiToolStripMenuItem
            // 
            this.doktorListesiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("doktorListesiToolStripMenuItem.Image")));
            this.doktorListesiToolStripMenuItem.Name = "doktorListesiToolStripMenuItem";
            this.doktorListesiToolStripMenuItem.Size = new System.Drawing.Size(235, 28);
            this.doktorListesiToolStripMenuItem.Text = "Doktor Ekle";
            this.doktorListesiToolStripMenuItem.Click += new System.EventHandler(this.doktorListesiToolStripMenuItem_Click);
            // 
            // doktorGüncelleToolStripMenuItem
            // 
            this.doktorGüncelleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("doktorGüncelleToolStripMenuItem.Image")));
            this.doktorGüncelleToolStripMenuItem.Name = "doktorGüncelleToolStripMenuItem";
            this.doktorGüncelleToolStripMenuItem.Size = new System.Drawing.Size(235, 28);
            this.doktorGüncelleToolStripMenuItem.Text = "Doktor Güncelle";
            this.doktorGüncelleToolStripMenuItem.Click += new System.EventHandler(this.doktorGüncelleToolStripMenuItem_Click);
            // 
            // doktorSilToolStripMenuItem
            // 
            this.doktorSilToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("doktorSilToolStripMenuItem.Image")));
            this.doktorSilToolStripMenuItem.Name = "doktorSilToolStripMenuItem";
            this.doktorSilToolStripMenuItem.Size = new System.Drawing.Size(235, 28);
            this.doktorSilToolStripMenuItem.Text = "Doktor Sil";
            this.doktorSilToolStripMenuItem.Click += new System.EventHandler(this.doktorSilToolStripMenuItem_Click);
            // 
            // branşİşlemleriToolStripMenuItem
            // 
            this.branşİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.branşlarListesiToolStripMenuItem,
            this.branşEkleToolStripMenuItem,
            this.branşGüncelleToolStripMenuItem,
            this.branşSilToolStripMenuItem});
            this.branşİşlemleriToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.branşİşlemleriToolStripMenuItem.Name = "branşİşlemleriToolStripMenuItem";
            this.branşİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(152, 27);
            this.branşİşlemleriToolStripMenuItem.Text = "Branş İşlemleri";
            // 
            // branşlarListesiToolStripMenuItem
            // 
            this.branşlarListesiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("branşlarListesiToolStripMenuItem.Image")));
            this.branşlarListesiToolStripMenuItem.Name = "branşlarListesiToolStripMenuItem";
            this.branşlarListesiToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.branşlarListesiToolStripMenuItem.Text = "Branş Listesi";
            this.branşlarListesiToolStripMenuItem.Click += new System.EventHandler(this.branşlarListesiToolStripMenuItem_Click);
            // 
            // branşEkleToolStripMenuItem
            // 
            this.branşEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("branşEkleToolStripMenuItem.Image")));
            this.branşEkleToolStripMenuItem.Name = "branşEkleToolStripMenuItem";
            this.branşEkleToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.branşEkleToolStripMenuItem.Text = "Branş Ekle";
            this.branşEkleToolStripMenuItem.Click += new System.EventHandler(this.branşEkleToolStripMenuItem_Click);
            // 
            // branşGüncelleToolStripMenuItem
            // 
            this.branşGüncelleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("branşGüncelleToolStripMenuItem.Image")));
            this.branşGüncelleToolStripMenuItem.Name = "branşGüncelleToolStripMenuItem";
            this.branşGüncelleToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.branşGüncelleToolStripMenuItem.Text = "Branş Güncelle";
            this.branşGüncelleToolStripMenuItem.Click += new System.EventHandler(this.branşGüncelleToolStripMenuItem_Click);
            // 
            // branşSilToolStripMenuItem
            // 
            this.branşSilToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("branşSilToolStripMenuItem.Image")));
            this.branşSilToolStripMenuItem.Name = "branşSilToolStripMenuItem";
            this.branşSilToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.branşSilToolStripMenuItem.Text = "Branş Sil";
            this.branşSilToolStripMenuItem.Click += new System.EventHandler(this.branşSilToolStripMenuItem_Click);
            // 
            // istatistiklerToolStripMenuItem
            // 
            this.istatistiklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bRANŞLARAGÖREDOKTORSAYISIToolStripMenuItem,
            this.bRANŞLARAGÖREHASTASAYISIToolStripMenuItem,
            this.dOKTORLARINCİNSİYETDAĞILIMIToolStripMenuItem,
            this.hASTALARINCİNSİYETDAĞILIMIToolStripMenuItem,
            this.hASTALARINYAŞARALIĞIToolStripMenuItem});
            this.istatistiklerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.istatistiklerToolStripMenuItem.Name = "istatistiklerToolStripMenuItem";
            this.istatistiklerToolStripMenuItem.Size = new System.Drawing.Size(118, 27);
            this.istatistiklerToolStripMenuItem.Text = "İstatistikler";
            // 
            // bRANŞLARAGÖREDOKTORSAYISIToolStripMenuItem
            // 
            this.bRANŞLARAGÖREDOKTORSAYISIToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bRANŞLARAGÖREDOKTORSAYISIToolStripMenuItem.Image")));
            this.bRANŞLARAGÖREDOKTORSAYISIToolStripMenuItem.Name = "bRANŞLARAGÖREDOKTORSAYISIToolStripMenuItem";
            this.bRANŞLARAGÖREDOKTORSAYISIToolStripMenuItem.Size = new System.Drawing.Size(405, 28);
            this.bRANŞLARAGÖREDOKTORSAYISIToolStripMenuItem.Text = "BRANŞLARA GÖRE DOKTOR SAYISI";
            this.bRANŞLARAGÖREDOKTORSAYISIToolStripMenuItem.Click += new System.EventHandler(this.bRANŞLARAGÖREDOKTORSAYISIToolStripMenuItem_Click);
            // 
            // bRANŞLARAGÖREHASTASAYISIToolStripMenuItem
            // 
            this.bRANŞLARAGÖREHASTASAYISIToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bRANŞLARAGÖREHASTASAYISIToolStripMenuItem.Image")));
            this.bRANŞLARAGÖREHASTASAYISIToolStripMenuItem.Name = "bRANŞLARAGÖREHASTASAYISIToolStripMenuItem";
            this.bRANŞLARAGÖREHASTASAYISIToolStripMenuItem.Size = new System.Drawing.Size(405, 28);
            this.bRANŞLARAGÖREHASTASAYISIToolStripMenuItem.Text = "BRANŞLARA GÖRE RANDEVU SAYISI";
            this.bRANŞLARAGÖREHASTASAYISIToolStripMenuItem.Click += new System.EventHandler(this.bRANŞLARAGÖREHASTASAYISIToolStripMenuItem_Click);
            // 
            // dOKTORLARINCİNSİYETDAĞILIMIToolStripMenuItem
            // 
            this.dOKTORLARINCİNSİYETDAĞILIMIToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dOKTORLARINCİNSİYETDAĞILIMIToolStripMenuItem.Image")));
            this.dOKTORLARINCİNSİYETDAĞILIMIToolStripMenuItem.Name = "dOKTORLARINCİNSİYETDAĞILIMIToolStripMenuItem";
            this.dOKTORLARINCİNSİYETDAĞILIMIToolStripMenuItem.Size = new System.Drawing.Size(405, 28);
            this.dOKTORLARINCİNSİYETDAĞILIMIToolStripMenuItem.Text = "DOKTORLARIN CİNSİYET DAĞILIMI";
            this.dOKTORLARINCİNSİYETDAĞILIMIToolStripMenuItem.Click += new System.EventHandler(this.dOKTORLARINCİNSİYETDAĞILIMIToolStripMenuItem_Click);
            // 
            // hASTALARINCİNSİYETDAĞILIMIToolStripMenuItem
            // 
            this.hASTALARINCİNSİYETDAĞILIMIToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hASTALARINCİNSİYETDAĞILIMIToolStripMenuItem.Image")));
            this.hASTALARINCİNSİYETDAĞILIMIToolStripMenuItem.Name = "hASTALARINCİNSİYETDAĞILIMIToolStripMenuItem";
            this.hASTALARINCİNSİYETDAĞILIMIToolStripMenuItem.Size = new System.Drawing.Size(405, 28);
            this.hASTALARINCİNSİYETDAĞILIMIToolStripMenuItem.Text = "HASTALARIN CİNSİYET DAĞILIMI";
            this.hASTALARINCİNSİYETDAĞILIMIToolStripMenuItem.Click += new System.EventHandler(this.hASTALARINCİNSİYETDAĞILIMIToolStripMenuItem_Click);
            // 
            // hASTALARINYAŞARALIĞIToolStripMenuItem
            // 
            this.hASTALARINYAŞARALIĞIToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hASTALARINYAŞARALIĞIToolStripMenuItem.Image")));
            this.hASTALARINYAŞARALIĞIToolStripMenuItem.Name = "hASTALARINYAŞARALIĞIToolStripMenuItem";
            this.hASTALARINYAŞARALIĞIToolStripMenuItem.Size = new System.Drawing.Size(405, 28);
            this.hASTALARINYAŞARALIĞIToolStripMenuItem.Text = "HASTALARIN YAŞ ARALIĞI";
            this.hASTALARINYAŞARALIĞIToolStripMenuItem.Click += new System.EventHandler(this.hASTALARINYAŞARALIĞIToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(66, 27);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // ımageList
            // 
            this.ımageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel_anaPanel
            // 
            this.panel_anaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_anaPanel.Location = new System.Drawing.Point(0, 31);
            this.panel_anaPanel.Name = "panel_anaPanel";
            this.panel_anaPanel.Size = new System.Drawing.Size(1086, 545);
            this.panel_anaPanel.TabIndex = 3;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1086, 576);
            this.Controls.Add(this.panel_anaPanel);
            this.Controls.Add(this.menuStrip_ustMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane Otomasyon";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.menuStrip_ustMenu.ResumeLayout(false);
            this.menuStrip_ustMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_ustMenu;
        private System.Windows.Forms.ToolStripMenuItem randevuİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem branşİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istatistiklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mevcutRandevularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem branşlarListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem branşEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem branşGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem branşSilToolStripMenuItem;
        private System.Windows.Forms.ImageList ımageList;
        private System.Windows.Forms.Panel panel_anaPanel;
        private System.Windows.Forms.ToolStripMenuItem bRANŞLARAGÖREDOKTORSAYISIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bRANŞLARAGÖREHASTASAYISIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dOKTORLARINCİNSİYETDAĞILIMIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hASTALARINCİNSİYETDAĞILIMIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hASTALARINYAŞARALIĞIToolStripMenuItem;
    }
}

