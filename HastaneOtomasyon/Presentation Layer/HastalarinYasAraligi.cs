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
    public partial class HastalarinYasAraligi : Form
    {
        public HastalarinYasAraligi()
        {
            InitializeComponent();
        }

        BusinessOperations businessOperations = new BusinessOperations();

        private void hastalarinYasAraligiHatasi(Exception hata)
        {
            MessageBox.Show("Hata:" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void HastalarinYasAraligi_Load(object sender, EventArgs e)
        {
            try
            {
                businessOperations.hastalarinYasAraligi(chart1);
            }
            catch(Exception hata)
            {
                hastalarinYasAraligiHatasi(hata);
            }
        }
    }
}
