namespace ZLProject
{
    partial class frmCadastroOpcoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroOpcoes));
            this.picAddUser = new System.Windows.Forms.PictureBox();
            this.picAddClt = new System.Windows.Forms.PictureBox();
            this.btnAddClt = new System.Windows.Forms.Button();
            this.lblAddClt = new System.Windows.Forms.Label();
            this.lblAddUser = new System.Windows.Forms.Label();
            this.btnCadUsuario = new System.Windows.Forms.Button();
            this.lblCadastrar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAddUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddClt)).BeginInit();
            this.SuspendLayout();
            // 
            // picAddUser
            // 
            this.picAddUser.Image = ((System.Drawing.Image)(resources.GetObject("picAddUser.Image")));
            this.picAddUser.Location = new System.Drawing.Point(375, 149);
            this.picAddUser.Name = "picAddUser";
            this.picAddUser.Size = new System.Drawing.Size(172, 174);
            this.picAddUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddUser.TabIndex = 0;
            this.picAddUser.TabStop = false;
            // 
            // picAddClt
            // 
            this.picAddClt.Image = ((System.Drawing.Image)(resources.GetObject("picAddClt.Image")));
            this.picAddClt.Location = new System.Drawing.Point(112, 149);
            this.picAddClt.Name = "picAddClt";
            this.picAddClt.Size = new System.Drawing.Size(172, 174);
            this.picAddClt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddClt.TabIndex = 1;
            this.picAddClt.TabStop = false;
            // 
            // btnAddClt
            // 
            this.btnAddClt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClt.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClt.Location = new System.Drawing.Point(147, 329);
            this.btnAddClt.Name = "btnAddClt";
            this.btnAddClt.Size = new System.Drawing.Size(100, 42);
            this.btnAddClt.TabIndex = 3;
            this.btnAddClt.Text = "Cadastrar";
            this.btnAddClt.UseVisualStyleBackColor = true;
            // 
            // lblAddClt
            // 
            this.lblAddClt.AutoSize = true;
            this.lblAddClt.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddClt.Location = new System.Drawing.Point(162, 120);
            this.lblAddClt.Name = "lblAddClt";
            this.lblAddClt.Size = new System.Drawing.Size(85, 26);
            this.lblAddClt.TabIndex = 4;
            this.lblAddClt.Text = "Clientes";
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUser.Location = new System.Drawing.Point(367, 120);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(186, 26);
            this.lblAddUser.TabIndex = 5;
            this.lblAddUser.Text = "Usuário no Sistema";
            // 
            // btnCadUsuario
            // 
            this.btnCadUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadUsuario.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadUsuario.Location = new System.Drawing.Point(406, 329);
            this.btnCadUsuario.Name = "btnCadUsuario";
            this.btnCadUsuario.Size = new System.Drawing.Size(100, 42);
            this.btnCadUsuario.TabIndex = 6;
            this.btnCadUsuario.Text = "Cadastrar";
            this.btnCadUsuario.UseVisualStyleBackColor = true;
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrar.Location = new System.Drawing.Point(236, 41);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(185, 47);
            this.lblCadastrar.TabIndex = 7;
            this.lblCadastrar.Text = "Cadastrar:";
            // 
            // frmCadastroOpcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCadastrar);
            this.Controls.Add(this.btnCadUsuario);
            this.Controls.Add(this.lblAddUser);
            this.Controls.Add(this.lblAddClt);
            this.Controls.Add(this.btnAddClt);
            this.Controls.Add(this.picAddClt);
            this.Controls.Add(this.picAddUser);
            this.Name = "frmCadastroOpcoes";
            this.Size = new System.Drawing.Size(716, 466);
            ((System.ComponentModel.ISupportInitialize)(this.picAddUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddClt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAddUser;
        private System.Windows.Forms.PictureBox picAddClt;
        private System.Windows.Forms.Button btnAddClt;
        private System.Windows.Forms.Label lblAddClt;
        private System.Windows.Forms.Label lblAddUser;
        private System.Windows.Forms.Button btnCadUsuario;
        private System.Windows.Forms.Label lblCadastrar;
    }
}
