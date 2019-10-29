using CopaDeFilmes.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopaDeFilmes.Test
{
    internal static class FilmesMock
    {
        internal const int QuantidadeTotalFilmes = 16;

        internal static FilmeModel FilmeVencedor1 = new FilmeModel("tt4154756", "Vingadores: Guerra Infinita", 2018, 8.8F);
        internal static FilmeModel FilmeVencedor2 = new FilmeModel("tt3606756", "Os Incríveis 2", 2018, 8.5F);

        internal static List<FilmeModel> FilmesVencedores()
        {
            List<FilmeModel> filmes = new List<FilmeModel>();
            filmes.Add(new FilmeModel("tt4154756", "Vingadores: Guerra Infinita", 2018, 8.8F));
            filmes.Add(new FilmeModel("tt3606756", "Os Incríveis 2", 2018, 8.5F));
            return filmes;
        }

        internal static string[] FilmesCasoTeste()
        {
            return new[] { "tt3606756", "tt4881806", "tt5164214", "tt7784604", "tt4154756", "tt5463162", "tt3778644", "tt3501632" };
        }
    }
}
