using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TransferenciaDados;

namespace ZLProject
{
    public partial class frmCadastroUsuarioAdm : UserControl
    {
        public frmCadastroUsuarioAdm()
        {
            InitializeComponent();
        }



        private void frmCadastroUsuarioAdm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Verifica Se Os Campos Foram Preenchidos.
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Favor Preencher o campo NOME!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.Focus();
            }

            else if (txtSenha.Text == string.Empty)
            {
                MessageBox.Show("Favor Preencher a SENHA!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSenha.Focus();
            }

            else
            {
                if (txtRepitaSenha.Text == string.Empty)
                {
                    MessageBox.Show("Favor Repitir a SENHA!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtRepitaSenha.Focus();
                }

                else if (txtSenha.Text != txtRepitaSenha.Text)
                {
                    MessageBox.Show("As senhas não Correnspondem", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtRepitaSenha.Focus();

                }
                else
                {
                    //Instanciar a classe ValidarUsuario
                    SalvarUsuario salvarusuario = new SalvarUsuario();
                    UsuariosDTO dados = new UsuariosDTO();

                    if (!chkADM.Checked)
                    {
                        dados.nivelAcesso = 0;
                    }
                    else
                    {
                        dados.nivelAcesso = 1;
                    }


                    //Popular os campos
                    dados.usuario = txtNome.Text;
                    dados.Senha = txtSenha.Text;
                    


                    //Chamar o método para incluir cliente
                    salvarusuario.IncluirUsuarios(dados);

                }

            }



           
        }

        private void chkADM_CheckedChanged(object sender, EventArgs e)
        {
            UsuariosDTO dados = new UsuariosDTO();
            if (chkADM.Checked)
            {
                dados.nivelAcesso = 1;
            }
            else
            {
                dados.nivelAcesso = 0;
            }
        }
    }
}

