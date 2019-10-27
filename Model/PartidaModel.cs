using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class PartidaModel
    {
        public PartidaModel(FilmeModel competidor1, FilmeModel competidor2)
        {
            Competidor1  =competidor1;
            Competidor2 =competidor2;
            ResultadoPartida();
        }
        public FilmeModel Competidor1 { get; private set; }
        public FilmeModel Competidor2 { get; private set; }
        public FilmeModel Vencedor { get; private set; }

        public List<FilmeModel> Classificacao { get; private set; }

        private void ResultadoPartida()
        {
            List<FilmeModel> competicao = new List<FilmeModel>();
            competicao.Add(Competidor1);
            competicao.Add(Competidor2);
            Classificacao = competicao.OrderByDescending(c => c.Nota).ThenBy(a => a.Titulo).ToList();
            Vencedor = Classificacao[0];
        }
    }
}
