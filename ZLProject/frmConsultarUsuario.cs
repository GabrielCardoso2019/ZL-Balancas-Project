using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferenciaDados;

namespace ZLProject
{
    public partial class frmConsultarUsuario : UserControl
    {
        public frmConsultarUsuario()
        {
            InitializeComponent();
        }

        private void frmConsultarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisarUsuario_Click(object sender, EventArgs e)
        {
            {
                // instanciar o objeto
                ConsultarUsuarios consultarusuarios = new ConsultarUsuarios();
                UsuariosDTO dados = new UsuariosDTO();

                //Receber os dados do txtnome
                dados.usuario = txtPesquisarUsuario.Text;

                //executar o método
                consultarusuarios.CarregarGridUsuarios(dados);
                //Limpar grid
                dgvUsuario.Rows.Clear();

                //Limpa as linhas do grid para receber novos dados

                string nivelacessousuario = string.Empty;
                string logadogrid = string.Empty;

                //DataTable, através de um loop

                foreach (DataRow linha in consultarusuarios.UsuariosDataTable.Rows)


                {
                    //Transforma as linhas do Grid no texto desejado
                    if (linha.ItemArray[1].ToString() == "0")
                    {
                        nivelacessousuario = "Operador";
                    }
                    else if (linha.ItemArray[1].ToString() == "1")
                    {
                        nivelacessousuario = "Admin";
                    }

                    //Transforma as linhas do Grid no texto desejado
                    if (linha.ItemArray[2].ToString() == "0")
                    {
                        logadogrid = "Não";
                    }
                    else if (linha.ItemArray[2].ToString() == "1")
                    {
                        logadogrid = "Sim";
                    }


                    //popular o grid
                    dgvUsuario.Rows.Add(linha.ItemArray[0].ToString(), nivelacessousuario, logadogrid);
                }
            }
        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            //Campo = Mandar informações do grid para os TXT.
            txtNomeUsuario.Text = dgvUsuario.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNivelAcesso.Text = dgvUsuario.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLogado.Text = dgvUsuario.Rows[e.RowIndex].Cells[2].Value.ToString();

            if (txtNivelAcesso.Text == "Operador")
            {
                btnAddAdm.Visible = true;
                btnRemoverAdm.Visible = false;
            }
            else
            {
                btnAddAdm.Visible = false;
                btnRemoverAdm.Visible = true;
            }
           
         }

        private void BtnDeslogarUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente Deslogar o Usuário?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Instanciar as classes do usuariosDTO
                UsuariosDTO dados = new UsuariosDTO();
                ValidarUsuario validausuario = new ValidarUsuario();

                //Popular os campos
                dados.usuario = LoginSistema.usuario;
                dados.Senha = LoginSistema.Senha;

                //Chamar o método
                validausuario.DesconectarUsuario(dados);
                               
            }
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Excluir este Usuário?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // instanciar o objeto
                ExcluirUsuarios excluirusuarios = new ExcluirUsuarios();
                UsuariosDTO dados = new UsuariosDTO();

                //Receber os dados dos TXT's
                dados.usuario = txtNomeUsuario.Text;

                //executar o método
                excluirusuarios.ExcluirUsuariosGRID(dados);
                //Limpar grid
                dgvUsuario.Rows.Clear();

                btnPesquisarUsuario_Click(null, null);

                MessageBox.Show(dados.msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemoverAdm_Click(object sender, EventArgs e)
        {
            {
                // instanciar o objeto
                RemoverAdmin removeradmin = new RemoverAdmin();
                UsuariosDTO dados = new UsuariosDTO();

                //Receber os dados dos TXT's
                dados.usuario = txtNomeUsuario.Text;

                //executar o método
                removeradmin.RemoverAdminGRID(dados);
                //Limpar grid
                dgvUsuario.Rows.Clear();

                btnPesquisarUsuario_Click(null, null);

                MessageBox.Show(dados.msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddAdm_Click(object sender, EventArgs e)
        {
            {
                // instanciar o objeto
                PromoverOperador promoveroperador = new PromoverOperador();
                UsuariosDTO dados = new UsuariosDTO();

                //Receber os dados dos TXT's
                dados.usuario = txtNomeUsuario.Text;

                //executar o método
                promoveroperador.PromoverOperadorGRID(dados);
                //Limpar grid
                dgvUsuario.Rows.Clear();

                btnPesquisarUsuario_Click(null, null);

                MessageBox.Show(dados.msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
