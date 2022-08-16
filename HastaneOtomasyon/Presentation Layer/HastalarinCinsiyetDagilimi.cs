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
    public partial class HastalarinCinsiyetDagilimi : Form
    {
        public HastalarinCinsiyetDagilimi()
        {
            InitializeComponent();
        }

        BusinessOperations businessOperations = new BusinessOperations();

        private void hastalarinCinsiyetDagilimiHatasi(Exception hata)
        {
            MessageBox.Show("Hata:" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void HastalarinCinsiyetDagilimi_Load(object sender, EventArgs e)
        {
            try
            {
                businessOperations.hastalarinCinsiyetDagilimi(chart1);
            }
            catch(Exception hata)
            {
                hastalarinCinsiyetDagilimiHatasi(hata);
            }
        }
    }
}
