using Newtonsoft.Json;
using System;

namespace Model
{
   
    public class FilmeModel
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get;  set; }
        [JsonProperty(PropertyName = "titulo")]
        public string Titulo { get;  set; }

        [JsonProperty(PropertyName = "ano")]
        public int AnoLancamento { get;  set; }
        [JsonProperty(PropertyName = "nota")]
        public float Nota { get;  set; }
    }
}
