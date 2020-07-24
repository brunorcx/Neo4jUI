﻿using Neo4j.Driver;
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

        public async Task InserirNoAsync(string nome, string anilha) {
            session = _driver.AsyncSession(o => o.WithDatabase("neo4j"));//Nome da database está nas propriedades como padrão

            try {
                if (anilha == string.Empty) {
                    cursor = await session.RunAsync("CREATE (p:Passaro{nome:$nome})", new { nome });//MERGE Impede cadastro de mesmo nome
                }
                else
                    cursor = await session.RunAsync("CREATE (p:Passaro{nome:$nome, anilha:$anilha})", new { nome, anilha });

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

        public async Task ProcurarFamilia(string filho, string aniFilho) { //Testar essa função
            session = _driver.AsyncSession(o => o.WithDatabase("neo4j"));//Nome da database está nas propriedades como padrão
            try {
                string query = "match (m1:Passaro)-[:MAE]->(f:Passaro{nome:$filho, anilha:$aniFilho})<-[:PAI]-(p1:Passaro)" +
                    "optional match(m2:Passaro)-[:MAE]->(p1) < -[:PAI] - (p2: Passaro)" +
                    "optional match(m3:Passaro)-[:MAE]->(m1) < -[:PAI] - (p3: Passaro)" +
                    "optional match(m4:Passaro)-[:MAE]->(p2) < -[:PAI] - (p4: Passaro)" +
                    "optional match(m5:Passaro)-[:MAE]->(m2) < -[:PAI] - (p5: Passaro)" +
                    "optional match(m6:Passaro)-[:MAE]->(p3) < -[:PAI] - (p6: Passaro)" +
                    "optional match(m7:Passaro)-[:MAE]->(m3) < -[:PAI] - (p7: Passaro)" +
                    "return [f.nome, p1.nome, m1.nome, p2.nome, m2.nome, p3.nome, m3.nome, " +
                    "p4.nome, m4.nome, p5.nome, m5.nome, p6.nome, m6.nome, p7.nome, m7.nome] AS familia";

                cursor = await session.RunAsync(query, new { filho, aniFilho });

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

        public async Task<List<IRecord>> ProcurarPais(string nome, string anilha) {
            session = _driver.AsyncSession(o => o.WithDatabase("neo4j"));//Nome da database está nas propriedades como padrão

            try {
                if (anilha == String.Empty) {
                    cursor = await session.RunAsync("MATCH (f:Passaro{nome:$nome})" +
                                                "OPTIONAL MATCH (m1:Passaro)-[:MAE]->(f)" +
                                                "OPTIONAL MATCH (f)<-[:PAI]-(p1:Passaro)" +
                                                "RETURN f,[f.nome] AS Nomes,[m1.nome] AS Maes,[p1.nome] AS Pais, [ID(f)] AS Ids", new { nome });
                }
                else
                    cursor = await session.RunAsync("MATCH (p:Passaro {nome: $nome, anilha:$anilha})" +
                                                "OPTIONAL MATCH (m1:Passaro)-[:MAE]->(f)" +
                                                "OPTIONAL MATCH (f)<-[:PAI]-(p1:Passaro)" +
                                                "RETURN f,[f.nome] AS Nomes,[m1.nome] AS Maes,[p1.nome] AS Pais", new { nome, anilha });

                var lista = await cursor.ToListAsync();
                resultado = await cursor.ConsumeAsync();

                return lista;
            }
            finally {
                await session.CloseAsync();

            }

        }

        //TODO: Testar cadastrar ListaNomeFilhos é diferente, confirmar ID selecionado
        //TODO: Pontos que precisam estão marcados com indicadores de bandeira branca
        public async Task<List<IRecord>> ProcurarFilhos(string nome) {
            session = _driver.AsyncSession(o => o.WithDatabase("neo4j"));//Nome da database está nas propriedades como padrão

            try {
                cursor = await session.RunAsync("MATCH (p:Passaro {nome: $nome})" +
                                            "OPTIONAL MATCH (p)-[:PAI|MAE]->(f:Passaro)" +
                                            "RETURN [p.nome] AS Nomes, [ID(p)] AS Ids,[f.nome] AS Filhos", new { nome });

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

            }
            listaEncontrados.Add(nomes);
            listaEncontrados.Add(ids);
            listaEncontrados.Add(filhos);
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