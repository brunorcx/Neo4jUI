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
            this.textBoxNomeF = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelNPai = new System.Windows.Forms.Label();
            this.textBoxNomePai = new System.Windows.Forms.TextBox();
            this.labelNMae = new System.Windows.Forms.Label();
            this.textBoxNomeMae = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCadastrar.Location = new System.Drawing.Point(39, 493);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(139, 38);
            this.buttonCadastrar.TabIndex = 1;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.Button_Cadastrar);
            // 
            // textBoxNomeF
            // 
            this.textBoxNomeF.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxNomeF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomeF.Location = new System.Drawing.Point(39, 243);
            this.textBoxNomeF.MaxLength = 50;
            this.textBoxNomeF.Name = "textBoxNomeF";
            this.textBoxNomeF.Size = new System.Drawing.Size(244, 29);
            this.textBoxNomeF.TabIndex = 2;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(35, 220);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(51, 20);
            this.labelNome.TabIndex = 6;
            this.labelNome.Text = "Nome";
            // 
            // labelNPai
            // 
            this.labelNPai.AutoSize = true;
            this.labelNPai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNPai.Location = new System.Drawing.Point(35, 301);
            this.labelNPai.Name = "labelNPai";
            this.labelNPai.Size = new System.Drawing.Size(98, 20);
            this.labelNPai.TabIndex = 8;
            this.labelNPai.Text = "Nome do pai";
            // 
            // textBoxNomePai
            // 
            this.textBoxNomePai.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxNomePai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomePai.Location = new System.Drawing.Point(39, 324);
            this.textBoxNomePai.MaxLength = 50;
            this.textBoxNomePai.Name = "textBoxNomePai";
            this.textBoxNomePai.Size = new System.Drawing.Size(244, 29);
            this.textBoxNomePai.TabIndex = 7;
            // 
            // labelNMae
            // 
            this.labelNMae.AutoSize = true;
            this.labelNMae.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNMae.Location = new System.Drawing.Point(35, 380);
            this.labelNMae.Name = "labelNMae";
            this.labelNMae.Size = new System.Drawing.Size(108, 20);
            this.labelNMae.TabIndex = 10;
            this.labelNMae.Text = "Nome da Mãe";
            // 
            // textBoxNomeMae
            // 
            this.textBoxNomeMae.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxNomeMae.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomeMae.Location = new System.Drawing.Point(39, 403);
            this.textBoxNomeMae.MaxLength = 50;
            this.textBoxNomeMae.Name = "textBoxNomeMae";
            this.textBoxNomeMae.Size = new System.Drawing.Size(244, 29);
            this.textBoxNomeMae.TabIndex = 9;
            // 
            // labelAniF
            // 
            this.labelAniF.AutoSize = true;
            this.labelAniF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAniF.Location = new System.Drawing.Point(451, 220);
            this.labelAniF.Name = "labelAniF";
            this.labelAniF.Size = new System.Drawing.Size(53, 20);
            this.labelAniF.TabIndex = 12;
            this.labelAniF.Text = "Anilha";
            // 
            // textBoxAniF
            // 
            this.textBoxAniF.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxAniF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAniF.Location = new System.Drawing.Point(455, 243);
            this.textBoxAniF.MaxLength = 50;
            this.textBoxAniF.Name = "textBoxAniF";
            this.textBoxAniF.Size = new System.Drawing.Size(244, 29);
            this.textBoxAniF.TabIndex = 11;
            // 
            // labelAniP
            // 
            this.labelAniP.AutoSize = true;
            this.labelAniP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAniP.Location = new System.Drawing.Point(451, 301);
            this.labelAniP.Name = "labelAniP";
            this.labelAniP.Size = new System.Drawing.Size(53, 20);
            this.labelAniP.TabIndex = 14;
            this.labelAniP.Text = "Anilha";
            // 
            // textBoxAniP
            // 
            this.textBoxAniP.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxAniP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAniP.Location = new System.Drawing.Point(455, 324);
            this.textBoxAniP.MaxLength = 50;
            this.textBoxAniP.Name = "textBoxAniP";
            this.textBoxAniP.Size = new System.Drawing.Size(244, 29);
            this.textBoxAniP.TabIndex = 13;
            // 
            // labelAniM
            // 
            this.labelAniM.AutoSize = true;
            this.labelAniM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAniM.Location = new System.Drawing.Point(451, 380);
            this.labelAniM.Name = "labelAniM";
            this.labelAniM.Size = new System.Drawing.Size(53, 20);
            this.labelAniM.TabIndex = 16;
            this.labelAniM.Text = "Anilha";
            // 
            // textBoxAniM
            // 
            this.textBoxAniM.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxAniM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAniM.Location = new System.Drawing.Point(455, 403);
            this.textBoxAniM.MaxLength = 50;
            this.textBoxAniM.Name = "textBoxAniM";
            this.textBoxAniM.Size = new System.Drawing.Size(244, 29);
            this.textBoxAniM.TabIndex = 15;
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
            this.radioButtonPassaro.Location = new System.Drawing.Point(39, 200);
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
            this.radioButtonPais.Location = new System.Drawing.Point(167, 200);
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
            this.buttonCMenu.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCMenu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCMenu.Location = new System.Drawing.Point(39, 53);
            this.buttonCMenu.Name = "buttonCMenu";
            this.buttonCMenu.Size = new System.Drawing.Size(85, 26);
            this.buttonCMenu.TabIndex = 20;
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
            this.buttonPesquisa.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPesquisa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisa.Location = new System.Drawing.Point(130, 53);
            this.buttonPesquisa.Name = "buttonPesquisa";
            this.buttonPesquisa.Size = new System.Drawing.Size(85, 26);
            this.buttonPesquisa.TabIndex = 23;
            this.buttonPesquisa.Text = "Pesquisar";
            this.buttonPesquisa.UseVisualStyleBackColor = false;
            this.buttonPesquisa.Click += new System.EventHandler(this.Pesquisa_MouseClick);
            this.buttonPesquisa.MouseEnter += new System.EventHandler(this.Pesquisa_MouseEnter);
            this.buttonPesquisa.MouseLeave += new System.EventHandler(this.Pesquisa_MouseLeave);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPesquisar.Location = new System.Drawing.Point(184, 493);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(139, 38);
            this.buttonPesquisar.TabIndex = 24;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = false;
            this.buttonPesquisar.Visible = false;
            this.buttonPesquisar.Click += new System.EventHandler(this.Pesquisar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 561);
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
            this.Controls.Add(this.textBoxNomeMae);
            this.Controls.Add(this.labelNPai);
            this.Controls.Add(this.textBoxNomePai);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxNomeF);
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
        private System.Windows.Forms.TextBox textBoxNomeF;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelNPai;
        private System.Windows.Forms.TextBox textBoxNomePai;
        private System.Windows.Forms.Label labelNMae;
        private System.Windows.Forms.TextBox textBoxNomeMae;
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
    }
}

