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
    public partial class RandevuSil : Form
    {
        public RandevuSil()
        {
            InitializeComponent();
        }

        BusinessOperations businessOperations = new BusinessOperations();

        private void randevuSilHatasi(Exception hata)
        {
            MessageBox.Show("Hata:"+hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RandevuSil_Load(object sender, EventArgs e)
        {
            try
            {
                businessOperations.randevulariYukle(dataGridView_randevular);
                businessOperations.satirSayisi(dataGridView_randevular,label_adet);
            }

            catch(Exception hata)
            {
                randevuSilHatasi(hata);
            }
        }

        private void temizle()
        {
            textBox_randevuId.Clear();
            textBox_randevuSahibi.Clear();
        }

        private void button_randevuSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_randevuId.Text);
                businessOperations.randevuSil(id);
                MessageBox.Show("Randevu Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                businessOperations.randevulariYukle(dataGridView_randevular);
                businessOperations.satirSayisi(dataGridView_randevular, label_adet);
                temizle();
            }
            catch(Exception hata)
            {
                randevuSilHatasi(hata);
            }
        }

        private void dataGridView_randevular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_randevuId.Text = dataGridView_randevular.CurrentRow.Cells[0].Value.ToString();
            textBox_randevuSahibi.Text = dataGridView_randevular.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView_randevular.CurrentRow.Cells[2].Value.ToString();
        }

        private void button_randevuSil_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button_randevuSil_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
