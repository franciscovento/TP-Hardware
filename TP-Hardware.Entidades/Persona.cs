using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Hardware.Entidades
{
    public abstract class Persona
    {
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private string _email;
        private int _telefono;
        private DateTime _fechaNacimiento;
        public Persona(string Nombre, string Apellido, string Direccion, string Email, int Telefono, DateTime FechaNacimiento)
        {
            this._nombre = Nombre;
            this._apellido = Apellido;
            this._direccion = Direccion;
            this._email = Email;
            this._telefono = Telefono;
            this._fechaNacimiento = FechaNacimiento;
        }

     
    }
}
