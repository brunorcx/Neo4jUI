using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neo4jUI {

    internal class Passaro {

        [JsonProperty(PropertyName = "Nome")]
        public string Nome { get; set; }

        [JsonProperty(PropertyName = "Registro")]
        public int Registro { get; set; }

        [JsonProperty(PropertyName = "Sexo")]
        public string Sexo { get; set; }
    }
}