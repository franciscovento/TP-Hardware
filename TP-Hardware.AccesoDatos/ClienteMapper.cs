using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Hardware.Entidades;
using Newtonsoft.Json;
using System.Collections.Specialized;

namespace TP_Hardware.AccesoDatos
{
    public class ClienteMapper
    {
        private List<Cliente> _clientes;

        public ClienteMapper()
        {

        }

        public List<Cliente> TraerClientes()
        {
            string docentesHTTP = WebHelper.Get("cliente");
            _clientes = MapList(docentesHTTP);
            return _clientes;
        }

        private List<Cliente> MapList(string json)
        {
            List<Cliente> req = JsonConvert.DeserializeObject<List<Cliente>>(json);
            return req;
        }

        public TransactionResult Agregar(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);

            string json = WebHelper.Post("cliente", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("DNI", Convert.ToString(cliente.DNI));
            n.Add("Nombre", cliente.Nombre);
            n.Add("Apellido", cliente.Apellido);
            n.Add("Direccion", cliente.Direccion);
            n.Add("Email", cliente.Email);
            n.Add("Telefono", cliente.Telefono);
            n.Add("FechaNacimiento", Convert.ToString(cliente.FNacimiento));
            n.Add("FechaAlta", Convert.ToString(DateTime.Now));
            n.Add("Activo", "false");
            n.Add("Usuario", Convert.ToString(892789));
         
          
            return n;
        }
    }
}
