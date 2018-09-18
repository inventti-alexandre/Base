using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace PedroH.Software.Desenvolvimento.APIs.ClimaTempo
{
    class ClimaModel
    {
        //public ClimaResponse ClimaCidade(string cidade)
        //{
            
        //}

        private List<ClimaResponse.Clima> BuscarApiAdvisorCidade(string cidade)
        {
            // Cria objeto responsável por conversar com uma API
            WebClient rest = new WebClient();
            rest.Encoding = Encoding.UTF8;

            // Chama API do Advisor, concatenando a cidade
            string resposta = rest.DownloadString($"http://apiadvisor.climatempo.com.br/api/v1/locale/city?name={cidade}&token=af3bea8ad6576d9b0c3064024edcd746");

            // Transforma a resposta do Climatempo em lista de DTO
            List <ClimaResponse.Clima> cidades = JsonConvert.DeserializeObject<List<ClimaResponse.Clima>>(resposta);
            return cidades;
        }
    }
}
