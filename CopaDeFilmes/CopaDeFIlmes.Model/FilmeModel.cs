using Newtonsoft.Json;

namespace CopaDeFilmes.Model
{

    public class FilmeModel
    {
        public FilmeModel(string id, string titulo, int anoLancamento, float nota)
        {
            Id = id;
            Titulo = titulo;
            AnoLancamento = anoLancamento;
            Nota = nota;
        }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "titulo")]
        public string Titulo { get; set; }

        [JsonProperty(PropertyName = "ano")]
        public int AnoLancamento { get; set; }
        [JsonProperty(PropertyName = "nota")]
        public float Nota { get; set; }
    }
}
