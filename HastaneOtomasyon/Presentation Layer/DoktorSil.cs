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
    public partial class DoktorSil : Form
    {
        public DoktorSil()
        {
            InitializeComponent();
        }

        BusinessOperations businessOperations = new BusinessOperations();

        public void doktorSilHatasi(Exception hata)
        {
            MessageBox.Show("Hata:" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DoktorSil_Load(object sender, EventArgs e)
        {
            try
            {
                businessOperations.doktorlariYukle(dataGridView_mevcutDoktorlar);
                businessOperations.satirSayisi(dataGridView_mevcutDoktorlar, label_adet);
            }
            catch(Exception hata)
            {
                doktorSilHatasi(hata);
            }
        }

        private void dataGridView_mevcutDoktorlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_doktorId.Text = dataGridView_mevcutDoktorlar.CurrentRow.Cells[0].Value.ToString();
            textBox_doktorAdSoyad.Text = dataGridView_mevcutDoktorlar.CurrentRow.Cells[1].Value.ToString();
        }

        private void button_doktorEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_doktorId.Text);


                if (id.ToString().Trim().Equals(""))
                {
                    MessageBox.Show("Seçim yaptığınızdan emin olun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    businessOperations.doktorSil(id);
                    businessOperations.doktorlariYukle(dataGridView_mevcutDoktorlar);
                    businessOperations.satirSayisi(dataGridView_mevcutDoktorlar, label_adet);
                    MessageBox.Show("Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizle();
                    
                }
            }

            catch(Exception hata)
            {
                doktorSilHatasi(hata);
            }
        }

        private void temizle()
        {
            textBox_doktorId.Clear();
            textBox_doktorAdSoyad.Clear();
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
