using Data;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class FilmeBusiness
    {
        public List<FilmeModel> ListarFilmes()
        {
            return new FilmeData().ListarFilmes().Result;
        }
    }
}
