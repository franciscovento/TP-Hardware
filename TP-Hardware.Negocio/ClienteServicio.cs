using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Hardware.AccesoDatos;
using TP_Hardware.Entidades;

namespace TP_Hardware.Negocio
{
    public class ClienteServicio
    {
        private ClienteMapper _clienteMapper;
        
        public ClienteServicio()
        {
            _clienteMapper = new ClienteMapper();
        }

        public List<Cliente> GetClientes()
        {
            return _clienteMapper.TraerClientes();
        }
    }
}
