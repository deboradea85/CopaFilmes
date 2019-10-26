using System;

namespace Model
{
   
    public class FilmeModel
    {
        public FilmeModel(string id, string titulo, int anoLancamento, float nota)
        {
            this.id = id;
            this.titulo = titulo;
            this.anoLancamento = anoLancamento;
            this.nota = nota;
        }
        public string id { get; private set; }
       public string titulo { get; private set; }
       public int anoLancamento { get; private set; }
       public float nota { get; private set; }
    }
}
