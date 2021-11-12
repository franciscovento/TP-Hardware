using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Hardware.WinForm
{
    public partial class FrmConsultarVentas : Form
    {
        public FrmConsultarVentas(Form propietario)
        {
            this.Owner = propietario;
            InitializeComponent();
        }

        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
    }
}
