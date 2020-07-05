using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neo4jUI {

    //Tanto a printGreeting como a InserirNo funcionam
    public class DBconnectDriver : IDisposable {
        private readonly IDriver _driver;
        private IAsyncSession session;
        private IResultCursor cursor;
        public string greetingPu;
        public IResultSummary resultado;

        public DBconnectDriver(string user, string password) {
            _driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic(user, password));
        }

        public async Task CriarUniqueAsync() {
            session = _driver.AsyncSession(o => o.WithDatabase("neo4j"));//Nome da database está nas propriedades como padrão

            try {
                cursor = await session.RunAsync("CREATE CONSTRAINT anilhaC ON (p:Passaro) ASSERT p.anilha IS UNIQUE");

                await cursor.ConsumeAsync();

            }
            finally {
                await session.CloseAsync();
            }
        }

        public async Task InserirNoAsync(string nome, string anilha) {
            session = _driver.AsyncSession(o => o.WithDatabase("neo4j"));//Nome da database está nas propriedades como padrão

            try {
                cursor = await session.RunAsync("CREATE (p:Passaro{nome:$nome, anilha:$anilha})", new { nome, anilha });

                await cursor.ConsumeAsync();

            }
            finally {
                await session.CloseAsync();
            }
        }

        public async Task DefinirPaisAsync(string filho, string aniFilho, string pai, string aniPai, string mae, string aniMae) {
            session = _driver.AsyncSession(o => o.WithDatabase("neo4j"));//Nome da database está nas propriedades como padrão

            try {
                cursor = await session.RunAsync("MATCH (f:Passaro {nome: $filho, anilha:$aniFilho})" +
                                            "MATCH (p:Passaro {nome: $pai, anilha:$aniPai})" +
                                            "MATCH (m:Passaro {nome: $mae, anilha:$aniMae})" +
                                            "WHERE NOT (:Passaro)-[:PAI]->(f)<-[:MAE]-(:Passaro)" +
                                            "MERGE (p)-[:PAI]->(f)<-[:MAE]-(m)", new { filho, aniFilho, pai, aniPai, mae, aniMae });

                resultado = await cursor.ConsumeAsync();

                //var valor = cursor.Current.Values;
            }
            finally {
                await session.CloseAsync();
            }

        }

        public async Task ProcurarFamilia(string filho, string aniFilho) { //Testar essa função
            session = _driver.AsyncSession(o => o.WithDatabase("neo4j"));//Nome da database está nas propriedades como padrão
            try {
                cursor = await session.RunAsync("MATCH(p:Passaro{nome: $filho, anilha:$aniFilho})-[:MAE|PAI]-(p2:Passaro)" +
                                          "MATCH(p2:Passaro)-[:MAE|PAI]-(p3:Passaro)" +
                                          "MATCH(p3:Passaro)-[:MAE|PAI]-(p4:Passaro)" +
                                          "RETURN p,p2,p3,p4", new { filho, aniFilho });

                resultado = await cursor.ConsumeAsync();

            }
            finally {
                await session.CloseAsync();
            }
        }

        public async Task PrintGreetingAsync(string message) {
            var session = _driver.AsyncSession();
            try {
                var greeting = await session.WriteTransactionAsync(async tx => {
                    var result = await tx.RunAsync("CREATE (a:Greeting) " +
                                                   "SET a.message = $message " +
                                                   "RETURN a.message + ', from node ' + id(a)",
                        new { message });

                    return (await result.SingleAsync())[0].As<string>();
                });
                greetingPu = greeting;
            }
            finally {
                await session.CloseAsync();
            }
        }

        public void Dispose() {
            _driver?.Dispose();
        }
    }
}

//Melhorar a segurança https://neo4j.com/docs/operations-manual/4.1/security/ssl-framework/