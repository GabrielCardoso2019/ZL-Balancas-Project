using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferenciaDados;

namespace ZLProject
{
    public partial class FrmLogin : Form
    {
        public bool loginSucesso = false;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            ValidarUsuario validarusuario = new ValidarUsuario();
            UsuariosDTO dados = new UsuariosDTO();
            if (this.Text == "Incluir")
            {
                //Rotina para incluir usuários
                //instanciar a classe ValidarUsuario


                dados.usuario = txtUsuario.Text;
                dados.Senha = txtSenha.Text;

                //Chamar o método para incluir cliente

                validarusuario.IncluirUsuarios(dados);
            }
            else

            {

                // popular os campos
                dados.usuario = txtUsuario.Text;
                dados.Senha = txtSenha.Text;

                //chamar o método para verificar cliente
                validarusuario.VerificarUsuarios(dados);

                //retorno do método
                string msg = string.Empty;

                //selecione caso             
                switch (dados.Logado)
                {
                    case 2:
                        msg = "Usuário ou senha incorretos";
                        break;

                    case 3:
                        msg = "Usuário já está conectado";
                        break;

                    case 4:
                        msg = "Bem vindo ao Sistema";
                        break;
                }

                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (dados.Logado == 4)
                {
                    //a variável passa para verdadeiro
                    this.loginSucesso = true;
                    // Se o valor da variável for verdadeiro, fechar o formulário
                    if (this.loginSucesso)

                    {
                        this.Close();
                    }
                }
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
