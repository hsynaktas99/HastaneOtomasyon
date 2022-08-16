using HastaneOtomasyon.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void menuStrip_ustMenu_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void menuStrip_ustMenu_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formYukle(Form form)
        {
            panel_anaPanel.Controls.Clear();
            form.MdiParent = this;
            panel_anaPanel.Controls.Add(form);
            form.Show();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            formYukle(new MevcutRandevular());
        }

        private void mevcutRandevularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formYukle(new MevcutRandevular());
        }

        private void randevuOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formYukle(new RandevuOlustur());
        }

        private void randevuSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formYukle(new RandevuSil());
        }

        private void randevuDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formYukle(new RandevuGuncelle());
        }

        private void doktorEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formYukle(new MevcutDoktorlar());
        }

        private void doktorListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formYukle(new DoktorEkle());
        }

        private void doktorGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formYukle(new DoktorGuncelle());
        }

        private void doktorSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formYukle(new DoktorSil());
        }

        private void branşlarListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formYukle(new MevcutBranslar());
        }

        private void branşEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formYukle(new BransEkle());
        }

        private void branşGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formYukle(new BransGuncelle());
        }

        private void branşSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formYukle(new BransSil());
        }

        private void bRANŞLARAGÖREDOKTORSAYISIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formYukle(new BranslaraGoreDoktorSayisi());
        }

        private void bRANŞLARAGÖREHASTASAYISIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formYukle(new BranslaraGoreRandevuSayisi());
        }

        private void dOKTORLARINCİNSİYETDAĞILIMIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formYukle(new DoktorlarinCinsiyetDagilimi());
        }

        private void hASTALARINCİNSİYETDAĞILIMIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formYukle(new HastalarinCinsiyetDagilimi());
        }

        private void hASTALARINYAŞARALIĞIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formYukle(new HastalarinYasAraligi());
        }
    }
}
