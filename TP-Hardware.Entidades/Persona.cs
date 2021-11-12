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

        public Persona(string Nombre)
        {
            this._nombre = Nombre;
        }

        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }
    }
}
