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
    public partial class RandevuOlustur : Form
    {
        public RandevuOlustur()
        {
            InitializeComponent();
            
        }
        //DateTimePicker Formatı = dd/MM/yyyy     HH:mm:ss
        private void RandevuOlusturHatasi(Exception hata)
        {
            MessageBox.Show("Hata:" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        BusinessOperations businessOperations = new BusinessOperations();

        private void RandevuOlustur_Load(object sender, EventArgs e)
        {
            try
            {
                textBox_hastaAdi.Focus();
                dateTimePicker_randevuTarihi.MinDate = DateTime.Today;
                businessOperations.branslariYukle(comboBox_hastaBransi);
            }
            catch(Exception hata)
            {
                RandevuOlusturHatasi(hata);
            }
            
        }

        private void comboBox_hastaBransi_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_hastaDoktoru.SelectedIndex = -1;
            try
            {
                businessOperations.doktorlariYukle(Convert.ToByte(comboBox_hastaBransi.SelectedValue), comboBox_hastaDoktoru);
            }
            catch(Exception hata)
            {
                RandevuOlusturHatasi(hata);
            }
            
        }

        private void button_randevuOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                string hastaAdi = textBox_hastaAdi.Text;
                string hastaSoyadi = textBox_hastaSoyadi.Text;
                string cinsiyet = null;
                if (radioButton_erkek.Checked == true)
                    {
                        cinsiyet = "erkek";
                    }
                else if(radioButton_kadin.Checked == true)
                {
                    cinsiyet = "kadin";
                }
                else
                {
                    MessageBox.Show("Cinsiyet seçmediniz");
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
                    businessOperations.randevuOlustur(hastaAdi, hastaSoyadi, cinsiyet, hastaYasi, hastaBransi, hastaDoktoru, randevuTarihi);

                    MessageBox.Show("Randevu Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizle();
                }
            }
            catch(Exception hata)
            {
                RandevuOlusturHatasi(hata);
            }
        }

        private void temizle()
        {
            textBox_hastaAdi.Clear();
            textBox_hastaSoyadi.Clear();
            radioButton_erkek.Checked = false;
            radioButton_kadin.Checked = false;
            textBox_hastaYasi.Clear();
            textBox_hastaAdi.Focus();
        }

        private void button_randevuOlustur_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button_randevuOlustur_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        
    }
}
