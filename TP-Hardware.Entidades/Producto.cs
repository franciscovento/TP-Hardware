using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Hardware.Entidades
{
    public abstract class Producto
    {
        private int idCategoria;
        private string nombre;
        private int stock;
        private int proveedor;
        private int precio;
        private DateTime fechaAlta;
        private int usuario;
        private int id;

        protected Producto()
        {
        }

        protected Producto(int idCategoria, string nombre, int stock, int proveedor, int precio, DateTime fechaAlta, int usuario, int id)
        {
            IdCategoria = idCategoria;
            Nombre = nombre;
            Stock = stock;
            Proveedor = proveedor;
            Precio = precio;
            FechaAlta = fechaAlta;
            Usuario = usuario;
            Id = id;
        }
        protected int Id { get => id; set => id = value; }
        protected int IdCategoria { get => idCategoria; set => idCategoria = value; }
        protected string Nombre { get => nombre; set => nombre = value; }
        protected int Stock { get => stock; set => stock = value; }
        protected int Proveedor { get => proveedor; set => proveedor = value; }
        protected int Precio { get => precio; set => precio = value; }
        protected DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        protected int Usuario { get => usuario; set => usuario = value; }
    }
}
