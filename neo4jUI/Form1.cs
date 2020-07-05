using Neo4j.Driver;
using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace neo4jUI {

    public partial class Form1 : Form {
        private DBconnectDriver dbCypher;

        public Form1() {
            InitializeComponent();
            radioButtonPassaro.Checked = true;
        }

        private async void Button_Cadastrar(object sender, EventArgs e) {
            if (radioButtonPassaro.Checked) {
                if (textBoxNomeF.Text == String.Empty || textBoxAniF.Text == String.Empty)
                    MessageBox.Show("Por favor, preencha todos os campos");
                else {
                    try {
                        await dbCypher.InserirNoAsync(textBoxNomeF.Text, textBoxAniF.Text);
                        MessageBox.Show("Passarinho Cadastrado com sucesso!");
                    }
                    catch (Exception) {
                        MessageBox.Show("Passarinho já foi cadastrado! Verifique o número da anilha");
                    }
                }

            }
            else if (radioButtonPais.Checked) {
                if (textBoxNomeF.Text == String.Empty || textBoxAniF.Text == String.Empty
                   || textBoxNomePai.Text == String.Empty || textBoxAniP.Text == String.Empty
                   || textBoxNomeMae.Text == String.Empty || textBoxAniM.Text == String.Empty) {
                    MessageBox.Show("Por favor, preencha todos os campos");
                }

                try {
                    await dbCypher.DefinirPaisAsync(textBoxNomeF.Text, textBoxAniF.Text,
                                                    textBoxNomePai.Text, textBoxAniP.Text,
                                                    textBoxNomeMae.Text, textBoxAniM.Text);
                    if (dbCypher.resultado.Counters.RelationshipsCreated == 0)
                        MessageBox.Show("Este passarinho já possui pais cadastrados!");
                    else
                        MessageBox.Show("Pais do Passarinho atualizados com sucesso!");

                }
                catch (Exception) {
                    MessageBox.Show("Pais do passarinho não foram encontrados, por favor cadastre-os primeiro!");
                }
            }
        }

        private async void Form1_Load(object sender, EventArgs e) {
            dbCypher = new DBconnectDriver("admin", "admin");
            try {
                await dbCypher.CriarUniqueAsync();
            }
            catch (Exception) {
                //Duplicado a criação do constraint para unique da anilhaC
            }

        }

        private void radioButtonPassaro_CheckedChanged(object sender, EventArgs e) {
            labelNome.Show();
            labelAniF.Show();
            textBoxNomeF.Show();
            textBoxAniF.Show();

            labelNPai.Hide();
            labelAniP.Hide();
            textBoxNomePai.Hide();
            textBoxAniP.Hide();
            labelNMae.Hide();
            labelAniM.Hide();
            textBoxNomeMae.Hide();
            textBoxAniM.Hide();

        }

        private void radioButtonPais_CheckedChanged(object sender, EventArgs e) {
            labelNome.Show();
            labelAniF.Show();
            textBoxNomeF.Show();
            textBoxAniF.Show();
            labelNPai.Show();
            labelAniP.Show();
            textBoxNomePai.Show();
            textBoxAniP.Show();
            labelNMae.Show();
            labelAniM.Show();
            textBoxNomeMae.Show();
            textBoxAniM.Show();

        }
    }
}

//criar unique CREATE CONSTRAINT ON (p:Passaro) ASSERT p.anilha IS UNIQUE
//MERGE faz com que cada passáro só tenha um pai e uma mãe
//Quando já tem um dos pais cadastrados e quer cadastrar o outro acontece duplo relacionamento
// Achar todos os nós a partir de um nó  MATCH(p:Passaro{ anilha: '1'})-[*]-(connected) RETURN p,connected