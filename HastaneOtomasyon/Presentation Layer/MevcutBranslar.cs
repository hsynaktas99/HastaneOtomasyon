using HastaneOtomasyon.Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon.Presentation_Layer
{
    public partial class MevcutBranslar : Form
    {
        public MevcutBranslar()
        {
            InitializeComponent();
        }

        BusinessOperations businessOperations = new BusinessOperations();

        private void mevcutBranslarHatasi(Exception hata)
        {
            MessageBox.Show("Hata:" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MevcutBranslar_Load(object sender, EventArgs e)
        {
            try
            {
                businessOperations.branslariListele(dataGridView_mevcutBranslar);
                businessOperations.satirSayisi(dataGridView_mevcutBranslar, label_adet);
                
            }
            catch(Exception hata)
            {
                mevcutBranslarHatasi(hata);
            }
        }

        private void button_bransAdiKucuktenBuyuge_Click(object sender, EventArgs e)
        {
            try
            {
                businessOperations.bransAdinaGoreKucuktenBuyugeSirala(dataGridView_mevcutBranslar);
                businessOperations.satirSayisi(dataGridView_mevcutBranslar, label_adet);
            }
            catch(Exception hata)
            {
                mevcutBranslarHatasi(hata);
            }
        }

        private void button_bransAdinaGoreBuyuktenKucuge_Click(object sender, EventArgs e)
        {
            try
            {
                businessOperations.bransAdinaGoreBuyuktenKucugeSirala(dataGridView_mevcutBranslar);
                businessOperations.satirSayisi(dataGridView_mevcutBranslar, label_adet);
            }
            catch (Exception hata)
            {
                mevcutBranslarHatasi(hata);
            }
        }

        private void textBox_arama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                businessOperations.bransAdinaGoreArama(dataGridView_mevcutBranslar, textBox_arama.Text);
                businessOperations.satirSayisi(dataGridView_mevcutBranslar, label_adet);
            }
            catch(Exception hata)
            {
                mevcutBranslarHatasi(hata);
            }
        }

        private void button_bransAdiKucuktenBuyuge_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button_bransAdiKucuktenBuyuge_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void button_bransAdinaGoreBuyuktenKucuge_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button_bransAdinaGoreBuyuktenKucuge_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
