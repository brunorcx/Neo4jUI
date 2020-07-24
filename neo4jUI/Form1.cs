﻿using Neo4j.Driver;
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
        private List<IList<string>> listaNomesPai;
        private List<IList<string>> listaNomesMae;
        private List<IList<string>> listaNomesFilho;
        private List<IList<string>> listaPaisFilho;
        private int paiIndex = -1;
        private int maeIndex = -1;
        private int filhoIndex = -1;
        private string paiAnterior;
        private string maeAnterior;
        private string filhoAnterior;

        public Form1() {
            InitializeComponent();
            radioButtonPassaro.Checked = true;
            buttonPesquisar.Location = buttonCadastrar.Location;
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

        private async void Button_Cadastrar(object sender, EventArgs e) {
            if (radioButtonPassaro.Checked) {
                if (comboBoxNomeF.Text == String.Empty)
                    MessageBox.Show("Por favor, preencha todos os campos");
                else {
                    try {
                        await dbCypher.InserirNoAsync(comboBoxNomeF.Text, textBoxAniF.Text);
                        MessageBox.Show("Passarinho Cadastrado com sucesso!");
                    }
                    catch (Exception) {
                        MessageBox.Show("Passarinho já foi cadastrado! Verifique o número da anilha");
                        throw;
                    }
                }

            }
            else if (radioButtonPais.Checked) {
                if (comboBoxNomeF.Text == String.Empty
                   || comboBoxPai.Text == String.Empty
                   || comboBoxMae.Text == String.Empty) {
                    MessageBox.Show("Por favor, preencha todos os campos");
                }
                else {// Definir Pais
                    var lista = await dbCypher.ProcurarPais(comboBoxNomeF.Text, textBoxAniF.Text);
                    listaPaisFilho = dbCypher.ListaPais(lista);
                    if (listaPaisFilho[1][filhoIndex] != null // Se tem Mãe
                        && listaPaisFilho[2][filhoIndex] != null)//Se tem Pai
                        MessageBox.Show("Este passarinho já possui pais cadastrados!");
                    else {
                        try {
                            bool[] comAnilha = new bool[3] { true, true, true };
                            if (textBoxAniF.Text == String.Empty) {
                                textBoxAniF.Text = listaNomesFilho[1][filhoIndex];
                                comAnilha[0] = false;
                            }
                            if (textBoxAniP.Text == String.Empty) {
                                textBoxAniP.Text = listaNomesPai[3][paiIndex];
                                comAnilha[1] = false;

                            }
                            if (textBoxAniM.Text == String.Empty) {
                                textBoxAniM.Text = listaNomesMae[3][maeIndex];
                                comAnilha[2] = false;
                            }

                            await dbCypher.DefinirPaisAsync(comboBoxNomeF.Text, textBoxAniF.Text,
                                                            comboBoxPai.Text, textBoxAniP.Text,
                                                            comboBoxMae.Text, textBoxAniM.Text, comAnilha);
                            /* if (dbCypher.GetResultado().Counters.RelationshipsCreated == 0)
                                 MessageBox.Show("Este passarinho já possui pais cadastrados!");
                             else */
                            MessageBox.Show("Pais do Passarinho atualizados com sucesso!");

                        }
                        catch (Exception) {
                            MessageBox.Show("Pais do passarinho não foram encontrados, por favor cadastre-os primeiro!");
                        }

                    }
                }
            }
        }

        private async void ComboBoxPai_KeyUpAsync(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter && comboBoxPai.Text != String.Empty) {
                var lista = await dbCypher.ProcurarPais(comboBoxPai.Text, textBoxAniP.Text);
                listaNomesPai = dbCypher.ListaPais(lista);
                comboBoxPai.DataSource = listaNomesPai[0];
                if (lista.Count != 0) {
                    comboBoxPai.SelectedIndex = 0;
                    ComboBoxPai_SelectionChangeCommitted(sender, e);
                }

            }
        }

        private async void ComboBoxPai_Leave(object sender, EventArgs e) {
            if (comboBoxPai.Text != paiAnterior)
                paiIndex = -1;

            if (comboBoxPai.Text != String.Empty)
                if (paiIndex < 0) {
                    var lista = await dbCypher.ProcurarPais(comboBoxPai.Text, textBoxAniP.Text);
                    listaNomesPai = dbCypher.ListaPais(lista);
                    comboBoxPai.DataSource = listaNomesPai[0];
                    if (lista.Count != 0) {
                        paiIndex = 0;
                        labelMaeP.Text = listaNomesPai[1][comboBoxPai.SelectedIndex];
                        labelPaiP.Text = listaNomesPai[2][comboBoxPai.SelectedIndex];
                    }
                }

            paiAnterior = comboBoxPai.Text;
        }

        private void ComboBoxPai_SelectionChangeCommitted(object sender, EventArgs e) {
            if (comboBoxPai.Focused) {
                labelMaeP.Text = listaNomesPai[1][comboBoxPai.SelectedIndex];
                labelPaiP.Text = listaNomesPai[2][comboBoxPai.SelectedIndex];
                paiIndex = comboBoxPai.SelectedIndex;
            }
        }

        private async void ComboBoxMae_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter && comboBoxMae.Text != String.Empty) {
                var lista = await dbCypher.ProcurarPais(comboBoxMae.Text, textBoxAniM.Text);
                listaNomesMae = dbCypher.ListaPais(lista);
                comboBoxMae.DataSource = listaNomesMae[0];
                if (lista.Count != 0) {
                    comboBoxMae.SelectedIndex = 0;
                    ComboBoxMae_SelectionChangeCommitted(sender, e);
                }

            }
        }

        private async void ComboBoxMae_Leave(object sender, EventArgs e) {
            if (comboBoxMae.Text != maeAnterior)
                maeIndex = -1;

            if (comboBoxMae.Text != String.Empty)
                if (maeIndex < 0) {
                    var lista = await dbCypher.ProcurarPais(comboBoxMae.Text, textBoxAniM.Text);
                    listaNomesMae = dbCypher.ListaPais(lista);
                    comboBoxMae.DataSource = listaNomesMae[0];
                    if (lista.Count != 0) {
                        maeIndex = 0;
                        labelMaeM.Text = listaNomesMae[1][comboBoxMae.SelectedIndex];
                        labelPaiM.Text = listaNomesMae[2][comboBoxMae.SelectedIndex];
                    }
                }

            maeAnterior = comboBoxMae.Text;
        }

        private void ComboBoxMae_SelectionChangeCommitted(object sender, EventArgs e) {
            if (comboBoxMae.Focused) {
                labelMaeM.Text = listaNomesMae[1][comboBoxMae.SelectedIndex];
                labelPaiM.Text = listaNomesMae[2][comboBoxMae.SelectedIndex];
                maeIndex = comboBoxMae.SelectedIndex;
            }
        }

        private async void ComboBoxNomeF_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter && comboBoxNomeF.Text != String.Empty) {
                var lista = await dbCypher.ProcurarFilhos(comboBoxNomeF.Text);
                listaNomesFilho = dbCypher.ListaFilhos(lista);
                comboBoxNomeF.DataSource = listaNomesFilho[0];
                if (lista.Count != 0) {
                    comboBoxNomeF.SelectedIndex = 0;
                    ComboBoxNomeF_SelectionChangeCommitted(sender, e);
                }
            }
        }

        private async void ComboBoxNomeF_Leave(object sender, EventArgs e) {
            if (comboBoxNomeF.Text != filhoAnterior)
                filhoIndex = -1;

            if (comboBoxNomeF.Text != String.Empty)
                if (filhoIndex < 0) {
                    var lista = await dbCypher.ProcurarFilhos(comboBoxNomeF.Text);
                    listaNomesFilho = dbCypher.ListaFilhos(lista);
                    comboBoxNomeF.DataSource = listaNomesFilho[0];
                    if (lista.Count != 0) {
                        filhoIndex = 0;
                        labelFilho.Text = listaNomesFilho[2][comboBoxNomeF.SelectedIndex];
                    }
                }

            filhoAnterior = comboBoxNomeF.Text;
        }

        private void ComboBoxNomeF_SelectionChangeCommitted(object sender, EventArgs e) {
            if (comboBoxNomeF.Focused) {
                labelFilho.Text = listaNomesFilho[2][comboBoxNomeF.SelectedIndex];
                filhoIndex = comboBoxNomeF.SelectedIndex;
            }
        }

        private void radioButtonPassaro_CheckedChanged(object sender, EventArgs e) {
            labelNome.Show();
            labelAniF.Show();
            comboBoxNomeF.Show();
            textBoxAniF.Show();

            labelNPai.Hide();
            labelAniP.Hide();
            comboBoxPai.Hide();
            textBoxAniP.Hide();
            labelNMae.Hide();
            labelAniM.Hide();
            comboBoxMae.Hide();
            textBoxAniM.Hide();
            labelPaiP.Hide();
            labelMaeP.Hide();
            labelPaiM.Hide();
            labelMaeM.Hide();

        }

        private void radioButtonPais_CheckedChanged(object sender, EventArgs e) {
            labelNome.Show();
            labelAniF.Show();
            comboBoxNomeF.Show();
            textBoxAniF.Show();
            labelNPai.Show();
            labelAniP.Show();
            comboBoxPai.Show();
            textBoxAniP.Show();
            labelNMae.Show();
            labelAniM.Show();
            comboBoxMae.Show();
            textBoxAniM.Show();
            labelPaiP.Show();
            labelMaeP.Show();
            labelPaiM.Show();
            labelMaeM.Show();

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
                    comboBoxPai.Hide();
                    textBoxAniP.Hide();
                    labelNMae.Hide();
                    labelAniM.Hide();
                    comboBoxMae.Hide();
                    textBoxAniM.Hide();
                }
                else {
                    labelNPai.Show();
                    labelAniP.Show();
                    comboBoxPai.Show();
                    textBoxAniP.Show();
                    labelNMae.Show();
                    labelAniM.Show();
                    comboBoxMae.Show();
                    textBoxAniM.Show();
                }
            }
            else {
                buttonCadastrar.Hide();
                buttonPesquisar.Show();

                labelNPai.Hide();
                labelAniP.Hide();
                comboBoxPai.Hide();
                textBoxAniP.Hide();
                labelNMae.Hide();
                labelAniM.Hide();
                comboBoxMae.Hide();
                textBoxAniM.Hide();
                radioButtonPassaro.Hide();
                radioButtonPais.Hide();

            }
        }

        private async void Pesquisar_Click(object sender, EventArgs e) {
            await dbCypher.ProcurarFamilia(comboBoxNomeF.Text, textBoxAniF.Text);

            if (dbCypher.GetRecords().Count == 0)
                MessageBox.Show("Passarinho não encontrado, por favor cadastre-o primeiro");
            else {
                //Imprimir Árvore
                GerarPDF pdf = new GerarPDF(dbCypher.GetFamilia());
                pdf.salvarPDF("ArvoreGenealogica");
            }
        }

    }
}

//criar unique CREATE CONSTRAINT ON (p:Passaro) ASSERT p.anilha IS UNIQUE
//MERGE faz com que cada passáro só tenha um pai e uma mãe
//Quando já tem um dos pais cadastrados e quer cadastrar o outro acontece duplo relacionamento
//Achar todos os nós a partir de um nó  MATCH(p:Passaro{ anilha: '1'})-[*]-(connected) RETURN p,connected
//Ícone retirado do sítio https://publicdomainvectors.org/en/free-clipart/Vector-image-of-goldfinch-bird-on-a-branch/28843.html
//Dá o aviso errado quando o passarinho não tem pais, mas está cadastrado
//https://stackoverflow.com/questions/32956142/how-to-deploy-application-with-sql-server-database-on-clients