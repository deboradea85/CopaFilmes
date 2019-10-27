using Newtonsoft.Json;
using System;

namespace Model
{
   
    public class FilmeModel
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }
        [JsonProperty(PropertyName = "titulo")]
        public string Titulo { get; private set; }

        [JsonProperty(PropertyName = "ano")]
        public int AnoLancamento { get; private set; }
        [JsonProperty(PropertyName = "nota")]
        public float Nota { get; private set; }
    }
}
