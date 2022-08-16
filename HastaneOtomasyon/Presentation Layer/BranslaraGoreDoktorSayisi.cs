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
    public partial class BranslaraGoreDoktorSayisi : Form
    {
        public BranslaraGoreDoktorSayisi()
        {
            InitializeComponent();
        }

        BusinessOperations businessOperations = new BusinessOperations();

        private void branslaraGoreDoktorSayisiHatasi(Exception hata)
        {
            MessageBox.Show("Hata:" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BranslaraGoreDoktorSayisi_Load(object sender, EventArgs e)
        {
            try
            {
                businessOperations.branslaraGoreDoktorSayisi(chart1);
            }
            catch(Exception hata)
            {
                branslaraGoreDoktorSayisiHatasi(hata);
            }
        }
    }
}
