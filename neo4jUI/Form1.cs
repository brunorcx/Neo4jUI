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
        private bool buttonCadastrarM;
        private bool buttonPesquisarM;
        private List<string> listaNomes;

        public Form1() {
            InitializeComponent();
            radioButtonPassaro.Checked = true;
            buttonPesquisar.Location = buttonCadastrar.Location;
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
                    if (dbCypher.GetResultado().Counters.RelationshipsCreated == 0)
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

        private void Cadastro_MouseEnter(object sender, EventArgs e) {
            buttonCMenu.FlatAppearance.BorderColor = SystemColors.ControlDark;
        }

        private void Cadastro_MouseLeave(object sender, EventArgs e) {
            if (!buttonCadastrarM)
                buttonCMenu.FlatAppearance.BorderColor = SystemColors.ControlLightLight;
        }

        private void Cadastro_MouseClick(object sender, MouseEventArgs e) {
            panelSelecionado.Location = new System.Drawing.Point(buttonCMenu.Location.X, panelLinha.Location.Y);
            buttonCMenu.FlatAppearance.BorderColor = SystemColors.ControlDark;
            buttonCadastrarM = true;
            //Mudar selecionado
            buttonPesquisarM = false;
            buttonPesquisa.FlatAppearance.BorderColor = SystemColors.ControlLightLight;

            //Mudar título
            labelTitulo.Text = "Cadastro de Passarinho";

            //Deixar itens visíveis
            tornarVisivel(true);
        }

        private void Pesquisa_MouseEnter(object sender, EventArgs e) {
            buttonPesquisa.FlatAppearance.BorderColor = SystemColors.ControlDark;

        }

        private void Pesquisa_MouseLeave(object sender, EventArgs e) {
            if (!buttonPesquisarM)
                buttonPesquisa.FlatAppearance.BorderColor = SystemColors.ControlLightLight;
        }

        private void Pesquisa_MouseClick(object sender, EventArgs e) {
            panelSelecionado.Location = new System.Drawing.Point(buttonPesquisa.Location.X, panelLinha.Location.Y);
            buttonPesquisa.FlatAppearance.BorderColor = SystemColors.ControlDark;
            buttonPesquisarM = true;
            //Mudar selecionado
            buttonCMenu.FlatAppearance.BorderColor = SystemColors.ControlLightLight;
            buttonCadastrarM = false;

            //Mudar Título
            labelTitulo.Text = "Pesquisa de Passarinho";

            //Deixar itens escondidos
            tornarVisivel(false);
        }

        private void tornarVisivel(bool visivel) {
            if (visivel) {
                buttonCadastrar.Show();
                buttonPesquisar.Hide();

                radioButtonPassaro.Show();
                radioButtonPais.Show();
                if (radioButtonPassaro.Checked) {
                    labelNPai.Hide();
                    labelAniP.Hide();
                    textBoxNomePai.Hide();
                    textBoxAniP.Hide();
                    labelNMae.Hide();
                    labelAniM.Hide();
                    textBoxNomeMae.Hide();
                    textBoxAniM.Hide();
                }
                else {
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
            else {
                buttonCadastrar.Hide();
                buttonPesquisar.Show();

                labelNPai.Hide();
                labelAniP.Hide();
                textBoxNomePai.Hide();
                textBoxAniP.Hide();
                labelNMae.Hide();
                labelAniM.Hide();
                textBoxNomeMae.Hide();
                textBoxAniM.Hide();
                radioButtonPassaro.Hide();
                radioButtonPais.Hide();

            }
        }

        private async void Pesquisar_Click(object sender, EventArgs e) {
            await dbCypher.ProcurarFamilia(textBoxNomeF.Text, textBoxAniF.Text);

            //Imprimir Árvore
            GerarPDF pdf = new GerarPDF(dbCypher.GetFamilia());
            pdf.salvarPDF("ArvoreGenealogica");
        }
    }
}

//criar unique CREATE CONSTRAINT ON (p:Passaro) ASSERT p.anilha IS UNIQUE
//MERGE faz com que cada passáro só tenha um pai e uma mãe
//Quando já tem um dos pais cadastrados e quer cadastrar o outro acontece duplo relacionamento
// Achar todos os nós a partir de um nó  MATCH(p:Passaro{ anilha: '1'})-[*]-(connected) RETURN p,connected
// Ícone retirado do sítio https://publicdomainvectors.org/en/free-clipart/Vector-image-of-goldfinch-bird-on-a-branch/28843.html