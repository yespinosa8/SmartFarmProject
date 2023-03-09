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
    public partial class FrmPlantas : Form
    {
        public FrmPlantas()
        {
            InitializeComponent();
        }

        private void Plant1_Click(object sender, EventArgs e)
        {

        }

        private void btnSimulaClima_Click(object sender, EventArgs e)
        {
            Random  aleatorio = new Random();
            lblCantHumedad.Text =  aleatorio.Next(0, 100).ToString();
            LblCantTemperatura.Text = aleatorio.Next(-60, 100).ToString();
        }
    }
}
