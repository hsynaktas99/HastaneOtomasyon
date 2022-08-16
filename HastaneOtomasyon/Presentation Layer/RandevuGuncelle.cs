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
    public partial class RandevuGuncelle : Form
    {
        public RandevuGuncelle()
        {
            InitializeComponent();
        }

        BusinessOperations businessOperations = new BusinessOperations();

        private void randevuGuncelleHatasi(Exception hata)
        {
            MessageBox.Show("Hata:" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RandevuGuncelle_Load(object sender, EventArgs e)
        {
            try
            {
                businessOperations.randevulariYukle(dataGridView_randevular);
                businessOperations.branslariYukle(comboBox_hastaBransi);
                businessOperations.satirSayisi(dataGridView_randevular, label_adet);
            }
            catch (Exception hata)
            {
                randevuGuncelleHatasi(hata);
            }
        }

        private void button_randevuGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_randevuId.Text);
                string hastaAdi = textBox_hastaAdi.Text;
                string hastaSoyadi = textBox_hastaSoyadi.Text;
                string cinsiyet = null;
                if (radioButton_erkek.Checked == true)
                {
                    cinsiyet = "erkek";
                }
                else if (radioButton_kadin.Checked == true)
                {
                    cinsiyet = "kadin";
                }
                byte hastaYasi = Convert.ToByte(textBox_hastaYasi.Text);
                byte hastaBransi = Convert.ToByte(comboBox_hastaBransi.SelectedValue);
                int hastaDoktoru = Convert.ToInt32(comboBox_hastaDoktoru.SelectedValue);
                DateTime randevuTarihi = dateTimePicker_randevuTarihi.Value;

                if (hastaAdi.Trim().Equals("") || hastaSoyadi.Equals("") || cinsiyet.Equals(null) || hastaYasi.ToString().Trim().Equals("") || hastaBransi < 1 || hastaDoktoru < 1)
                {
                    MessageBox.Show("Alanları boş bırakmayın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    businessOperations.randevuGuncelle(id, hastaAdi, hastaSoyadi, cinsiyet, hastaYasi, hastaBransi, hastaDoktoru, randevuTarihi);
                    businessOperations.randevulariYukle(dataGridView_randevular);
                    businessOperations.satirSayisi(dataGridView_randevular, label_adet);
                    MessageBox.Show("Randevu Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizle();
                }

            }
            catch(Exception hata)
            {
                randevuGuncelleHatasi(hata);
            }
        }

        private void temizle()
        {
            textBox_randevuId.Clear();
            textBox_hastaAdi.Clear();
            textBox_hastaSoyadi.Clear();
            radioButton_erkek.Checked = false;
            radioButton_kadin.Checked = false;
            textBox_hastaYasi.Clear();

        }

        private void dataGridView_randevular_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox_randevuId.Text = dataGridView_randevular.CurrentRow.Cells[0].Value.ToString();
            textBox_hastaAdi.Text = dataGridView_randevular.CurrentRow.Cells[1].Value.ToString();
            textBox_hastaSoyadi.Text = dataGridView_randevular.CurrentRow.Cells[2].Value.ToString();
            string cinsiyet = dataGridView_randevular.CurrentRow.Cells[3].Value.ToString();
            if (cinsiyet.Equals("erkek"))
            {
                radioButton_erkek.Checked = true;
            }
            else
            {
                radioButton_kadin.Checked = true;
            }
            textBox_hastaYasi.Text = dataGridView_randevular.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker_randevuTarihi.Value =(DateTime)dataGridView_randevular.CurrentRow.Cells[7].Value;

           
            
        }

        private void comboBox_hastaBransi_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_hastaDoktoru.SelectedIndex = -1;
            try
            {
                businessOperations.doktorlariYukle(Convert.ToByte(comboBox_hastaBransi.SelectedValue), comboBox_hastaDoktoru);
            }
            catch (Exception hata)
            {
                randevuGuncelleHatasi(hata);
            }
        }

        private void button_randevuGuncelle_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button_randevuGuncelle_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
