namespace ZLProject
{
    partial class frmCadastrarOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarOS));
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.cmbCarregarClientes = new System.Windows.Forms.ComboBox();
            this.txtEmail_2OS = new System.Windows.Forms.TextBox();
            this.txtMunicipioOS = new System.Windows.Forms.TextBox();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail_2 = new System.Windows.Forms.Label();
            this.txtCNPJOS = new System.Windows.Forms.TextBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.txtEmailOS = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefone2OS = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefoneOS = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEnderecoOS = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtEstadoOS = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtIEOS = new System.Windows.Forms.TextBox();
            this.txtBairroOS = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblIE = new System.Windows.Forms.Label();
            this.txtCEPOS = new System.Windows.Forms.TextBox();
            this.grpProdutos = new System.Windows.Forms.GroupBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cmbCarregarProdutos = new System.Windows.Forms.ComboBox();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnAddProdutos = new System.Windows.Forms.Button();
            this.dgvAddProdutos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpOcorrencia = new System.Windows.Forms.GroupBox();
            this.txtOcorrenciaOS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTecnico = new System.Windows.Forms.TextBox();
            this.txtEmitidopor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpPagamento = new System.Windows.Forms.GroupBox();
            this.txtFormaPag = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblZL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNumOS = new System.Windows.Forms.TextBox();
            this.txtDataOS = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.grpOS = new System.Windows.Forms.GroupBox();
            this.PPDFormOS = new System.Windows.Forms.PrintPreviewDialog();
            this.DocumentoOS = new System.Drawing.Printing.PrintDocument();
            this.grpCliente.SuspendLayout();
            this.grpProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddProdutos)).BeginInit();
            this.grpOcorrencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpOS.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.cmbCarregarClientes);
            this.grpCliente.Controls.Add(this.txtEmail_2OS);
            this.grpCliente.Controls.Add(this.txtMunicipioOS);
            this.grpCliente.Controls.Add(this.lblMunicipio);
            this.grpCliente.Controls.Add(this.lblName);
            this.grpCliente.Controls.Add(this.lblEmail_2);
            this.grpCliente.Controls.Add(this.txtCNPJOS);
            this.grpCliente.Controls.Add(this.lblCNPJ);
            this.grpCliente.Controls.Add(this.txtEmailOS);
            this.grpCliente.Controls.Add(this.lblEmail);
            this.grpCliente.Controls.Add(this.txtTelefone2OS);
            this.grpCliente.Controls.Add(this.lblTelefone);
            this.grpCliente.Controls.Add(this.txtTelefoneOS);
            this.grpCliente.Controls.Add(this.lblEndereco);
            this.grpCliente.Controls.Add(this.txtEnderecoOS);
            this.grpCliente.Controls.Add(this.lblCelular);
            this.grpCliente.Controls.Add(this.txtEstadoOS);
            this.grpCliente.Controls.Add(this.lblEstado);
            this.grpCliente.Controls.Add(this.lblBairro);
            this.grpCliente.Controls.Add(this.txtIEOS);
            this.grpCliente.Controls.Add(this.txtBairroOS);
            this.grpCliente.Controls.Add(this.lblCEP);
            this.grpCliente.Controls.Add(this.lblIE);
            this.grpCliente.Controls.Add(this.txtCEPOS);
            this.grpCliente.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCliente.Location = new System.Drawing.Point(7, 79);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(587, 254);
            this.grpCliente.TabIndex = 1;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Selecione o Cliente";
            // 
            // cmbCarregarClientes
            // 
            this.cmbCarregarClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCarregarClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCarregarClientes.FormattingEnabled = true;
            this.cmbCarregarClientes.Location = new System.Drawing.Point(10, 37);
            this.cmbCarregarClientes.Name = "cmbCarregarClientes";
            this.cmbCarregarClientes.Size = new System.Drawing.Size(567, 23);
            this.cmbCarregarClientes.TabIndex = 55;
            this.cmbCarregarClientes.SelectedIndexChanged += new System.EventHandler(this.cmbCarregarClientes_SelectedIndexChanged);
            this.cmbCarregarClientes.SelectedValueChanged += new System.EventHandler(this.cmbCarregarClientes_SelectedValueChanged);
            // 
            // txtEmail_2OS
            // 
            this.txtEmail_2OS.Location = new System.Drawing.Point(58, 226);
            this.txtEmail_2OS.Name = "txtEmail_2OS";
            this.txtEmail_2OS.Size = new System.Drawing.Size(519, 22);
            this.txtEmail_2OS.TabIndex = 44;
            // 
            // txtMunicipioOS
            // 
            this.txtMunicipioOS.Location = new System.Drawing.Point(10, 169);
            this.txtMunicipioOS.Name = "txtMunicipioOS";
            this.txtMunicipioOS.Size = new System.Drawing.Size(162, 22);
            this.txtMunicipioOS.TabIndex = 35;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipio.Location = new System.Drawing.Point(7, 149);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(62, 17);
            this.lblMunicipio.TabIndex = 42;
            this.lblMunicipio.Text = "Município";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(6, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 17);
            this.lblName.TabIndex = 39;
            this.lblName.Text = "Nome";
            // 
            // lblEmail_2
            // 
            this.lblEmail_2.AutoSize = true;
            this.lblEmail_2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail_2.Location = new System.Drawing.Point(7, 229);
            this.lblEmail_2.Name = "lblEmail_2";
            this.lblEmail_2.Size = new System.Drawing.Size(45, 17);
            this.lblEmail_2.TabIndex = 54;
            this.lblEmail_2.Text = "E-mail ";
            // 
            // txtCNPJOS
            // 
            this.txtCNPJOS.Location = new System.Drawing.Point(10, 126);
            this.txtCNPJOS.MaxLength = 18;
            this.txtCNPJOS.Name = "txtCNPJOS";
            this.txtCNPJOS.Size = new System.Drawing.Size(162, 22);
            this.txtCNPJOS.TabIndex = 36;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.Location = new System.Drawing.Point(7, 106);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(40, 17);
            this.lblCNPJ.TabIndex = 49;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // txtEmailOS
            // 
            this.txtEmailOS.Location = new System.Drawing.Point(58, 202);
            this.txtEmailOS.Name = "txtEmailOS";
            this.txtEmailOS.Size = new System.Drawing.Size(519, 22);
            this.txtEmailOS.TabIndex = 43;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(7, 205);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 17);
            this.lblEmail.TabIndex = 53;
            this.lblEmail.Text = "E-mail ";
            // 
            // txtTelefone2OS
            // 
            this.txtTelefone2OS.Location = new System.Drawing.Point(380, 169);
            this.txtTelefone2OS.Name = "txtTelefone2OS";
            this.txtTelefone2OS.Size = new System.Drawing.Size(197, 22);
            this.txtTelefone2OS.TabIndex = 41;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(377, 149);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(59, 17);
            this.lblTelefone.TabIndex = 52;
            this.lblTelefone.Text = "Telefone ";
            // 
            // txtTelefoneOS
            // 
            this.txtTelefoneOS.Location = new System.Drawing.Point(380, 126);
            this.txtTelefoneOS.Name = "txtTelefoneOS";
            this.txtTelefoneOS.Size = new System.Drawing.Size(197, 22);
            this.txtTelefoneOS.TabIndex = 40;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(7, 63);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(58, 17);
            this.lblEndereco.TabIndex = 48;
            this.lblEndereco.Text = "Endereco";
            // 
            // txtEnderecoOS
            // 
            this.txtEnderecoOS.Location = new System.Drawing.Point(10, 83);
            this.txtEnderecoOS.Name = "txtEnderecoOS";
            this.txtEnderecoOS.Size = new System.Drawing.Size(162, 22);
            this.txtEnderecoOS.TabIndex = 32;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(377, 106);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(47, 17);
            this.lblCelular.TabIndex = 51;
            this.lblCelular.Text = "Celular";
            // 
            // txtEstadoOS
            // 
            this.txtEstadoOS.Location = new System.Drawing.Point(192, 169);
            this.txtEstadoOS.MaxLength = 2;
            this.txtEstadoOS.Name = "txtEstadoOS";
            this.txtEstadoOS.Size = new System.Drawing.Size(166, 22);
            this.txtEstadoOS.TabIndex = 38;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(189, 149);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(44, 17);
            this.lblEstado.TabIndex = 45;
            this.lblEstado.Text = "Estado";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(189, 63);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(42, 17);
            this.lblBairro.TabIndex = 47;
            this.lblBairro.Text = "Bairro";
            // 
            // txtIEOS
            // 
            this.txtIEOS.Location = new System.Drawing.Point(192, 126);
            this.txtIEOS.MaxLength = 15;
            this.txtIEOS.Name = "txtIEOS";
            this.txtIEOS.Size = new System.Drawing.Size(166, 22);
            this.txtIEOS.TabIndex = 37;
            // 
            // txtBairroOS
            // 
            this.txtBairroOS.Location = new System.Drawing.Point(192, 83);
            this.txtBairroOS.Name = "txtBairroOS";
            this.txtBairroOS.Size = new System.Drawing.Size(166, 22);
            this.txtBairroOS.TabIndex = 33;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(378, 63);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(32, 17);
            this.lblCEP.TabIndex = 46;
            this.lblCEP.Text = "CEP";
            // 
            // lblIE
            // 
            this.lblIE.AutoSize = true;
            this.lblIE.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIE.Location = new System.Drawing.Point(189, 106);
            this.lblIE.Name = "lblIE";
            this.lblIE.Size = new System.Drawing.Size(20, 17);
            this.lblIE.TabIndex = 50;
            this.lblIE.Text = "IE";
            // 
            // txtCEPOS
            // 
            this.txtCEPOS.Location = new System.Drawing.Point(380, 83);
            this.txtCEPOS.MaxLength = 9;
            this.txtCEPOS.Name = "txtCEPOS";
            this.txtCEPOS.Size = new System.Drawing.Size(197, 22);
            this.txtCEPOS.TabIndex = 34;
            // 
            // grpProdutos
            // 
            this.grpProdutos.Controls.Add(this.txtQuantidade);
            this.grpProdutos.Controls.Add(this.lblX);
            this.grpProdutos.Controls.Add(this.lblPreco);
            this.grpProdutos.Controls.Add(this.txtTotal);
            this.grpProdutos.Controls.Add(this.cmbCarregarProdutos);
            this.grpProdutos.Controls.Add(this.btnRetirar);
            this.grpProdutos.Controls.Add(this.btnAddProdutos);
            this.grpProdutos.Controls.Add(this.dgvAddProdutos);
            this.grpProdutos.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProdutos.Location = new System.Drawing.Point(614, 6);
            this.grpProdutos.Name = "grpProdutos";
            this.grpProdutos.Size = new System.Drawing.Size(425, 270);
            this.grpProdutos.TabIndex = 2;
            this.grpProdutos.TabStop = false;
            this.grpProdutos.Text = "Selecione os Produtos";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(314, 32);
            this.txtQuantidade.MaxLength = 15;
            this.txtQuantidade.Multiline = true;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(60, 26);
            this.txtQuantidade.TabIndex = 56;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(291, 36);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 18);
            this.lblX.TabIndex = 57;
            this.lblX.Text = "X";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(195, 238);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(88, 21);
            this.lblPreco.TabIndex = 56;
            this.lblPreco.Text = "Preço Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(289, 233);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(90, 30);
            this.txtTotal.TabIndex = 60;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // cmbCarregarProdutos
            // 
            this.cmbCarregarProdutos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCarregarProdutos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCarregarProdutos.FormattingEnabled = true;
            this.cmbCarregarProdutos.Location = new System.Drawing.Point(6, 34);
            this.cmbCarregarProdutos.Name = "cmbCarregarProdutos";
            this.cmbCarregarProdutos.Size = new System.Drawing.Size(278, 23);
            this.cmbCarregarProdutos.TabIndex = 6;
            this.cmbCarregarProdutos.SelectedIndexChanged += new System.EventHandler(this.cmbCarregarProdutos_SelectedIndexChanged);
            this.cmbCarregarProdutos.SelectedValueChanged += new System.EventHandler(this.cmbProdutos_SelectedValueChanged);
            // 
            // btnRetirar
            // 
            this.btnRetirar.Image = ((System.Drawing.Image)(resources.GetObject("btnRetirar.Image")));
            this.btnRetirar.Location = new System.Drawing.Point(385, 106);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(38, 33);
            this.btnRetirar.TabIndex = 5;
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // btnAddProdutos
            // 
            this.btnAddProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProdutos.Image")));
            this.btnAddProdutos.Location = new System.Drawing.Point(385, 67);
            this.btnAddProdutos.Name = "btnAddProdutos";
            this.btnAddProdutos.Size = new System.Drawing.Size(38, 33);
            this.btnAddProdutos.TabIndex = 4;
            this.btnAddProdutos.UseVisualStyleBackColor = true;
            this.btnAddProdutos.Click += new System.EventHandler(this.btnAddProdutos_Click);
            // 
            // dgvAddProdutos
            // 
            this.dgvAddProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descricao,
            this.Valor,
            this.Qtd});
            this.dgvAddProdutos.Location = new System.Drawing.Point(6, 64);
            this.dgvAddProdutos.Name = "dgvAddProdutos";
            this.dgvAddProdutos.Size = new System.Drawing.Size(373, 161);
            this.dgvAddProdutos.TabIndex = 3;
            this.dgvAddProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddProdutos_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 70;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 190;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.Width = 80;
            // 
            // Qtd
            // 
            this.Qtd.HeaderText = "Qtd";
            this.Qtd.Name = "Qtd";
            // 
            // grpOcorrencia
            // 
            this.grpOcorrencia.Controls.Add(this.txtOcorrenciaOS);
            this.grpOcorrencia.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOcorrencia.Location = new System.Drawing.Point(7, 339);
            this.grpOcorrencia.Name = "grpOcorrencia";
            this.grpOcorrencia.Size = new System.Drawing.Size(587, 180);
            this.grpOcorrencia.TabIndex = 3;
            this.grpOcorrencia.TabStop = false;
            this.grpOcorrencia.Text = "Ocorrências";
            // 
            // txtOcorrenciaOS
            // 
            this.txtOcorrenciaOS.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOcorrenciaOS.Location = new System.Drawing.Point(5, 21);
            this.txtOcorrenciaOS.Multiline = true;
            this.txtOcorrenciaOS.Name = "txtOcorrenciaOS";
            this.txtOcorrenciaOS.Size = new System.Drawing.Size(576, 153);
            this.txtOcorrenciaOS.TabIndex = 0;
            this.txtOcorrenciaOS.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(624, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 61;
            this.label1.Text = "Técnico Responsável:";
            // 
            // txtTecnico
            // 
            this.txtTecnico.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTecnico.Location = new System.Drawing.Point(623, 399);
            this.txtTecnico.Name = "txtTecnico";
            this.txtTecnico.Size = new System.Drawing.Size(157, 28);
            this.txtTecnico.TabIndex = 56;
            // 
            // txtEmitidopor
            // 
            this.txtEmitidopor.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmitidopor.Location = new System.Drawing.Point(791, 399);
            this.txtEmitidopor.Name = "txtEmitidopor";
            this.txtEmitidopor.Size = new System.Drawing.Size(149, 28);
            this.txtEmitidopor.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(792, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 63;
            this.label2.Text = "Emitido Por:";
            // 
            // grpPagamento
            // 
            this.grpPagamento.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPagamento.Location = new System.Drawing.Point(614, 284);
            this.grpPagamento.Name = "grpPagamento";
            this.grpPagamento.Size = new System.Drawing.Size(425, 64);
            this.grpPagamento.TabIndex = 64;
            this.grpPagamento.TabStop = false;
            this.grpPagamento.Text = "Forma de Pagamento";
            // 
            // txtFormaPag
            // 
            this.txtFormaPag.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormaPag.Location = new System.Drawing.Point(620, 303);
            this.txtFormaPag.Multiline = true;
            this.txtFormaPag.Name = "txtFormaPag";
            this.txtFormaPag.Size = new System.Drawing.Size(412, 34);
            this.txtFormaPag.TabIndex = 1;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Silver;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(620, 450);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(125, 39);
            this.btnLimpar.TabIndex = 66;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.Silver;
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.Black;
            this.btnFinalizar.Location = new System.Drawing.Point(763, 450);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(125, 39);
            this.btnFinalizar.TabIndex = 67;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Silver;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.Location = new System.Drawing.Point(912, 450);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(125, 39);
            this.btnVoltar.TabIndex = 68;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblZL
            // 
            this.lblZL.AutoSize = true;
            this.lblZL.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZL.Location = new System.Drawing.Point(411, 28);
            this.lblZL.Name = "lblZL";
            this.lblZL.Size = new System.Drawing.Size(183, 37);
            this.lblZL.TabIndex = 69;
            this.lblZL.Text = "Z.L. Balanças";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(415, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 2);
            this.panel1.TabIndex = 70;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(318, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // txtNumOS
            // 
            this.txtNumOS.Location = new System.Drawing.Point(9, 31);
            this.txtNumOS.Name = "txtNumOS";
            this.txtNumOS.ReadOnly = true;
            this.txtNumOS.Size = new System.Drawing.Size(85, 22);
            this.txtNumOS.TabIndex = 56;
            // 
            // txtDataOS
            // 
            this.txtDataOS.Location = new System.Drawing.Point(192, 31);
            this.txtDataOS.Name = "txtDataOS";
            this.txtDataOS.Size = new System.Drawing.Size(100, 22);
            this.txtDataOS.TabIndex = 56;
            this.txtDataOS.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(147, 33);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(37, 17);
            this.lblData.TabIndex = 56;
            this.lblData.Text = "Data:";
            // 
            // grpOS
            // 
            this.grpOS.Controls.Add(this.lblData);
            this.grpOS.Controls.Add(this.txtDataOS);
            this.grpOS.Controls.Add(this.txtNumOS);
            this.grpOS.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOS.Location = new System.Drawing.Point(7, 6);
            this.grpOS.Name = "grpOS";
            this.grpOS.Size = new System.Drawing.Size(305, 69);
            this.grpOS.TabIndex = 0;
            this.grpOS.TabStop = false;
            this.grpOS.Text = "Ordem de Serviço";
            // 
            // PPDFormOS
            // 
            this.PPDFormOS.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PPDFormOS.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PPDFormOS.ClientSize = new System.Drawing.Size(400, 300);
            this.PPDFormOS.Document = this.DocumentoOS;
            this.PPDFormOS.Enabled = true;
            this.PPDFormOS.Icon = ((System.Drawing.Icon)(resources.GetObject("PPDFormOS.Icon")));
            this.PPDFormOS.Name = "PPDFormOS";
            this.PPDFormOS.Visible = false;
            this.PPDFormOS.Load += new System.EventHandler(this.PPDFormOS_Load);
            // 
            // DocumentoOS
            // 
            this.DocumentoOS.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.DocumentoOS_PrintPage);
            // 
            // frmCadastrarOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1062, 527);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblZL);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtFormaPag);
            this.Controls.Add(this.grpPagamento);
            this.Controls.Add(this.txtEmitidopor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTecnico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpOcorrencia);
            this.Controls.Add(this.grpProdutos);
            this.Controls.Add(this.grpCliente);
            this.Controls.Add(this.grpOS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCadastrarOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmCadastrarOS_Load);
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.grpProdutos.ResumeLayout(false);
            this.grpProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddProdutos)).EndInit();
            this.grpOcorrencia.ResumeLayout(false);
            this.grpOcorrencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpOS.ResumeLayout(false);
            this.grpOS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.ComboBox cmbCarregarClientes;
        private System.Windows.Forms.TextBox txtEmail_2OS;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail_2;
        private System.Windows.Forms.TextBox txtEmailOS;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTelefone2OS;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefoneOS;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEnderecoOS;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtMunicipioOS;
        private System.Windows.Forms.TextBox txtEstadoOS;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtIEOS;
        private System.Windows.Forms.TextBox txtBairroOS;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblIE;
        private System.Windows.Forms.TextBox txtCEPOS;
        private System.Windows.Forms.TextBox txtCNPJOS;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.GroupBox grpProdutos;
        private System.Windows.Forms.ComboBox cmbCarregarProdutos;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnAddProdutos;
        private System.Windows.Forms.DataGridView dgvAddProdutos;
        private System.Windows.Forms.GroupBox grpOcorrencia;
        private System.Windows.Forms.TextBox txtOcorrenciaOS;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTecnico;
        private System.Windows.Forms.TextBox txtEmitidopor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpPagamento;
        private System.Windows.Forms.TextBox txtFormaPag;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtd;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblZL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNumOS;
        private System.Windows.Forms.TextBox txtDataOS;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.GroupBox grpOS;
        private System.Windows.Forms.PrintPreviewDialog PPDFormOS;
        private System.Drawing.Printing.PrintDocument DocumentoOS;
    }
}