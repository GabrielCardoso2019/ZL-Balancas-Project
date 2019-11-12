namespace ZLProject
{
    partial class frmConsultarUsuario
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarUsuario));
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.Usuário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NivelAcesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conectado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPesquisarUsuario = new System.Windows.Forms.Button();
            this.txtPesquisarUsuario = new System.Windows.Forms.TextBox();
            this.BtnDeslogarUsuario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.txtNivelAcesso = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLogado = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExcluirUsuario = new System.Windows.Forms.Button();
            this.btnAddAdm = new System.Windows.Forms.Button();
            this.btnRemoverAdm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuário,
            this.NivelAcesso,
            this.Conectado});
            this.dgvUsuario.Location = new System.Drawing.Point(14, 18);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.Size = new System.Drawing.Size(283, 427);
            this.dgvUsuario.TabIndex = 0;
            this.dgvUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellContentClick);
            // 
            // Usuário
            // 
            this.Usuário.HeaderText = "Usuário";
            this.Usuário.Name = "Usuário";
            this.Usuário.ReadOnly = true;
            // 
            // NivelAcesso
            // 
            this.NivelAcesso.HeaderText = "Nivel de Acesso";
            this.NivelAcesso.Name = "NivelAcesso";
            this.NivelAcesso.ReadOnly = true;
            // 
            // Conectado
            // 
            this.Conectado.HeaderText = "Conectado";
            this.Conectado.Name = "Conectado";
            this.Conectado.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(310, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnPesquisarUsuario
            // 
            this.btnPesquisarUsuario.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarUsuario.Location = new System.Drawing.Point(504, 167);
            this.btnPesquisarUsuario.Name = "btnPesquisarUsuario";
            this.btnPesquisarUsuario.Size = new System.Drawing.Size(88, 28);
            this.btnPesquisarUsuario.TabIndex = 2;
            this.btnPesquisarUsuario.Text = "Pesquisar";
            this.btnPesquisarUsuario.UseVisualStyleBackColor = true;
            this.btnPesquisarUsuario.Click += new System.EventHandler(this.btnPesquisarUsuario_Click);
            // 
            // txtPesquisarUsuario
            // 
            this.txtPesquisarUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtPesquisarUsuario.Location = new System.Drawing.Point(310, 171);
            this.txtPesquisarUsuario.Name = "txtPesquisarUsuario";
            this.txtPesquisarUsuario.Size = new System.Drawing.Size(188, 20);
            this.txtPesquisarUsuario.TabIndex = 3;
            // 
            // BtnDeslogarUsuario
            // 
            this.BtnDeslogarUsuario.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeslogarUsuario.Location = new System.Drawing.Point(310, 213);
            this.BtnDeslogarUsuario.Name = "BtnDeslogarUsuario";
            this.BtnDeslogarUsuario.Size = new System.Drawing.Size(134, 28);
            this.BtnDeslogarUsuario.TabIndex = 4;
            this.BtnDeslogarUsuario.Text = "Deslogar Usuário";
            this.BtnDeslogarUsuario.UseVisualStyleBackColor = true;
            this.BtnDeslogarUsuario.Click += new System.EventHandler(this.BtnDeslogarUsuario_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(467, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 2);
            this.panel1.TabIndex = 5;
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.BackColor = System.Drawing.Color.White;
            this.txtNomeUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtNomeUsuario.Location = new System.Drawing.Point(467, 45);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(125, 13);
            this.txtNomeUsuario.TabIndex = 6;
            // 
            // txtNivelAcesso
            // 
            this.txtNivelAcesso.BackColor = System.Drawing.Color.White;
            this.txtNivelAcesso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNivelAcesso.ForeColor = System.Drawing.Color.Black;
            this.txtNivelAcesso.Location = new System.Drawing.Point(467, 74);
            this.txtNivelAcesso.Name = "txtNivelAcesso";
            this.txtNivelAcesso.Size = new System.Drawing.Size(125, 13);
            this.txtNivelAcesso.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(467, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 2);
            this.panel2.TabIndex = 7;
            // 
            // txtLogado
            // 
            this.txtLogado.BackColor = System.Drawing.Color.White;
            this.txtLogado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogado.ForeColor = System.Drawing.Color.Black;
            this.txtLogado.Location = new System.Drawing.Point(467, 103);
            this.txtLogado.Name = "txtLogado";
            this.txtLogado.Size = new System.Drawing.Size(125, 13);
            this.txtLogado.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(467, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(125, 2);
            this.panel3.TabIndex = 9;
            // 
            // btnExcluirUsuario
            // 
            this.btnExcluirUsuario.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirUsuario.Location = new System.Drawing.Point(310, 247);
            this.btnExcluirUsuario.Name = "btnExcluirUsuario";
            this.btnExcluirUsuario.Size = new System.Drawing.Size(134, 28);
            this.btnExcluirUsuario.TabIndex = 11;
            this.btnExcluirUsuario.Text = "Excluir";
            this.btnExcluirUsuario.UseVisualStyleBackColor = true;
            this.btnExcluirUsuario.Click += new System.EventHandler(this.btnExcluirUsuario_Click);
            // 
            // btnAddAdm
            // 
            this.btnAddAdm.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdm.Location = new System.Drawing.Point(310, 281);
            this.btnAddAdm.Name = "btnAddAdm";
            this.btnAddAdm.Size = new System.Drawing.Size(134, 28);
            this.btnAddAdm.TabIndex = 12;
            this.btnAddAdm.Text = "Tornar Administrador";
            this.btnAddAdm.UseVisualStyleBackColor = true;
            this.btnAddAdm.Visible = false;
            this.btnAddAdm.Click += new System.EventHandler(this.btnAddAdm_Click);
            // 
            // btnRemoverAdm
            // 
            this.btnRemoverAdm.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverAdm.Location = new System.Drawing.Point(310, 281);
            this.btnRemoverAdm.Name = "btnRemoverAdm";
            this.btnRemoverAdm.Size = new System.Drawing.Size(134, 26);
            this.btnRemoverAdm.TabIndex = 13;
            this.btnRemoverAdm.Text = "Remover Administrador";
            this.btnRemoverAdm.UseVisualStyleBackColor = true;
            this.btnRemoverAdm.Visible = false;
            this.btnRemoverAdm.Click += new System.EventHandler(this.btnRemoverAdm_Click);
            // 
            // frmConsultarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddAdm);
            this.Controls.Add(this.btnExcluirUsuario);
            this.Controls.Add(this.txtLogado);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtNivelAcesso);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnDeslogarUsuario);
            this.Controls.Add(this.txtPesquisarUsuario);
            this.Controls.Add(this.btnPesquisarUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.btnRemoverAdm);
            this.Name = "frmConsultarUsuario";
            this.Size = new System.Drawing.Size(716, 466);
            this.Load += new System.EventHandler(this.frmConsultarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPesquisarUsuario;
        private System.Windows.Forms.TextBox txtPesquisarUsuario;
        private System.Windows.Forms.Button BtnDeslogarUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuário;
        private System.Windows.Forms.DataGridViewTextBoxColumn NivelAcesso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conectado;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.TextBox txtNivelAcesso;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtLogado;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExcluirUsuario;
        private System.Windows.Forms.Button btnAddAdm;
        private System.Windows.Forms.Button btnRemoverAdm;
    }
}
