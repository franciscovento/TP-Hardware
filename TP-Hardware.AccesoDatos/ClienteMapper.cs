using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Hardware.Entidades;
using Newtonsoft.Json;

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
    }
}
