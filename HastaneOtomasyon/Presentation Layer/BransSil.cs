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
    public partial class BransSil : Form
    {
        public BransSil()
        {
            InitializeComponent();
        }
        BusinessOperations businessOperations = new BusinessOperations();

        private void bransSilmeHatasi(Exception hata)
        {
            MessageBox.Show("Hata:" + hata, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BransSil_Load(object sender, EventArgs e)
        {
            try
            {
                businessOperations.branslariListele(dataGridView_mevcutBranslar);
                businessOperations.satirSayisi(dataGridView_mevcutBranslar, label_adet);
            }
            catch(Exception hata)
            {
                bransSilmeHatasi(hata);
            }
        }

        private void temizle()
        {
            textBox_bransId.Clear();
            textBox_bransAdi.Clear();
        }

        private void dataGridView_mevcutBranslar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_bransId.Text = dataGridView_mevcutBranslar.CurrentRow.Cells[0].Value.ToString();
            textBox_bransAdi.Text = dataGridView_mevcutBranslar.CurrentRow.Cells[1].Value.ToString();
        }

        private void button_bransSil_Click(object sender, EventArgs e)
        {
            try
            {
                byte id = Convert.ToByte(textBox_bransId.Text);

                if (id.ToString().Trim().Equals(""))
                {
                    MessageBox.Show("Branş seçtiğinizden emin olun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    businessOperations.bransSil(id);
                    businessOperations.branslariListele(dataGridView_mevcutBranslar);
                    businessOperations.satirSayisi(dataGridView_mevcutBranslar, label_adet);
                    MessageBox.Show("Branş Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizle();
                }

            }
            catch(Exception hata)
            {
                bransSilmeHatasi(hata);
            }
        }

        private void button_bransSil_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button_bransSil_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
