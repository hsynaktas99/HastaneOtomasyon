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
    public partial class DoktorGuncelle : Form
    {
        public DoktorGuncelle()
        {
            InitializeComponent();
        }

        BusinessOperations businessOperations = new BusinessOperations();

        private void doktorGuncellemeHatasi(Exception hata)
        {
            MessageBox.Show("Hata:" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DoktorGuncelle_Load(object sender, EventArgs e)
        {
            try
            {
                businessOperations.doktorlariYukle(dataGridView_mevcutDoktorlar);
                businessOperations.branslariYukle(comboBox_brans);
                businessOperations.satirSayisi(dataGridView_mevcutDoktorlar, label_adet);
            }
            catch(Exception hata)
            {
                doktorGuncellemeHatasi(hata);
            }
        }

        private void button_doktorGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_doktorId.Text);
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
                byte brans = Convert.ToByte(comboBox_brans.SelectedValue);

                if (id.ToString().Trim().Equals("") || doktorAdSoyad.Trim().Equals("") || cinsiyet.Equals(null) || brans < 1)
                {
                    MessageBox.Show("Alanları boş bırakmayınız,", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    businessOperations.doktorGuncelle(id, doktorAdSoyad, cinsiyet, brans);
                    businessOperations.doktorlariYukle(dataGridView_mevcutDoktorlar);
                    businessOperations.satirSayisi(dataGridView_mevcutDoktorlar, label_adet);
                    MessageBox.Show("Doktor Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizle();
                }

            }
            catch(Exception hata)
            {
                doktorGuncellemeHatasi(hata);
            }
        }

        private void dataGridView_mevcutDoktorlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox_doktorId.Text = dataGridView_mevcutDoktorlar.CurrentRow.Cells[0].Value.ToString();
            textBox_doktorAdSoyad.Text = dataGridView_mevcutDoktorlar.CurrentRow.Cells[1].Value.ToString();
            string cinsiyet = dataGridView_mevcutDoktorlar.CurrentRow.Cells[2].Value.ToString();
            if (cinsiyet.Trim().Equals("erkek"))
            {
                radioButton_erkek.Checked = true;
            }
            else
            {
                radioButton_kadin.Checked = true;
            }
        } 

        private void temizle()
        {
            textBox_doktorId.Clear();
            textBox_doktorAdSoyad.Clear();
            radioButton_erkek.Checked = false;
            radioButton_kadin.Checked = false;
            comboBox_brans.SelectedIndex = 0;
        }

        private void button_doktorGuncelle_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button_doktorGuncelle_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
