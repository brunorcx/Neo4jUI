namespace neo4jUI {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelNPai = new System.Windows.Forms.Label();
            this.labelNMae = new System.Windows.Forms.Label();
            this.labelAniF = new System.Windows.Forms.Label();
            this.textBoxAniF = new System.Windows.Forms.TextBox();
            this.labelAniP = new System.Windows.Forms.Label();
            this.textBoxAniP = new System.Windows.Forms.TextBox();
            this.labelAniM = new System.Windows.Forms.Label();
            this.textBoxAniM = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.radioButtonPassaro = new System.Windows.Forms.RadioButton();
            this.radioButtonPais = new System.Windows.Forms.RadioButton();
            this.buttonCMenu = new System.Windows.Forms.Button();
            this.panelSelecionado = new System.Windows.Forms.Panel();
            this.panelLinha = new System.Windows.Forms.Panel();
            this.buttonPesquisa = new System.Windows.Forms.Button();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.comboBoxPai = new System.Windows.Forms.ComboBox();
            this.radioButtonArvore = new System.Windows.Forms.RadioButton();
            this.labelPaiP = new System.Windows.Forms.Label();
            this.labelMaeP = new System.Windows.Forms.Label();
            this.comboBoxMae = new System.Windows.Forms.ComboBox();
            this.labelPaiM = new System.Windows.Forms.Label();
            this.labelMaeM = new System.Windows.Forms.Label();
            this.labelFilho = new System.Windows.Forms.Label();
            this.comboBoxNomeF = new System.Windows.Forms.ComboBox();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.labelSexo = new System.Windows.Forms.Label();
            this.comboBoxNomePopular = new System.Windows.Forms.ComboBox();
            this.labelNomePopular = new System.Windows.Forms.Label();
            this.dateTimePickerNascimento = new System.Windows.Forms.DateTimePicker();
            this.labelNascimento = new System.Windows.Forms.Label();
            this.buttonSFundo = new System.Windows.Forms.Button();
            this.labelFundo = new System.Windows.Forms.Label();
            this.textBoxFundo = new System.Windows.Forms.TextBox();
            this.labelLogo = new System.Windows.Forms.Label();
            this.textBoxLogo = new System.Windows.Forms.TextBox();
            this.buttonSLogo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCadastrar.Location = new System.Drawing.Point(39, 493);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(139, 38);
            this.buttonCadastrar.TabIndex = 7;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.Button_Cadastrar);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(35, 177);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(51, 20);
            this.labelNome.TabIndex = 6;
            this.labelNome.Text = "Nome";
            // 
            // labelNPai
            // 
            this.labelNPai.AutoSize = true;
            this.labelNPai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNPai.Location = new System.Drawing.Point(35, 257);
            this.labelNPai.Name = "labelNPai";
            this.labelNPai.Size = new System.Drawing.Size(99, 20);
            this.labelNPai.TabIndex = 8;
            this.labelNPai.Text = "Nome do Pai";
            // 
            // labelNMae
            // 
            this.labelNMae.AutoSize = true;
            this.labelNMae.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNMae.Location = new System.Drawing.Point(35, 337);
            this.labelNMae.Name = "labelNMae";
            this.labelNMae.Size = new System.Drawing.Size(108, 20);
            this.labelNMae.TabIndex = 10;
            this.labelNMae.Text = "Nome da Mãe";
            // 
            // labelAniF
            // 
            this.labelAniF.AutoSize = true;
            this.labelAniF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAniF.Location = new System.Drawing.Point(507, 177);
            this.labelAniF.Name = "labelAniF";
            this.labelAniF.Size = new System.Drawing.Size(53, 20);
            this.labelAniF.TabIndex = 12;
            this.labelAniF.Text = "Anilha";
            // 
            // textBoxAniF
            // 
            this.textBoxAniF.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxAniF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAniF.Location = new System.Drawing.Point(511, 200);
            this.textBoxAniF.MaxLength = 50;
            this.textBoxAniF.Name = "textBoxAniF";
            this.textBoxAniF.Size = new System.Drawing.Size(244, 29);
            this.textBoxAniF.TabIndex = 2;
            // 
            // labelAniP
            // 
            this.labelAniP.AutoSize = true;
            this.labelAniP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAniP.Location = new System.Drawing.Point(507, 257);
            this.labelAniP.Name = "labelAniP";
            this.labelAniP.Size = new System.Drawing.Size(53, 20);
            this.labelAniP.TabIndex = 14;
            this.labelAniP.Text = "Anilha";
            // 
            // textBoxAniP
            // 
            this.textBoxAniP.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxAniP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAniP.Location = new System.Drawing.Point(511, 280);
            this.textBoxAniP.MaxLength = 50;
            this.textBoxAniP.Name = "textBoxAniP";
            this.textBoxAniP.Size = new System.Drawing.Size(244, 29);
            this.textBoxAniP.TabIndex = 4;
            // 
            // labelAniM
            // 
            this.labelAniM.AutoSize = true;
            this.labelAniM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAniM.Location = new System.Drawing.Point(507, 337);
            this.labelAniM.Name = "labelAniM";
            this.labelAniM.Size = new System.Drawing.Size(53, 20);
            this.labelAniM.TabIndex = 16;
            this.labelAniM.Text = "Anilha";
            // 
            // textBoxAniM
            // 
            this.textBoxAniM.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxAniM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAniM.Location = new System.Drawing.Point(511, 360);
            this.textBoxAniM.MaxLength = 50;
            this.textBoxAniM.Name = "textBoxAniM";
            this.textBoxAniM.Size = new System.Drawing.Size(244, 29);
            this.textBoxAniM.TabIndex = 6;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTitulo.Location = new System.Drawing.Point(34, 117);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(270, 29);
            this.labelTitulo.TabIndex = 17;
            this.labelTitulo.Text = "Cadastro de Passarinho";
            // 
            // radioButtonPassaro
            // 
            this.radioButtonPassaro.AutoSize = true;
            this.radioButtonPassaro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonPassaro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonPassaro.Location = new System.Drawing.Point(39, 157);
            this.radioButtonPassaro.Name = "radioButtonPassaro";
            this.radioButtonPassaro.Size = new System.Drawing.Size(122, 17);
            this.radioButtonPassaro.TabIndex = 18;
            this.radioButtonPassaro.TabStop = true;
            this.radioButtonPassaro.Text = "Somente Passarinho";
            this.radioButtonPassaro.UseVisualStyleBackColor = false;
            this.radioButtonPassaro.CheckedChanged += new System.EventHandler(this.radioButtonPassaro_CheckedChanged);
            // 
            // radioButtonPais
            // 
            this.radioButtonPais.AutoSize = true;
            this.radioButtonPais.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonPais.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonPais.Location = new System.Drawing.Point(167, 157);
            this.radioButtonPais.Name = "radioButtonPais";
            this.radioButtonPais.Size = new System.Drawing.Size(76, 17);
            this.radioButtonPais.TabIndex = 19;
            this.radioButtonPais.TabStop = true;
            this.radioButtonPais.Text = "Incluir Pais";
            this.radioButtonPais.UseVisualStyleBackColor = false;
            this.radioButtonPais.CheckedChanged += new System.EventHandler(this.radioButtonPais_CheckedChanged);
            // 
            // buttonCMenu
            // 
            this.buttonCMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCMenu.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCMenu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.buttonCMenu.Location = new System.Drawing.Point(39, 53);
            this.buttonCMenu.Name = "buttonCMenu";
            this.buttonCMenu.Size = new System.Drawing.Size(85, 26);
            this.buttonCMenu.TabIndex = 9;
            this.buttonCMenu.Text = "Cadastro";
            this.buttonCMenu.UseVisualStyleBackColor = false;
            this.buttonCMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cadastro_MouseClick);
            this.buttonCMenu.MouseEnter += new System.EventHandler(this.Cadastro_MouseEnter);
            this.buttonCMenu.MouseLeave += new System.EventHandler(this.Cadastro_MouseLeave);
            // 
            // panelSelecionado
            // 
            this.panelSelecionado.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelSelecionado.Location = new System.Drawing.Point(39, 85);
            this.panelSelecionado.Name = "panelSelecionado";
            this.panelSelecionado.Size = new System.Drawing.Size(90, 6);
            this.panelSelecionado.TabIndex = 21;
            // 
            // panelLinha
            // 
            this.panelLinha.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelLinha.Location = new System.Drawing.Point(20, 85);
            this.panelLinha.Name = "panelLinha";
            this.panelLinha.Size = new System.Drawing.Size(760, 6);
            this.panelLinha.TabIndex = 22;
            // 
            // buttonPesquisa
            // 
            this.buttonPesquisa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPesquisa.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPesquisa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.buttonPesquisa.Location = new System.Drawing.Point(130, 53);
            this.buttonPesquisa.Name = "buttonPesquisa";
            this.buttonPesquisa.Size = new System.Drawing.Size(85, 26);
            this.buttonPesquisa.TabIndex = 10;
            this.buttonPesquisa.Text = "Impressão";
            this.buttonPesquisa.UseVisualStyleBackColor = false;
            this.buttonPesquisa.Click += new System.EventHandler(this.Pesquisa_MouseClick);
            this.buttonPesquisa.MouseEnter += new System.EventHandler(this.Pesquisa_MouseEnter);
            this.buttonPesquisa.MouseLeave += new System.EventHandler(this.Pesquisa_MouseLeave);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPesquisar.Location = new System.Drawing.Point(184, 493);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(139, 38);
            this.buttonPesquisar.TabIndex = 8;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = false;
            this.buttonPesquisar.Visible = false;
            this.buttonPesquisar.Click += new System.EventHandler(this.Pesquisar_Click);
            // 
            // comboBoxPai
            // 
            this.comboBoxPai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxPai.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBoxPai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPai.FormattingEnabled = true;
            this.comboBoxPai.Location = new System.Drawing.Point(39, 280);
            this.comboBoxPai.Name = "comboBoxPai";
            this.comboBoxPai.Size = new System.Drawing.Size(244, 32);
            this.comboBoxPai.TabIndex = 3;
            this.comboBoxPai.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxPai_SelectionChangeCommitted);
            this.comboBoxPai.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ComboBoxPai_KeyUpAsync);
            this.comboBoxPai.Leave += new System.EventHandler(this.ComboBoxPai_Leave);
            // 
            // radioButtonArvore
            // 
            this.radioButtonArvore.AutoSize = true;
            this.radioButtonArvore.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonArvore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonArvore.Location = new System.Drawing.Point(249, 157);
            this.radioButtonArvore.Name = "radioButtonArvore";
            this.radioButtonArvore.Size = new System.Drawing.Size(103, 17);
            this.radioButtonArvore.TabIndex = 26;
            this.radioButtonArvore.TabStop = true;
            this.radioButtonArvore.Text = "Árvore Completa";
            this.radioButtonArvore.UseVisualStyleBackColor = false;
            // 
            // labelPaiP
            // 
            this.labelPaiP.AutoSize = true;
            this.labelPaiP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaiP.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelPaiP.Location = new System.Drawing.Point(289, 281);
            this.labelPaiP.Name = "labelPaiP";
            this.labelPaiP.Size = new System.Drawing.Size(22, 13);
            this.labelPaiP.TabIndex = 27;
            this.labelPaiP.Text = "Pai";
            // 
            // labelMaeP
            // 
            this.labelMaeP.AutoSize = true;
            this.labelMaeP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaeP.ForeColor = System.Drawing.Color.DarkRed;
            this.labelMaeP.Location = new System.Drawing.Point(289, 297);
            this.labelMaeP.Name = "labelMaeP";
            this.labelMaeP.Size = new System.Drawing.Size(28, 13);
            this.labelMaeP.TabIndex = 28;
            this.labelMaeP.Text = "Mãe";
            // 
            // comboBoxMae
            // 
            this.comboBoxMae.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxMae.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxMae.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBoxMae.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMae.FormattingEnabled = true;
            this.comboBoxMae.Location = new System.Drawing.Point(39, 360);
            this.comboBoxMae.Name = "comboBoxMae";
            this.comboBoxMae.Size = new System.Drawing.Size(244, 32);
            this.comboBoxMae.TabIndex = 5;
            this.comboBoxMae.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxMae_SelectionChangeCommitted);
            this.comboBoxMae.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ComboBoxMae_KeyUp);
            this.comboBoxMae.Leave += new System.EventHandler(this.ComboBoxMae_Leave);
            // 
            // labelPaiM
            // 
            this.labelPaiM.AutoSize = true;
            this.labelPaiM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaiM.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelPaiM.Location = new System.Drawing.Point(289, 360);
            this.labelPaiM.Name = "labelPaiM";
            this.labelPaiM.Size = new System.Drawing.Size(22, 13);
            this.labelPaiM.TabIndex = 30;
            this.labelPaiM.Text = "Pai";
            // 
            // labelMaeM
            // 
            this.labelMaeM.AutoSize = true;
            this.labelMaeM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaeM.ForeColor = System.Drawing.Color.DarkRed;
            this.labelMaeM.Location = new System.Drawing.Point(289, 379);
            this.labelMaeM.Name = "labelMaeM";
            this.labelMaeM.Size = new System.Drawing.Size(28, 13);
            this.labelMaeM.TabIndex = 31;
            this.labelMaeM.Text = "Mãe";
            // 
            // labelFilho
            // 
            this.labelFilho.AutoSize = true;
            this.labelFilho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilho.ForeColor = System.Drawing.Color.Black;
            this.labelFilho.Location = new System.Drawing.Point(289, 211);
            this.labelFilho.Name = "labelFilho";
            this.labelFilho.Size = new System.Drawing.Size(29, 13);
            this.labelFilho.TabIndex = 32;
            this.labelFilho.Text = "Filho";
            // 
            // comboBoxNomeF
            // 
            this.comboBoxNomeF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxNomeF.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBoxNomeF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNomeF.FormattingEnabled = true;
            this.comboBoxNomeF.Location = new System.Drawing.Point(39, 200);
            this.comboBoxNomeF.MaxLength = 22;
            this.comboBoxNomeF.Name = "comboBoxNomeF";
            this.comboBoxNomeF.Size = new System.Drawing.Size(244, 32);
            this.comboBoxNomeF.TabIndex = 1;
            this.comboBoxNomeF.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxNomeF_SelectionChangeCommitted);
            this.comboBoxNomeF.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ComboBoxNomeF_KeyUp);
            this.comboBoxNomeF.Leave += new System.EventHandler(this.ComboBoxNomeF_Leave);
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.AutoCompleteCustomSource.AddRange(new string[] {
            "Macho",
            "Fêmea"});
            this.comboBoxSexo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxSexo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxSexo.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBoxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Items.AddRange(new object[] {
            "Macho",
            "Fêmea"});
            this.comboBoxSexo.Location = new System.Drawing.Point(455, 53);
            this.comboBoxSexo.MaxLength = 10;
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(244, 32);
            this.comboBoxSexo.TabIndex = 33;
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSexo.Location = new System.Drawing.Point(451, 30);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(45, 20);
            this.labelSexo.TabIndex = 34;
            this.labelSexo.Text = "Sexo";
            // 
            // comboBoxNomePopular
            // 
            this.comboBoxNomePopular.AutoCompleteCustomSource.AddRange(new string[] {
            "Curió",
            "Bicudo"});
            this.comboBoxNomePopular.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxNomePopular.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxNomePopular.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBoxNomePopular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNomePopular.FormattingEnabled = true;
            this.comboBoxNomePopular.Items.AddRange(new object[] {
            "Curió",
            "Bicudo"});
            this.comboBoxNomePopular.Location = new System.Drawing.Point(455, 110);
            this.comboBoxNomePopular.MaxLength = 22;
            this.comboBoxNomePopular.Name = "comboBoxNomePopular";
            this.comboBoxNomePopular.Size = new System.Drawing.Size(244, 32);
            this.comboBoxNomePopular.TabIndex = 35;
            // 
            // labelNomePopular
            // 
            this.labelNomePopular.AutoSize = true;
            this.labelNomePopular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomePopular.Location = new System.Drawing.Point(451, 87);
            this.labelNomePopular.Name = "labelNomePopular";
            this.labelNomePopular.Size = new System.Drawing.Size(109, 20);
            this.labelNomePopular.TabIndex = 36;
            this.labelNomePopular.Text = "Nome Popular";
            // 
            // dateTimePickerNascimento
            // 
            this.dateTimePickerNascimento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNascimento.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.dateTimePickerNascimento.CustomFormat = "dd-MM-yyy";
            this.dateTimePickerNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNascimento.Location = new System.Drawing.Point(455, 493);
            this.dateTimePickerNascimento.Name = "dateTimePickerNascimento";
            this.dateTimePickerNascimento.Size = new System.Drawing.Size(244, 29);
            this.dateTimePickerNascimento.TabIndex = 37;
            // 
            // labelNascimento
            // 
            this.labelNascimento.AutoSize = true;
            this.labelNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNascimento.Location = new System.Drawing.Point(451, 470);
            this.labelNascimento.Name = "labelNascimento";
            this.labelNascimento.Size = new System.Drawing.Size(154, 20);
            this.labelNascimento.TabIndex = 38;
            this.labelNascimento.Text = "Data de Nascimento";
            // 
            // buttonSFundo
            // 
            this.buttonSFundo.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSFundo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSFundo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSFundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSFundo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSFundo.Location = new System.Drawing.Point(292, 440);
            this.buttonSFundo.Name = "buttonSFundo";
            this.buttonSFundo.Size = new System.Drawing.Size(84, 29);
            this.buttonSFundo.TabIndex = 39;
            this.buttonSFundo.Text = "Selecionar";
            this.buttonSFundo.UseVisualStyleBackColor = false;
            this.buttonSFundo.Visible = false;
            this.buttonSFundo.Click += new System.EventHandler(this.ButtonSFundo_Click);
            // 
            // labelFundo
            // 
            this.labelFundo.AutoSize = true;
            this.labelFundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFundo.Location = new System.Drawing.Point(35, 417);
            this.labelFundo.Name = "labelFundo";
            this.labelFundo.Size = new System.Drawing.Size(139, 20);
            this.labelFundo.TabIndex = 41;
            this.labelFundo.Text = "Imagem do Fundo";
            this.labelFundo.Visible = false;
            // 
            // textBoxFundo
            // 
            this.textBoxFundo.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxFundo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxFundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFundo.Location = new System.Drawing.Point(39, 440);
            this.textBoxFundo.MaxLength = 50;
            this.textBoxFundo.Name = "textBoxFundo";
            this.textBoxFundo.ReadOnly = true;
            this.textBoxFundo.Size = new System.Drawing.Size(244, 29);
            this.textBoxFundo.TabIndex = 40;
            this.textBoxFundo.Visible = false;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.Location = new System.Drawing.Point(451, 417);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(129, 20);
            this.labelLogo.TabIndex = 43;
            this.labelLogo.Text = "Imagem da Logo";
            this.labelLogo.Visible = false;
            // 
            // textBoxLogo
            // 
            this.textBoxLogo.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxLogo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogo.Location = new System.Drawing.Point(455, 440);
            this.textBoxLogo.MaxLength = 50;
            this.textBoxLogo.Name = "textBoxLogo";
            this.textBoxLogo.ReadOnly = true;
            this.textBoxLogo.Size = new System.Drawing.Size(244, 29);
            this.textBoxLogo.TabIndex = 42;
            this.textBoxLogo.Visible = false;
            // 
            // buttonSLogo
            // 
            this.buttonSLogo.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSLogo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSLogo.Location = new System.Drawing.Point(708, 440);
            this.buttonSLogo.Name = "buttonSLogo";
            this.buttonSLogo.Size = new System.Drawing.Size(84, 29);
            this.buttonSLogo.TabIndex = 44;
            this.buttonSLogo.Text = "Selecionar";
            this.buttonSLogo.UseVisualStyleBackColor = false;
            this.buttonSLogo.Visible = false;
            this.buttonSLogo.Click += new System.EventHandler(this.ButtonSLogo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.buttonSLogo);
            this.Controls.Add(this.labelLogo);
            this.Controls.Add(this.textBoxLogo);
            this.Controls.Add(this.labelFundo);
            this.Controls.Add(this.textBoxFundo);
            this.Controls.Add(this.buttonSFundo);
            this.Controls.Add(this.labelNascimento);
            this.Controls.Add(this.dateTimePickerNascimento);
            this.Controls.Add(this.comboBoxNomePopular);
            this.Controls.Add(this.labelNomePopular);
            this.Controls.Add(this.comboBoxSexo);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.comboBoxNomeF);
            this.Controls.Add(this.labelFilho);
            this.Controls.Add(this.labelMaeM);
            this.Controls.Add(this.labelPaiM);
            this.Controls.Add(this.comboBoxMae);
            this.Controls.Add(this.labelMaeP);
            this.Controls.Add(this.labelPaiP);
            this.Controls.Add(this.radioButtonArvore);
            this.Controls.Add(this.comboBoxPai);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.buttonPesquisa);
            this.Controls.Add(this.panelSelecionado);
            this.Controls.Add(this.panelLinha);
            this.Controls.Add(this.buttonCMenu);
            this.Controls.Add(this.radioButtonPais);
            this.Controls.Add(this.radioButtonPassaro);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelAniM);
            this.Controls.Add(this.textBoxAniM);
            this.Controls.Add(this.labelAniP);
            this.Controls.Add(this.textBoxAniP);
            this.Controls.Add(this.labelAniF);
            this.Controls.Add(this.textBoxAniF);
            this.Controls.Add(this.labelNMae);
            this.Controls.Add(this.labelNPai);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.buttonCadastrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Avatar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelNPai;
        private System.Windows.Forms.Label labelNMae;
        private System.Windows.Forms.Label labelAniF;
        private System.Windows.Forms.TextBox textBoxAniF;
        private System.Windows.Forms.Label labelAniP;
        private System.Windows.Forms.TextBox textBoxAniP;
        private System.Windows.Forms.Label labelAniM;
        private System.Windows.Forms.TextBox textBoxAniM;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.RadioButton radioButtonPassaro;
        private System.Windows.Forms.RadioButton radioButtonPais;
        private System.Windows.Forms.Button buttonCMenu;
        private System.Windows.Forms.Panel panelSelecionado;
        private System.Windows.Forms.Panel panelLinha;
        private System.Windows.Forms.Button buttonPesquisa;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.ComboBox comboBoxPai;
        private System.Windows.Forms.RadioButton radioButtonArvore;
        private System.Windows.Forms.Label labelPaiP;
        private System.Windows.Forms.Label labelMaeP;
        private System.Windows.Forms.ComboBox comboBoxMae;
        private System.Windows.Forms.Label labelPaiM;
        private System.Windows.Forms.Label labelMaeM;
        private System.Windows.Forms.Label labelFilho;
        private System.Windows.Forms.ComboBox comboBoxNomeF;
        private System.Windows.Forms.ComboBox comboBoxSexo;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.ComboBox comboBoxNomePopular;
        private System.Windows.Forms.Label labelNomePopular;
        private System.Windows.Forms.DateTimePicker dateTimePickerNascimento;
        private System.Windows.Forms.Label labelNascimento;
        private System.Windows.Forms.Button buttonSFundo;
        private System.Windows.Forms.Label labelFundo;
        private System.Windows.Forms.TextBox textBoxFundo;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.TextBox textBoxLogo;
        private System.Windows.Forms.Button buttonSLogo;
    }
}

