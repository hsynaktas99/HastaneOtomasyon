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
    public partial class BransEkle : Form
    {
        public BransEkle()
        {
            InitializeComponent();
        }

        BusinessOperations businessOperations = new BusinessOperations();

        public void bransEklemeHatasi(Exception hata)
        {
            MessageBox.Show("Hata:" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void button_bransEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string bransAdi = textBox_bransAdi.Text;
                if (bransAdi.Trim().Equals(""))
                {
                    MessageBox.Show("Alanları boş bırakmayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    businessOperations.bransEkle(bransAdi);
                    MessageBox.Show("Branş Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizle();

                }
            }
            catch(Exception hata)
            {
                bransEklemeHatasi(hata);
            }
                
        }
        private void temizle()
        {
            textBox_bransAdi.Clear();
            textBox_bransAdi.Focus();
        }

        private void button_bransEkle_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button_bransEkle_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
