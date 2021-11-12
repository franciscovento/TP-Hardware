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
    public partial class FrmMaster : Form
    {
        private FrmConsultarClientes _formConsultarClientes;
        private FrmConsultarProductos _formConsultarProductos;
        private FrmConsultarVentas _formConsultarVentas;
        private FrmConsultarProveedores _formConsultarProveedores;
        public FrmMaster()
        {
            _formConsultarProductos = new FrmConsultarProductos(this);
            _formConsultarClientes = new FrmConsultarClientes(this);
            _formConsultarVentas = new FrmConsultarVentas(this);
            _formConsultarProveedores = new FrmConsultarProveedores(this);
            InitializeComponent();
        }

        private void ButtonMainSender(object sender, EventArgs e)
        {
            this.Hide();
            if ((Button)sender == _btnConsultarProductos)
                _formConsultarProductos.Show();
            if ((Button)sender == _btnConsultarClientes)
                _formConsultarClientes.Show();
            if ((Button)sender == _btnConsultarVentas)
                _formConsultarVentas.Show();
            if ((Button)sender == _btnConsultarProv)
                _formConsultarProveedores.Show();
        }

       
    } 
}
