using CopaDeFilmes.Model;
using CopaDeFilmesBusiness;
using DeepEqual.Syntax;
using System.Collections.Generic;
using Xunit;

namespace CopaDeFilmes.Test
{
    public class UnitTest
    {
        private FilmeBusiness business;
        [Fact]
        public void TestarApi()
        {
            business = new FilmeBusiness();
            List<FilmeModel> filmes = business.ListarFilmes();
            Assert.Equal(filmes.Count, FilmesMock.QuantidadeTotalFilmes);
        }
        [Fact]
        public void TestarListaVencedor()
        {
            business = new FilmeBusiness();
            List<FilmeModel> filmes = business.DefinirVencedor(FilmesMock.FilmesCasoTeste());
            //CollectionAssert.AreEqual(filmes, FilmesMock.FilmesVencedores());
            Assert.True(filmes.IsDeepEqual(FilmesMock.FilmesVencedores()));
        }
        [Fact]
        public void TestarVencedorPrimeiroLugar()
        {
            business = new FilmeBusiness();
            FilmeModel filme = business.DefinirVencedor(FilmesMock.FilmesCasoTeste())[0];
            Assert.True(filme.IsDeepEqual(FilmesMock.FilmeVencedor1));
        }
        [Fact]
        public void TestarVencedorSegundoLugar()
        {
            business = new FilmeBusiness();
            FilmeModel filme = business.DefinirVencedor(FilmesMock.FilmesCasoTeste())[1];
            Assert.True(filme.IsDeepEqual(FilmesMock.FilmeVencedor2));
        }
    }
}
