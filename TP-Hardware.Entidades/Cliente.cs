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


        public Cliente(DateTime FechaAlta, bool Activo, string Nombre, string Apellido, string Direccion, string Email, int Telefono, DateTime FechaNacimiento):base(Nombre, Apellido, Direccion, Email, Telefono, FechaNacimiento)
        {
            this._fechaAlta = FechaAlta;
            this._activo = Activo;
        }
    }
}
