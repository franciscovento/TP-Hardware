using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Hardware.Entidades
{
    public abstract class Persona
    {
        private int _dni;
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private string _email;
        private string _telefono;
        private DateTime _fechaNacimiento;
        public Persona(int DNI, string Nombre, string Apellido, string Direccion, string Email, string Telefono, DateTime FechaNacimiento)
        {
            this._dni = DNI;
            this._nombre = Nombre;
            this._apellido = Apellido;
            this._direccion = Direccion;
            this._email = Email;
            this._telefono = Telefono;
            this._fechaNacimiento = FechaNacimiento;
        }

        public int DNI
        {
            get => _dni;
            set => _dni = value;
        }

        public override string ToString()
        {
            return $"{this._apellido}, {this._nombre}";
        }

    }
}
