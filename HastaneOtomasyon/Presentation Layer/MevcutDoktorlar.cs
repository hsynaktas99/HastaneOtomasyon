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
    public partial class MevcutDoktorlar : Form
    {
        public MevcutDoktorlar()
        {
            InitializeComponent();
        }

        BusinessOperations businessOperations = new BusinessOperations();

        private void mevcutDoktorlarHatasi(Exception hata)
        {
            MessageBox.Show("Hata:" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MevcutDoktorlar_Load(object sender, EventArgs e)
        {
            try
            {
                businessOperations.doktorlariYukle(dataGridView_mevcutDoktorlar);
                businessOperations.satirSayisi(dataGridView_mevcutDoktorlar, label_adet);
            }
            catch(Exception hata)
            {
                mevcutDoktorlarHatasi(hata);
            }
        }

        private void button_doktorAdiKucuktenBuyuge_Click(object sender, EventArgs e)
        {
            try
            {
                businessOperations.doktorAdinaGoreKucuktenBuyugeSirala(dataGridView_mevcutDoktorlar);
                businessOperations.satirSayisi(dataGridView_mevcutDoktorlar, label_adet);
            }
            catch(Exception hata)
            {
                mevcutDoktorlarHatasi(hata);
            }
        }

        private void button_doktorAdinaGoreBuyuktenKucuge_Click(object sender, EventArgs e)
        {
            try
            {
                businessOperations.doktorAdinaGoreBuyuktenKucugeSirala(dataGridView_mevcutDoktorlar);
                businessOperations.satirSayisi(dataGridView_mevcutDoktorlar, label_adet);
            }
            catch (Exception hata)
            {
                mevcutDoktorlarHatasi(hata);
            }
        }

        private void textBox_arama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                businessOperations.doktorAdinaGoreArama(dataGridView_mevcutDoktorlar, textBox_arama.Text);
                businessOperations.satirSayisi(dataGridView_mevcutDoktorlar, label_adet);
            }
            catch(Exception hata)
            {
                mevcutDoktorlarHatasi(hata);
            }
        }

        private void button_doktorAdiKucuktenBuyuge_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button_doktorAdiKucuktenBuyuge_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void button_doktorAdinaGoreBuyuktenKucuge_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button_doktorAdinaGoreBuyuktenKucuge_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        
    }
}
