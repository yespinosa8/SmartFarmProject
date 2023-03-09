using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFarmProyect
{
    public partial class FrmControlPanel : Form
    {
        public FrmControlPanel()
        {
            InitializeComponent();
        }

        private void btnAnimales_Click(object sender, EventArgs e)
        {
            FrmAnimales frm = new FrmAnimales();

            frm.Show();

        }

        private void btnPlantas_Click(object sender, EventArgs e)
        {
            FrmPlantas frm = new FrmPlantas();

            frm.Show();


        }

    }
}
