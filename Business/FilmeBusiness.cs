using Data;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class FilmeBusiness
    {
        private static List<FilmeModel> filmesDisponiveis;
        public List<FilmeModel> ListarFilmes()
        {
            return new FilmeData().ListarFilmes().Result;
        }
        public List<FilmeModel> DefinirVencedor(string[] filmes)
        {
            filmesDisponiveis = ListarFilmes();
            List<FilmeModel> filmesCampeonato;
            List<FilmeModel> filmesClassificados;
            List<FilmeModel> filmesFinalistas;
            if (filmesDisponiveis != null && filmesDisponiveis.Count >=8)
            {
                if (ValidarFilmesSelecionados(filmes))
                {
                    filmesCampeonato = filmesDisponiveis.Where(f => filmes.Contains(f.Id)).OrderBy(f => f.Titulo).ToList();

                    filmesClassificados = DefinirClassificados(filmesCampeonato);

                    filmesFinalistas = DefinirFinalistas(filmesClassificados);

                    return DefinirCampeoes(filmesFinalistas);
                }
                else
                {
                    throw new Exception("Quantidade de filmes inválida. Para realizar o campeonato são necessários 8 filmes");
                }
            }
            else
            {
                throw new Exception("Nem todos os filmes estão disponíveis!");
            }
        }

        private List<FilmeModel> DefinirClassificados(List<FilmeModel> filmesCampeonato)
        {
            if (filmesCampeonato != null && filmesCampeonato.Count == 8)
            {
                List<FilmeModel> Classificados = new List<FilmeModel>();
                Classificados.Add(new PartidaModel(filmesCampeonato[0], filmesCampeonato[7]).Vencedor);
                Classificados.Add(new PartidaModel(filmesCampeonato[1], filmesCampeonato[6]).Vencedor);
                Classificados.Add(new PartidaModel(filmesCampeonato[2], filmesCampeonato[5]).Vencedor);
                Classificados.Add(new PartidaModel(filmesCampeonato[3], filmesCampeonato[4]).Vencedor);
                return Classificados;
            }
            else
            {
                throw new Exception("Para Iniciar o campeonato são necessários 8 filmes!");
            }      
        }

        private List<FilmeModel> DefinirFinalistas(List<FilmeModel> filmesClassificados)
        {
            if (filmesClassificados != null && filmesClassificados.Count == 4)
            {
                List<FilmeModel> Finalistas = new List<FilmeModel>();
                Finalistas.Add(new PartidaModel(filmesClassificados[0], filmesClassificados[1]).Vencedor);
                Finalistas.Add(new PartidaModel(filmesClassificados[2], filmesClassificados[3]).Vencedor);
                return Finalistas;
            }
            else
            {
                throw new Exception("Para esta fase do Campeonato são necessários 4 filmes!");
            }
        }
        private List<FilmeModel> DefinirCampeoes(List<FilmeModel> filmesFinalistas)
        {
            if (filmesFinalistas != null && filmesFinalistas.Count == 2)
            {
                return new PartidaModel(filmesFinalistas[0], filmesFinalistas[1]).Classificacao;
            }
            else
            {
                throw new Exception("Para esta fase do Campeonato são necessários 2 filmes!");
            }
        }
        private bool ValidarFilmesSelecionados(string[] filmes)
        {
            if (filmes != null && filmes.Distinct().ToList().Count == 8)
            {
                return filmesDisponiveis.Where(f => filmes.Contains(f.Id)).ToList().Count == 8;
            }
            else
            {
                return false;
            }
        }
    }
}
