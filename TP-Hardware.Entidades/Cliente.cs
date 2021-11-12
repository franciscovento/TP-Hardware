using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Hardware.Entidades
{
    public class Cliente: Persona
    {
        private int _documento;
        private DateTime _fNacimiento;



        public Cliente(int Documento, DateTime FNacimiento, string Nombre ):base(Nombre)
        {
            this._documento = Documento;
            this._fNacimiento = FNacimiento;
        }
    }
}
