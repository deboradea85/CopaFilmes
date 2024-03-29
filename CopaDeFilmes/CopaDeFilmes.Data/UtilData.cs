﻿using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CopaDeFilmes.Data
{
    public class UtilData
    {
        private static HttpClientHandler clientHandler = new HttpClientHandler();
        private static HttpClient client;
        public async Task<string> GetAll(string urlBase, string api)
        {
            if (string.IsNullOrWhiteSpace(urlBase) || string.IsNullOrWhiteSpace(api))
            {
                throw new ArgumentException("Favor verificar Parâmetros enviados");
            }

            using (client = new HttpClient(clientHandler, false))
            {
                client.BaseAddress = new Uri(urlBase);
                HttpResponseMessage resposta = await client.GetAsync(api);

                if (resposta.IsSuccessStatusCode)
                {
                    return await resposta.Content.ReadAsStringAsync();
                }
                else
                {
                    throw new HttpRequestException("Erro ao Obter Dados.");
                }
            }
        }
    }
}
