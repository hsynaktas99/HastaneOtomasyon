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
    public partial class BranslaraGoreRandevuSayisi : Form
    {
        public BranslaraGoreRandevuSayisi()
        {
            InitializeComponent();
        }
        BusinessOperations businessOperations = new BusinessOperations();

        private void branslaraGoreRandevuSayisiHatasi(Exception hata)
        {
            MessageBox.Show("Hata:" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BranslaraGoreRandevuSayisi_Load(object sender, EventArgs e)
        {
            try
            {
                businessOperations.branslaraGoreRandevuSayisi(chart1);
            }
            catch(Exception hata)
            {
                branslaraGoreRandevuSayisiHatasi(hata);
            }
        }
    }
}
