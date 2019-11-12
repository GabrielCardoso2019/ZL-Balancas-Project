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
    public partial class FrmIndex : Form
    {
        public FrmIndex()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Verificar se Realmente o Usuário Deseja Sair do Sistema
            if (MessageBox.Show("Deseja Realmente Deslogar do Sistema?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                //Instanciar as classes do usuariosDTO
                UsuariosDTO dados = new UsuariosDTO();
                ValidarUsuario validausuario = new ValidarUsuario();

                //Popular os campos
                dados.usuario = LoginSistema.usuario;
                dados.Senha   = LoginSistema.Senha;

                //Chamar o método
                validausuario.DesconectarUsuario(dados);

                this.Hide();
                FrmLogin login = new FrmLogin();
                login.Show();
            }
         }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmcadastroControl1_Load(object sender, EventArgs e)
        {

        }

        private void frmConsultarUsuario1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {

        }

        private void frmcadastroControl1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
