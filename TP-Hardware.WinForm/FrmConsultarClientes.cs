using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Hardware.Entidades;
using TP_Hardware.Negocio;

namespace TP_Hardware.WinForm
{
    public partial class FrmConsultarClientes : Form
    {
        private ClienteServicio _clienteServicio;
        private FrmAgregarCliente _formAgregarCliente;
        public FrmConsultarClientes(Form propietario)
        {
            _formAgregarCliente = new FrmAgregarCliente(this);
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

        private void button1_Click(object sender, EventArgs e)
        {
            _formAgregarCliente.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarListaClientes();
        }

        private void _btnBuscarCliente_Click(object sender, EventArgs e)
        {
            int salida;
            if (_txtBuscarCliente.Text == "" || (!Int32.TryParse(_txtBuscarCliente.Text, out salida )))
            {
                MessageBox.Show("El campo debe ser númerico y no debe estar vacío", "Error");
            }

            List<Cliente> c = _clienteServicio.GetClientes().FindAll(x => x.DNI == Convert.ToInt32(_txtBuscarCliente.Text));

            if (c.Count > 0)
            {
                _lstClientes.DataSource = null;
                _lstClientes.DataSource = c;
                _lstClientes.DisplayMember = "Mostrar";
                _lstClientes.ValueMember = "DNI";
                _txtBuscarCliente.Clear();
            }
            else
            {
                MessageBox.Show("No existen clientes con ese documento", "Error");
            }
           
        }
    }
}
