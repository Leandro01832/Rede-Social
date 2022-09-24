using business.Back;
using business.business.Elementos.element;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace business.business.Elementos
{
    public class Video : Elemento
    {
        public string ArquivoVideo { get; set; }
        [JsonIgnore]
        public virtual List<BackgroundDiv> BackgroundDiv { get; set; }
        [JsonIgnore]
        public virtual List<BackgroundContainer> BackgroundContainer { get; set; }
        [JsonIgnore]
        public virtual List<BackgroundElemento> BackgroundElemento { get; set; }
    }
}
