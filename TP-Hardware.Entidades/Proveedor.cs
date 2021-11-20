using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Hardware.Entidades
{
    public class Proveedor
    {
        private int idProducto;
        private string nombre;
        private string apellido;
        private string email;
        private string cuit;
        private bool activo;
        private DateTime fechaAlta;
        private DateTime fechaBaja;
        private int usuario;
        private int id;

        public Proveedor()
        {
        }

        public Proveedor(int idProducto, string nombre, string apellido, string email, string cuit, bool activo, DateTime fechaAlta, DateTime fechaBaja, int usuario, int id)
        {
            this.idProducto = idProducto;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.cuit = cuit;
            this.activo = activo;
            this.fechaAlta = fechaAlta;
            this.fechaBaja = fechaBaja;
            this.usuario = usuario;
            this.id = id;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Email { get => email; set => email = value; }
        public string Cuit { get => cuit; set => cuit = value; }
        public bool Activo { get => activo; set => activo = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public DateTime FechaBaja { get => fechaBaja; set => fechaBaja = value; }
        public int Usuario { get => usuario; set => usuario = value; }
        public int Id { get => id; set => id = value; }
    }
}
