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
    public partial class MevcutRandevular : Form
    {
        public MevcutRandevular()
        {
            InitializeComponent();
        }


        private void MevcutRandevularHatasi(Exception hata)
        {
            MessageBox.Show("Hata:" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        BusinessOperations businessOperations = new BusinessOperations();

        private void MevcutRandevular_Load(object sender, EventArgs e)
        {
            try
            {
                businessOperations.randevulariYukle(dataGridView_mevcutRandevular);
                businessOperations.satirSayisi(dataGridView_mevcutRandevular, label_adet);
            }
            catch(Exception hata)
            {
                MevcutRandevularHatasi(hata);
            }
            
        }

        private void button_randevuTarihiKucuktenBuyuge_Click(object sender, EventArgs e)
        {
            try
            {
                businessOperations.randevuTarihineGoreKucuktenBuyugeSirala(dataGridView_mevcutRandevular);
                businessOperations.satirSayisi(dataGridView_mevcutRandevular, label_adet);
            }
            catch(Exception hata)
            {
                MevcutRandevularHatasi(hata);
            }
            
        }

        private void button_randevuTarihiBuyuktenKucuge_Click(object sender, EventArgs e)
        {
            try
            {
                businessOperations.randevuTarihineGoreBuyuktenKucugeSirala(dataGridView_mevcutRandevular);
                businessOperations.satirSayisi(dataGridView_mevcutRandevular, label_adet);
            }
            catch (Exception hata)
            {
                MevcutRandevularHatasi(hata);
            }
        }

        private void button_hastaAdiKucuktenBuyuge_Click(object sender, EventArgs e)
        {
            try
            {
                businessOperations.hastaAdinaGoreKucuktenBuyugeSirala(dataGridView_mevcutRandevular, dataGridView_mevcutRandevular.CurrentRow.Cells[1].Value.ToString());
                businessOperations.satirSayisi(dataGridView_mevcutRandevular, label_adet);
            }
            catch(Exception hata)
            {
                MevcutRandevularHatasi(hata);
            }
        }

        private void button_hastaAdinaGoreBuyuktenKucuge_Click(object sender, EventArgs e)
        {
            try
            {
                businessOperations.hastaAdinaGoreBuyuktenKucugeSirala(dataGridView_mevcutRandevular, dataGridView_mevcutRandevular.CurrentRow.Cells[1].Value.ToString());
                businessOperations.satirSayisi(dataGridView_mevcutRandevular, label_adet); 
            }
            catch (Exception hata)
            {
                MevcutRandevularHatasi(hata);
            }
        }

        private void textBox_arama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                businessOperations.hastaAdinaGoreArama(dataGridView_mevcutRandevular, textBox_arama.Text);
                businessOperations.satirSayisi(dataGridView_mevcutRandevular, label_adet);
            }
            catch(Exception hata)
            {
                MevcutRandevularHatasi(hata);
            }
        }

        private void button_randevuTarihiKucuktenBuyuge_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button_randevuTarihiKucuktenBuyuge_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void button_randevuTarihiBuyuktenKucuge_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button_randevuTarihiBuyuktenKucuge_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void button_hastaAdiKucuktenBuyuge_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button_hastaAdiKucuktenBuyuge_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void button_hastaAdinaGoreBuyuktenKucuge_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button_hastaAdinaGoreBuyuktenKucuge_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }

}
