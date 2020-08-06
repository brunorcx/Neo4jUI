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
        private IResultSummary resultado;
        private List<IRecord> records;
        private List<string> familia;

        public IResultSummary GetResultado() {
            return this.resultado;
        }

        public List<string> GetFamilia() {
            return this.familia;
        }

        public List<IRecord> GetRecords() {
            return this.records;
        }

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

        public async Task InserirNoAsync(string nome, string anilha, string sexo, string nomePopular, string nascimento) {
            session = _driver.AsyncSession(o => o.WithDatabase("neo4j"));//Nome da database está nas propriedades como padrão

            string query = String.Empty;
            if (sexo != string.Empty)
                query += ",Sexo:" + "$sexo";
            if (nomePopular != string.Empty)
                query += ",NomePopular:" + "$nomePopular";
            if (nascimento != string.Empty)
                query += ",Nascimento:" + "$nascimento";

            try {
                if (anilha == string.Empty) {
                    cursor = await session.RunAsync("CREATE (p:Passaro{nome:$nome" + query + "})", new { nome, sexo, nomePopular, nascimento });//MERGE Impede cadastro de mesmo nome
                }
                else
                    cursor = await session.RunAsync("CREATE (p:Passaro{nome:$nome, anilha:$anilha" + query + "})", new { nome, anilha, sexo, nomePopular, nascimento });

                await cursor.ConsumeAsync();

            }
            finally {
                await session.CloseAsync();
            }
        }

        public async Task DefinirPaisAsync(string filho, string aniFilho, string pai, string aniPai, string mae, string aniMae, bool[] comAnilha) {
            session = _driver.AsyncSession(o => o.WithDatabase("neo4j"));//Nome da database está nas propriedades como padrão

            try {
                if (!comAnilha.All(anilhas => anilhas == true)) {//Expressão Lambda (entrada) => (corpo/condição)
                    string matchf = " MATCH(f: Passaro { nome: $filho, anilha:$aniFilho})";
                    string matchp = " MATCH(p: Passaro { nome: $pai, anilha:$aniPai})";
                    string matchm = " MATCH(m:Passaro  { nome: $mae, anilha:$aniMae})";
                    string where = " WHERE NOT (:Passaro)-[:PAI]->(f)<-[:MAE]-(:Passaro)";
                    string merge = " MERGE (p)-[:PAI]->(f)<-[:MAE]-(m)";

                    if (!comAnilha[0]) {
                        matchf = "MATCH (f:Passaro {nome: $filho})";
                        where += " and ID(f) = toInteger($aniFilho)";
                    }
                    if (!comAnilha[1]) {
                        matchp = "MATCH (p:Passaro {nome: $pai})";
                        where += " and ID(p) = toInteger($aniPai)";
                    }
                    if (!comAnilha[2]) {
                        matchm = "MATCH (m:Passaro {nome: $mae})";
                        where += " and ID(m) = toInteger($aniMae)";
                    }
                    cursor = await session.RunAsync(matchf + matchp + matchm + where + merge, new { filho, aniFilho, pai, aniPai, mae, aniMae });
                }
                else {
                    cursor = await session.RunAsync("MATCH (f:Passaro {nome: $filho, anilha:$aniFilho})" +
                                                "MATCH (p:Passaro {nome: $pai, anilha:$aniPai})" +
                                                "MATCH (m:Passaro {nome: $mae, anilha:$aniMae})" +
                                                "WHERE NOT (:Passaro)-[:PAI]->(f)<-[:MAE]-(:Passaro)" +
                                                "MERGE (p)-[:PAI]->(f)<-[:MAE]-(m)", new { filho, aniFilho, pai, aniPai, mae, aniMae });
                }
                resultado = await cursor.ConsumeAsync();
            }
            finally {
                await session.CloseAsync();
            }

        }

        public async Task ProcurarFamilia(string filho, string aniFilho, bool comAnilha) { //Testar essa função
            session = _driver.AsyncSession(o => o.WithDatabase("neo4j"));//Nome da database está nas propriedades como padrão
            try {
                string optMatch;
                string matchf;
                if (comAnilha) {
                    matchf = "MATCH (f:Passaro{nome:$filho, anilha:$aniFilho})" +
                             "OPTIONAL MATCH (f)<-[:PAI]-(p1:Passaro)" +
                             "OPTIONAL MATCH (m1:Passaro)-[:MAE]->(f)";
                }
                else {
                    matchf = "MATCH (f:Passaro{nome:$filho})" +
                             "WHERE ID(f) = toInteger($aniFilho)" +
                             "OPTIONAL MATCH (f)<-[:PAI]-(p1:Passaro)" +
                             "OPTIONAL MATCH (m1:Passaro)-[:MAE]->(f)";
                }
                optMatch =
                   "optional match(m2:Passaro)-[:MAE]->(p1) < -[:PAI] - (p2: Passaro)" +
                   "optional match(m3:Passaro)-[:MAE]->(m1) < -[:PAI] - (p3: Passaro)" +
                   "optional match(m4:Passaro)-[:MAE]->(p2) < -[:PAI] - (p4: Passaro)" +
                   "optional match(m5:Passaro)-[:MAE]->(m2) < -[:PAI] - (p5: Passaro)" +
                   "optional match(m6:Passaro)-[:MAE]->(p3) < -[:PAI] - (p6: Passaro)" +
                   "optional match(m7:Passaro)-[:MAE]->(m3) < -[:PAI] - (p7: Passaro)" +
                   "OPTIONAL MATCH(m8:Passaro)-[:MAE]->(p4) < -[:PAI] - (p8: Passaro)" +
                   "OPTIONAL MATCH(m9:Passaro)-[:MAE]->(m4) < -[:PAI] - (p9: Passaro)" +
                   "OPTIONAL MATCH(m10:Passaro)-[:MAE]->(p5) < -[:PAI] - (p10: Passaro)" +
                   "OPTIONAL MATCH(m11:Passaro)-[:MAE]->(m5) < -[:PAI] - (p11: Passaro)" +
                   "OPTIONAL MATCH(m12:Passaro)-[:MAE]->(p6) < -[:PAI] - (p12: Passaro)" +
                   "OPTIONAL MATCH(m13:Passaro)-[:MAE]->(m6) < -[:PAI] - (p13: Passaro)" +
                   "OPTIONAL MATCH(m14:Passaro)-[:MAE]->(p7) < -[:PAI] - (p14: Passaro)" +
                   "OPTIONAL MATCH(m15:Passaro)-[:MAE]->(m7) < -[:PAI] - (p15: Passaro)" +
                   "return [f.nome, p1.nome, m1.nome, p2.nome, m2.nome, p3.nome, m3.nome, " +
                   "p4.nome, m4.nome, p5.nome, m5.nome, p6.nome, m6.nome, p7.nome, m7.nome," +
                   "p8.nome, m8.nome, p9.nome, m9.nome, p10.nome, m10.nome, p11.nome, m11.nome," +
                   "p12.nome, m12.nome, p13.nome, m13.nome, p14.nome, m14.nome, p15.nome, m15.nome] AS familia";

                cursor = await session.RunAsync(matchf + optMatch, new { filho, aniFilho });

                records = await cursor.ToListAsync();

                familia = new List<string>();
                //familia.Add(aniFilho);
                //familia.Add(filho);
                familia = Records();
                resultado = await cursor.ConsumeAsync();
            }
            finally {
                await session.CloseAsync();
            }
        }

        public async Task<List<IRecord>> ProcurarPais(string nome, string anilha, bool comAnilha) {
            session = _driver.AsyncSession(o => o.WithDatabase("neo4j"));//Nome da database está nas propriedades como padrão

            try {
                if (!comAnilha) {
                    if (anilha != String.Empty) {
                        cursor = await session.RunAsync("MATCH (f:Passaro{nome:$nome})" +
                                              "WHERE ID(f) = toInteger($anilha) " +
                                              "OPTIONAL MATCH (m1:Passaro)-[:MAE]->(f)" +
                                              "OPTIONAL MATCH (f)<-[:PAI]-(p1:Passaro)" +
                                              "RETURN f,[f.nome] AS Nomes,[m1.nome] AS Maes,[p1.nome] AS Pais, [ID(f)] AS Ids", new { nome, anilha });
                    }
                    else
                        cursor = await session.RunAsync("MATCH (f:Passaro{nome:$nome})" +
                                                    "OPTIONAL MATCH (m1:Passaro)-[:MAE]->(f)" +
                                                    "OPTIONAL MATCH (f)<-[:PAI]-(p1:Passaro)" +
                                                    "RETURN f,[f.nome] AS Nomes,[m1.nome] AS Maes,[p1.nome] AS Pais, [ID(f)] AS Ids", new { nome });
                }
                else
                    cursor = await session.RunAsync("MATCH (f:Passaro {nome: $nome, anilha:$anilha})" +
                                                "OPTIONAL MATCH (m1:Passaro)-[:MAE]->(f)" +
                                                "OPTIONAL MATCH (f)<-[:PAI]-(p1:Passaro)" +
                                                "RETURN f,[f.nome] AS Nomes,[m1.nome] AS Maes,[p1.nome] AS Pais, [ID(f)] AS Ids", new { nome, anilha });

                var lista = await cursor.ToListAsync();
                resultado = await cursor.ConsumeAsync();

                return lista;
            }
            finally {
                await session.CloseAsync();
            }

        }

        //TODO: erro quando incluir pais com anilha do filho
        //TODO: Mudar cor das labels na frente do cartão pelo usuário
        //TODO: Menu para atualizar campos de passarinho
        //TODO: Pontos que precisam estão marcados com indicadores de bandeira branca
        //TODO: Clicar em pesquisar sem sair nomeFilhoF faz com que listnomesF == null
        //TODO: Criar menu para cadastrar em árvore
        //TODO: Atualizar buttonPesquisa para buttonImpressão
        public async Task<List<IRecord>> ProcurarFilhos(string nome) {
            session = _driver.AsyncSession(o => o.WithDatabase("neo4j"));//Nome da database está nas propriedades como padrão

            try {
                cursor = await session.RunAsync("MATCH (p:Passaro {nome: $nome})" +
                                            "OPTIONAL MATCH (p)-[:PAI|MAE]->(f:Passaro)" +
                                            "RETURN [p.nome] AS Nomes, [ID(p)] AS Ids,[f.nome] AS Filhos, " +
                                            "[p.anilha] AS Anilhas, [p.Sexo] AS Sexos, [p.NomePopular] AS NomesPopulares, " +
                                            "[p.Nascimento] AS Nascimentos ", new { nome });

                var lista = await cursor.ToListAsync();
                resultado = await cursor.ConsumeAsync();
                return lista;
            }
            finally {
                await session.CloseAsync();
            }

        }

        public List<string> Records() {
            foreach (var no in records) {
                var nomes = no["familia"].As<IList<string>>();
                foreach (var nome in nomes) {
                    if (nome == null)
                        familia.Add("xxxxxxxxxxx");
                    else
                        familia.Add(nome);
                }

                //var anilha = no["anilha"].ToString();
                //var nome = no["nome"].ToString();

                //familia.Add(anilha);
                //familia.Add(nome);

            }
            return familia;
        }

        public List<IList<string>> ListaPais(List<IRecord> lista) {
            List<IList<string>> listaEncontrados = new List<IList<string>>();
            IList<string> filhos = new List<string>();
            IList<string> maes = new List<string>();
            IList<string> pais = new List<string>();
            IList<string> ids = new List<string>();

            foreach (var no in lista) {//Roda todos os nos de nomes->pais nessa ordem
                foreach (var valor in no["Nomes"].As<IList<string>>()) {
                    filhos.Add(valor);
                }
                foreach (var valor in no["Maes"].As<IList<string>>()) {
                    maes.Add(valor);
                }
                foreach (var valor in no["Pais"].As<IList<string>>()) {
                    pais.Add(valor);
                }
                foreach (var valor in no["Ids"].As<IList<string>>()) {
                    ids.Add(valor);
                }

                //listaEncontrados.Add(no["Nomes"].As<IList<string>>());
            }
            listaEncontrados.Add(filhos);
            listaEncontrados.Add(maes);
            listaEncontrados.Add(pais);
            listaEncontrados.Add(ids);
            return listaEncontrados;
        }

        public List<IList<string>> ListaFilhos(List<IRecord> lista) {
            List<IList<string>> listaEncontrados = new List<IList<string>>();
            IList<string> nomes = new List<string>();
            IList<string> ids = new List<string>();
            IList<string> filhos = new List<string>();
            IList<string> nascimentos = new List<string>();
            IList<string> sexos = new List<string>();
            IList<string> nomesPopulares = new List<string>();
            IList<string> anilhas = new List<string>();

            foreach (var no in lista) {//Roda todos os nos de nomes->filhos nessa ordem
                foreach (var valor in no["Nomes"].As<IList<string>>()) {
                    nomes.Add(valor);
                }
                foreach (var valor in no["Ids"].As<IList<string>>()) {
                    ids.Add(valor);
                }
                foreach (var valor in no["Filhos"].As<IList<string>>()) {
                    filhos.Add(valor);
                }
                foreach (var valor in no["Nascimentos"].As<IList<string>>()) {
                    nascimentos.Add(valor);
                }
                foreach (var valor in no["Sexos"].As<IList<string>>()) {
                    sexos.Add(valor);
                }
                foreach (var valor in no["NomesPopulares"].As<IList<string>>()) {
                    nomesPopulares.Add(valor);
                }
                foreach (var valor in no["Anilhas"].As<IList<string>>()) {
                    anilhas.Add(valor);
                }

            }
            listaEncontrados.Add(nomes);
            listaEncontrados.Add(ids);
            listaEncontrados.Add(filhos);
            listaEncontrados.Add(nascimentos);
            listaEncontrados.Add(sexos);
            listaEncontrados.Add(nomesPopulares);
            listaEncontrados.Add(anilhas);
            return listaEncontrados;
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
/*
match (m1:Passaro)-[:MAE]->(f:Passaro{anilha:'20'})<-[:PAI]-(p1:Passaro)

optional match (m2:Passaro)-[:MAE]->(p1)<-[:PAI]-(p2:Passaro)
optional match (m3:Passaro)-[:MAE]->(m1)<-[:PAI]-(p3:Passaro)

optional match (m4:Passaro)-[:MAE]->(p2)<-[:PAI]-(p4:Passaro)
optional match (m5:Passaro)-[:MAE]->(m2)<-[:PAI]-(p5:Passaro)
optional match (m6:Passaro)-[:MAE]->(p3)<-[:PAI]-(p6:Passaro)
optional match (m7:Passaro)-[:MAE]->(m3)<-[:PAI]-(p7:Passaro)

return [f.nome,p1.nome,m1.nome,p2.nome,m2.nome,p3.nome,m3.nome,p4.nome,m4.nome,p5.nome,m5.nome,p6.nome,m6.nome,p7.nome,m7.nome] AS familia

*/