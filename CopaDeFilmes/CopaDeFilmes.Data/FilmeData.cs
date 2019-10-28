using CopaDeFilmes.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CopaDeFilmes.Data
{
    public class FilmeData
    {
        private static string urlBase = "https://copadosfilmes.azurewebsites.net";
        private static string api = "/api/filmes";

        public async Task<List<FilmeModel>> ListarFilmes()
        {
            return JsonConvert.DeserializeObject<List<FilmeModel>>(await new UtilData().GetAll(urlBase, api));
        }
    }
}