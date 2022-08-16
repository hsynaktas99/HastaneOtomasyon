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
    public partial class DoktorEkle : Form
    {
        public DoktorEkle()
        {
            InitializeComponent();
        }

        BusinessOperations businessOperations = new BusinessOperations();

        private void doktorEklemeHatasi(Exception hata)
        {
            MessageBox.Show("Hata:" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DoktorEkle_Load(object sender, EventArgs e)
        {
            try
            {
                businessOperations.branslariYukle(comboBox_doktorBransi);
            }
            catch(Exception hata)
            {
                doktorEklemeHatasi(hata);
            }
        }

        private void button_doktorEkle_Click(object sender, EventArgs e)
        {

            try
            {
                string doktorAdSoyad = textBox_doktorAdSoyad.Text;
                string cinsiyet = null;
                if (radioButton_erkek.Checked == true)
                {
                    cinsiyet = "erkek";
                }
                else if (radioButton_kadin.Checked == true)
                {
                    cinsiyet = "kadin";
                }
                byte brans = Convert.ToByte(comboBox_doktorBransi.SelectedValue);

                if (doktorAdSoyad.Trim().Equals("") || cinsiyet.Equals(null) || brans < 1)
                {
                    MessageBox.Show("Alanları boş bırakmayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    businessOperations.doktorEkle(doktorAdSoyad, cinsiyet, brans);
                    MessageBox.Show("Doktor Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizle();
                }
            }
            catch(Exception hata)
            {
                doktorEklemeHatasi(hata);
            }
            
            
        } 

        private void temizle()
        {
            textBox_doktorAdSoyad.Clear();
            radioButton_erkek.Checked = false;
            radioButton_kadin.Checked = false;
            comboBox_doktorBransi.SelectedIndex = -1;
            textBox_doktorAdSoyad.Focus();
        }

        private void button_doktorEkle_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button_doktorEkle_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
