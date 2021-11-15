using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Hardware.Negocio;

namespace TP_Hardware.WinForm
{
    public partial class FrmConsultarClientes : Form
    {
        private ClienteServicio _clienteServicio;
        public FrmConsultarClientes(Form propietario)
        {
            _clienteServicio = new ClienteServicio();
            this.Owner = propietario;
            InitializeComponent();
        }

        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void FrmConsultarClientes_Load(object sender, EventArgs e)
        {
            CargarListaClientes();
        }

        private void CargarListaClientes()
        {
            _lstClientes.DataSource = null;
            _lstClientes.DataSource = _clienteServicio.GetClientes();
            _lstClientes.DisplayMember = "Mostrar";
            _lstClientes.ValueMember = "DNI";
        }
    }
}
