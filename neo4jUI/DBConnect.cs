using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neo4jClient;
using Neo4jClient.Cypher;

namespace neo4jUI {

    internal class DBConnect {
        private GraphClient client;

        public DBConnect() {
            client = new GraphClient(new Uri("http://localhost:7474/db/data"));
            client.Connect();
        }

        public DBConnect(string usuario, string senha) {
            client = new GraphClient(new Uri("http://localhost:7474/db/data"), usuario, senha); ;
            client.Connect();
        }

        public IEnumerable<Passaro> BuscaPassaro(string nome, string registro) {
            var passaros = client.Cypher
                  .Match("(p:Passaro{$nome})")
                  .Return(m => m.As<Passaro>())
                  .Limit(10)
                  .Results;
            return passaros;
        }

    }
}