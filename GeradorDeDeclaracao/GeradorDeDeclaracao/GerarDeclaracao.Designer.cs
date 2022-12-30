namespace GeradorDeDeclaracao
{
    partial class frmGerarDeclacarao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerarDeclacarao));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.grpConteudo = new System.Windows.Forms.GroupBox();
            this.grpPesquisar = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFuncionarios = new System.Windows.Forms.DataGridView();
            this.grpAdionar = new System.Windows.Forms.GroupBox();
            this.txtOutro = new System.Windows.Forms.TextBox();
            this.radOutro = new System.Windows.Forms.RadioButton();
            this.radRetornoAlmoco = new System.Windows.Forms.RadioButton();
            this.radSaidaExpediente = new System.Windows.Forms.RadioButton();
            this.radSaidaAlmoco = new System.Windows.Forms.RadioButton();
            this.radEntrada = new System.Windows.Forms.RadioButton();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnAdcionar = new System.Windows.Forms.Button();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.listFuncionario = new System.Windows.Forms.ListView();
            this.columnFunc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSetor = new System.Windows.Forms.TextBox();
            this.lblCracha = new System.Windows.Forms.Label();
            this.lblSetor = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtCracha = new System.Windows.Forms.TextBox();
            this.grpTitulo = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnGerarTudo = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.grpConteudo.SuspendLayout();
            this.grpPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFuncionarios)).BeginInit();
            this.grpAdionar.SuspendLayout();
            this.grpTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.BackColor = System.Drawing.Color.Navy;
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVoltar.FlatAppearance.BorderSize = 2;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(603, 664);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(160, 21);
            this.btnVoltar.TabIndex = 28;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // grpConteudo
            // 
            this.grpConteudo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpConteudo.Controls.Add(this.grpPesquisar);
            this.grpConteudo.Controls.Add(this.grpAdionar);
            this.grpConteudo.Location = new System.Drawing.Point(12, 76);
            this.grpConteudo.Name = "grpConteudo";
            this.grpConteudo.Size = new System.Drawing.Size(1098, 573);
            this.grpConteudo.TabIndex = 31;
            this.grpConteudo.TabStop = false;
            // 
            // grpPesquisar
            // 
            this.grpPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpPesquisar.Controls.Add(this.lblFuncionario);
            this.grpPesquisar.Controls.Add(this.btnPesquisar);
            this.grpPesquisar.Controls.Add(this.txtPesquisa);
            this.grpPesquisar.Controls.Add(this.label3);
            this.grpPesquisar.Controls.Add(this.dtFuncionarios);
            this.grpPesquisar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grpPesquisar.Location = new System.Drawing.Point(529, 30);
            this.grpPesquisar.Name = "grpPesquisar";
            this.grpPesquisar.Size = new System.Drawing.Size(548, 520);
            this.grpPesquisar.TabIndex = 47;
            this.grpPesquisar.TabStop = false;
            this.grpPesquisar.Text = "Pesquisar";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisar.BackColor = System.Drawing.Color.Navy;
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisar.FlatAppearance.BorderSize = 2;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(449, 32);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(76, 21);
            this.btnPesquisar.TabIndex = 49;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(75, 32);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(368, 20);
            this.txtPesquisa.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(21, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Nome";
            // 
            // dtFuncionarios
            // 
            this.dtFuncionarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtFuncionarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtFuncionarios.Location = new System.Drawing.Point(22, 81);
            this.dtFuncionarios.Name = "dtFuncionarios";
            this.dtFuncionarios.Size = new System.Drawing.Size(501, 387);
            this.dtFuncionarios.TabIndex = 46;
            this.dtFuncionarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtFuncionarios_CellContentClick);
            // 
            // grpAdionar
            // 
            this.grpAdionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpAdionar.Controls.Add(this.lblLista);
            this.grpAdionar.Controls.Add(this.txtOutro);
            this.grpAdionar.Controls.Add(this.radOutro);
            this.grpAdionar.Controls.Add(this.radRetornoAlmoco);
            this.grpAdionar.Controls.Add(this.radSaidaExpediente);
            this.grpAdionar.Controls.Add(this.radSaidaAlmoco);
            this.grpAdionar.Controls.Add(this.radEntrada);
            this.grpAdionar.Controls.Add(this.lblMotivo);
            this.grpAdionar.Controls.Add(this.lblNome);
            this.grpAdionar.Controls.Add(this.txtNome);
            this.grpAdionar.Controls.Add(this.btnRemover);
            this.grpAdionar.Controls.Add(this.btnGerar);
            this.grpAdionar.Controls.Add(this.btnAdcionar);
            this.grpAdionar.Controls.Add(this.txtCargo);
            this.grpAdionar.Controls.Add(this.listFuncionario);
            this.grpAdionar.Controls.Add(this.txtSetor);
            this.grpAdionar.Controls.Add(this.lblCracha);
            this.grpAdionar.Controls.Add(this.lblSetor);
            this.grpAdionar.Controls.Add(this.lblCargo);
            this.grpAdionar.Controls.Add(this.txtCracha);
            this.grpAdionar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grpAdionar.Location = new System.Drawing.Point(21, 30);
            this.grpAdionar.Name = "grpAdionar";
            this.grpAdionar.Size = new System.Drawing.Size(502, 520);
            this.grpAdionar.TabIndex = 46;
            this.grpAdionar.TabStop = false;
            this.grpAdionar.Text = "Adcionar";
            // 
            // txtOutro
            // 
            this.txtOutro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOutro.Enabled = false;
            this.txtOutro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutro.Location = new System.Drawing.Point(189, 178);
            this.txtOutro.Name = "txtOutro";
            this.txtOutro.Size = new System.Drawing.Size(291, 20);
            this.txtOutro.TabIndex = 62;
            // 
            // radOutro
            // 
            this.radOutro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radOutro.AutoSize = true;
            this.radOutro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOutro.ForeColor = System.Drawing.Color.Navy;
            this.radOutro.Location = new System.Drawing.Point(121, 177);
            this.radOutro.Name = "radOutro";
            this.radOutro.Size = new System.Drawing.Size(62, 19);
            this.radOutro.TabIndex = 61;
            this.radOutro.TabStop = true;
            this.radOutro.Text = "Outro";
            this.radOutro.UseVisualStyleBackColor = true;
            this.radOutro.CheckedChanged += new System.EventHandler(this.radOutro_CheckedChanged);
            // 
            // radRetornoAlmoco
            // 
            this.radRetornoAlmoco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radRetornoAlmoco.AutoSize = true;
            this.radRetornoAlmoco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRetornoAlmoco.ForeColor = System.Drawing.Color.Navy;
            this.radRetornoAlmoco.Location = new System.Drawing.Point(121, 152);
            this.radRetornoAlmoco.Name = "radRetornoAlmoco";
            this.radRetornoAlmoco.Size = new System.Drawing.Size(129, 19);
            this.radRetornoAlmoco.TabIndex = 60;
            this.radRetornoAlmoco.TabStop = true;
            this.radRetornoAlmoco.Text = "Retorno Almoço";
            this.radRetornoAlmoco.UseVisualStyleBackColor = true;
            this.radRetornoAlmoco.CheckedChanged += new System.EventHandler(this.radRetornoAlmoco_CheckedChanged);
            // 
            // radSaidaExpediente
            // 
            this.radSaidaExpediente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radSaidaExpediente.AutoSize = true;
            this.radSaidaExpediente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSaidaExpediente.ForeColor = System.Drawing.Color.Navy;
            this.radSaidaExpediente.Location = new System.Drawing.Point(291, 152);
            this.radSaidaExpediente.Name = "radSaidaExpediente";
            this.radSaidaExpediente.Size = new System.Drawing.Size(138, 19);
            this.radSaidaExpediente.TabIndex = 59;
            this.radSaidaExpediente.TabStop = true;
            this.radSaidaExpediente.Text = "Saida Expediente";
            this.radSaidaExpediente.UseVisualStyleBackColor = true;
            this.radSaidaExpediente.CheckedChanged += new System.EventHandler(this.radSaidaExpediente_CheckedChanged);
            // 
            // radSaidaAlmoco
            // 
            this.radSaidaAlmoco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radSaidaAlmoco.AutoSize = true;
            this.radSaidaAlmoco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSaidaAlmoco.ForeColor = System.Drawing.Color.Navy;
            this.radSaidaAlmoco.Location = new System.Drawing.Point(291, 128);
            this.radSaidaAlmoco.Name = "radSaidaAlmoco";
            this.radSaidaAlmoco.Size = new System.Drawing.Size(114, 19);
            this.radSaidaAlmoco.TabIndex = 58;
            this.radSaidaAlmoco.TabStop = true;
            this.radSaidaAlmoco.Text = "Saida Almoço";
            this.radSaidaAlmoco.UseVisualStyleBackColor = true;
            this.radSaidaAlmoco.CheckedChanged += new System.EventHandler(this.radSaidaAlmoco_CheckedChanged);
            // 
            // radEntrada
            // 
            this.radEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radEntrada.AutoSize = true;
            this.radEntrada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEntrada.ForeColor = System.Drawing.Color.Navy;
            this.radEntrada.Location = new System.Drawing.Point(121, 128);
            this.radEntrada.Name = "radEntrada";
            this.radEntrada.Size = new System.Drawing.Size(153, 19);
            this.radEntrada.TabIndex = 57;
            this.radEntrada.TabStop = true;
            this.radEntrada.Text = "Entrada Expediente";
            this.radEntrada.UseVisualStyleBackColor = true;
            this.radEntrada.CheckedChanged += new System.EventHandler(this.radEntrada_CheckedChanged);
            // 
            // lblMotivo
            // 
            this.lblMotivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.ForeColor = System.Drawing.Color.Navy;
            this.lblMotivo.Location = new System.Drawing.Point(17, 138);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(57, 16);
            this.lblMotivo.TabIndex = 56;
            this.lblMotivo.Text = "Motivo:";
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Navy;
            this.lblNome.Location = new System.Drawing.Point(17, 33);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 16);
            this.lblNome.TabIndex = 35;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(79, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(350, 21);
            this.txtNome.TabIndex = 37;
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemover.BackColor = System.Drawing.Color.Navy;
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemover.FlatAppearance.BorderSize = 2;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemover.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(261, 476);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(104, 21);
            this.btnRemover.TabIndex = 35;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerar.BackColor = System.Drawing.Color.Navy;
            this.btnGerar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGerar.FlatAppearance.BorderSize = 2;
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.ForeColor = System.Drawing.Color.White;
            this.btnGerar.Location = new System.Drawing.Point(121, 476);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(104, 21);
            this.btnGerar.TabIndex = 34;
            this.btnGerar.Text = "Gerar ";
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click_1);
            // 
            // btnAdcionar
            // 
            this.btnAdcionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdcionar.BackColor = System.Drawing.Color.Navy;
            this.btnAdcionar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdcionar.FlatAppearance.BorderSize = 2;
            this.btnAdcionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdcionar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdcionar.ForeColor = System.Drawing.Color.White;
            this.btnAdcionar.Location = new System.Drawing.Point(435, 32);
            this.btnAdcionar.Name = "btnAdcionar";
            this.btnAdcionar.Size = new System.Drawing.Size(45, 21);
            this.btnAdcionar.TabIndex = 51;
            this.btnAdcionar.Text = "Add";
            this.btnAdcionar.UseVisualStyleBackColor = false;
            this.btnAdcionar.Click += new System.EventHandler(this.btnAdcionar_Click);
            // 
            // txtCargo
            // 
            this.txtCargo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCargo.Enabled = false;
            this.txtCargo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(79, 94);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(401, 21);
            this.txtCargo.TabIndex = 41;
            // 
            // listFuncionario
            // 
            this.listFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listFuncionario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFunc});
            this.listFuncionario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFuncionario.HideSelection = false;
            this.listFuncionario.Location = new System.Drawing.Point(20, 230);
            this.listFuncionario.Name = "listFuncionario";
            this.listFuncionario.Size = new System.Drawing.Size(460, 238);
            this.listFuncionario.TabIndex = 43;
            this.listFuncionario.UseCompatibleStateImageBehavior = false;
            this.listFuncionario.View = System.Windows.Forms.View.Details;
            // 
            // columnFunc
            // 
            this.columnFunc.Text = "Funcionario";
            this.columnFunc.Width = 455;
            // 
            // txtSetor
            // 
            this.txtSetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSetor.Enabled = false;
            this.txtSetor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetor.Location = new System.Drawing.Point(216, 61);
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.Size = new System.Drawing.Size(264, 21);
            this.txtSetor.TabIndex = 40;
            // 
            // lblCracha
            // 
            this.lblCracha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCracha.AutoSize = true;
            this.lblCracha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCracha.ForeColor = System.Drawing.Color.Navy;
            this.lblCracha.Location = new System.Drawing.Point(17, 62);
            this.lblCracha.Name = "lblCracha";
            this.lblCracha.Size = new System.Drawing.Size(56, 16);
            this.lblCracha.TabIndex = 34;
            this.lblCracha.Text = "Cracha";
            // 
            // lblSetor
            // 
            this.lblSetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSetor.AutoSize = true;
            this.lblSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetor.ForeColor = System.Drawing.Color.Navy;
            this.lblSetor.Location = new System.Drawing.Point(166, 62);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(44, 16);
            this.lblSetor.TabIndex = 38;
            this.lblSetor.Text = "Setor";
            // 
            // lblCargo
            // 
            this.lblCargo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.Navy;
            this.lblCargo.Location = new System.Drawing.Point(17, 95);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(49, 16);
            this.lblCargo.TabIndex = 39;
            this.lblCargo.Text = "Cargo";
            // 
            // txtCracha
            // 
            this.txtCracha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCracha.Enabled = false;
            this.txtCracha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCracha.Location = new System.Drawing.Point(79, 61);
            this.txtCracha.Name = "txtCracha";
            this.txtCracha.Size = new System.Drawing.Size(81, 21);
            this.txtCracha.TabIndex = 36;
            // 
            // grpTitulo
            // 
            this.grpTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpTitulo.Controls.Add(this.lblTitulo);
            this.grpTitulo.Location = new System.Drawing.Point(12, 12);
            this.grpTitulo.Name = "grpTitulo";
            this.grpTitulo.Size = new System.Drawing.Size(1098, 58);
            this.grpTitulo.TabIndex = 32;
            this.grpTitulo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitulo.Location = new System.Drawing.Point(423, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(190, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gerar Declaração";
            // 
            // btnGerarTudo
            // 
            this.btnGerarTudo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerarTudo.BackColor = System.Drawing.Color.Navy;
            this.btnGerarTudo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGerarTudo.FlatAppearance.BorderSize = 2;
            this.btnGerarTudo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerarTudo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarTudo.ForeColor = System.Drawing.Color.White;
            this.btnGerarTudo.Location = new System.Drawing.Point(412, 664);
            this.btnGerarTudo.Name = "btnGerarTudo";
            this.btnGerarTudo.Size = new System.Drawing.Size(160, 21);
            this.btnGerarTudo.TabIndex = 33;
            this.btnGerarTudo.Text = "Gerar tudo";
            this.btnGerarTudo.UseVisualStyleBackColor = false;
            this.btnGerarTudo.Click += new System.EventHandler(this.btnGerarTudo_Click);
            // 
            // lblLista
            // 
            this.lblLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.ForeColor = System.Drawing.Color.Navy;
            this.lblLista.Location = new System.Drawing.Point(17, 211);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(154, 16);
            this.lblLista.TabIndex = 63;
            this.lblLista.Text = "Lista de funcionários:";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionario.ForeColor = System.Drawing.Color.Navy;
            this.lblFuncionario.Location = new System.Drawing.Point(19, 62);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(92, 16);
            this.lblFuncionario.TabIndex = 64;
            this.lblFuncionario.Text = "Funcionario:";
            // 
            // frmGerarDeclacarao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 708);
            this.Controls.Add(this.btnGerarTudo);
            this.Controls.Add(this.grpTitulo);
            this.Controls.Add(this.grpConteudo);
            this.Controls.Add(this.btnVoltar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGerarDeclacarao";
            this.Text = "Gerar Declaracao";
            this.Load += new System.EventHandler(this.frmGerarDeclacarao_Load);
            this.grpConteudo.ResumeLayout(false);
            this.grpPesquisar.ResumeLayout(false);
            this.grpPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFuncionarios)).EndInit();
            this.grpAdionar.ResumeLayout(false);
            this.grpAdionar.PerformLayout();
            this.grpTitulo.ResumeLayout(false);
            this.grpTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox grpConteudo;
        private System.Windows.Forms.GroupBox grpTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnGerarTudo;
        private System.Windows.Forms.GroupBox grpPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtFuncionarios;
        private System.Windows.Forms.GroupBox grpAdionar;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnAdcionar;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.ListView listFuncionario;
        private System.Windows.Forms.ColumnHeader columnFunc;
        private System.Windows.Forms.TextBox txtSetor;
        private System.Windows.Forms.Label lblCracha;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtCracha;
        private System.Windows.Forms.RadioButton radSaidaExpediente;
        private System.Windows.Forms.RadioButton radSaidaAlmoco;
        private System.Windows.Forms.RadioButton radEntrada;
        private System.Windows.Forms.RadioButton radRetornoAlmoco;
        private System.Windows.Forms.RadioButton radOutro;
        private System.Windows.Forms.TextBox txtOutro;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Label lblFuncionario;
    }
}