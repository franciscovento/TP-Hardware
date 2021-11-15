using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Hardware.Entidades
{
    public class Cliente: Persona
    {
        private DateTime _fechaAlta;
        private bool _activo;


        public Cliente(DateTime FechaAlta, bool Activo, int DNI, string Nombre, string Apellido, string Direccion, string Email, string Telefono, DateTime FechaNacimiento):base(DNI, Nombre, Apellido, Direccion, Email, Telefono, FechaNacimiento)
        {
            this._fechaAlta = FechaAlta;
            this._activo = Activo;
        }

        public bool Activo
        {
            get => _activo;
            set => _activo = value;
        }

        public string Mostrar
        {
            get
            {
                return $"{this.DNI} - {this.ToString()}";
            }
        }
    }
}
