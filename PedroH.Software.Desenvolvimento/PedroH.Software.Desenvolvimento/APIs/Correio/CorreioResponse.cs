using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedroH.Software.Desenvolvimento.APIs.Correio
{
    class CorreioResponse
    {
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Localidade { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string UF { get; set; }
    }
}
