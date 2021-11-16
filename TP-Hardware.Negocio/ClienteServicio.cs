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

        public void AddCliente(Cliente cliente)
        {
            TransactionResult resultado = _clienteMapper.Agregar(cliente);

            if (resultado.IsOk == false)
                throw new Exception("No se pudo insertar el cliente. Motivo " + resultado.Error);
        }
    }
}
