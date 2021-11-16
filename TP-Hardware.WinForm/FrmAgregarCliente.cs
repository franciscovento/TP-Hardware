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
    public partial class FrmAgregarCliente : Form
    {
        private ClienteServicio _clienteServicio;
        public FrmAgregarCliente(Form propietario)
        {
            _clienteServicio = new ClienteServicio();
            this.Owner = propietario;
            InitializeComponent();
        }

        private void _btnAgregarCliente_Click(object sender, EventArgs e)
        {
            string msj = "";
            Validaciones(ref msj);


            if (msj == "")
            {
                Cliente c1 = new Cliente(DateTime.Now, false, Convert.ToInt32(_txtDNI.Text), _txtNombre.Text, _txtApellido.Text, _txtDireccion.Text, _txtEmail.Text, _txtTelefono.Text, DateTime.Now);
                _clienteServicio.AddCliente(c1);

            LimpiarCampos();
            this.Hide();
            this.Owner.Show();
            }
        }

        private void Validaciones(ref string msj)
        {
            
            msj += ValidarDatos.ValidarVacio(_txtNombre.Text, "nombre");
            msj += ValidarDatos.ValidarVacio(_txtApellido.Text, "apellido");
            msj += ValidarDatos.ValidarNumero(_txtDNI.Text, "DNI");
            msj += ValidarDatos.ValidarVacio(_txtDireccion.Text, "dirección");
            msj += ValidarDatos.ValidarVacio(_txtEmail.Text, "email");
            msj += ValidarDatos.ValidarVacio(_txtTelefono.Text, "telefono");

            if (msj != "")
            {
                MessageBox.Show(msj, "Error");
            }
        }


        private void LimpiarCampos()
        {
            _txtNombre.Clear();
            _txtApellido.Clear();
            _txtDNI.Clear();
            _txtDireccion.Clear();
            _txtEmail.Clear();
            _txtTelefono.Clear();
        }

        private void _bntVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
    }
}
