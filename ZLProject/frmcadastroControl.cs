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
    public partial class frmcadastroControl : UserControl
    {
        public frmcadastroControl()
        {
            InitializeComponent();
        }

        private void lblTituloCadastro_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIncluirClientes_Click(object sender, EventArgs e)
        {
            //Verifica Se Os Campos Foram Preenchidos.
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Favor Preencher o campo NOME!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.Focus();
            }

            else if (txtCNPJ.Text == string.Empty)
            {
                MessageBox.Show("Favor Preencher o CNPJ!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCNPJ.Focus();
            }

            else if (txtEndereco.Text == string.Empty)
            {
                MessageBox.Show("Favor Preencher o ENDEREÇO!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEndereco.Focus();
            }

            else if (txtCEP.Text == string.Empty)
            {
                MessageBox.Show("Favor Preencher o CEP!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCEP.Focus();
            }

            else if (txtBairro.Text == string.Empty)
            {
                MessageBox.Show("Favor Preencher o BAIRRO!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBairro.Focus();
            }

            else if (txtMunicipio.Text == string.Empty)
            {
                MessageBox.Show("Favor Preencher o MUNICÍPIO!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMunicipio.Focus();
            }

            else if (txtEstado.Text == string.Empty)
            {
                MessageBox.Show("Favor Preencher o ESTADO!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEstado.Focus();
            }

            else if (txtIE.Text == string.Empty)
            {
                MessageBox.Show("Favor Preencher o IE!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIE.Focus();
            }

            else if (txtTelefone.Text == string.Empty)
            {
                MessageBox.Show("Favor Preencher o TELEFONE!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTelefone.Focus();
            }

            else if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Favor Preencher o EMAIL!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail.Focus();
            }
            else
            {


                //Instanciar a classe ValidarUsuario
                SalvarCliente salvarcliente = new SalvarCliente();
                ClientesDTO dados = new ClientesDTO();


                //Popular os campos
                dados.Nome = txtNome.Text;
                dados.CNPJ = txtCNPJ.Text;
                dados.Endereco = txtEndereco.Text;
                dados.CEP = txtCEP.Text;
                dados.Bairro = txtBairro.Text;
                dados.Municipio = txtMunicipio.Text;
                dados.Estado = txtEstado.Text;
                dados.IE = txtIE.Text;
                dados.Telefone = txtTelefone.Text;
                dados.Telefone2 = txtTelefone2.Text;
                dados.Email = txtEmail.Text;
                dados.Email2 = txtEmail_2.Text;


                //Chamar o método para incluir cliente
                salvarcliente.IncluirCliente(dados);

                MessageBox.Show("Cliente Cadastrado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Quando o cadastro é efetuado com sucesso é limpo todos os campos.
            txtNome.Clear();
            txtCNPJ.Clear();
            txtEndereco.Clear();
            txtCEP.Clear();
            txtBairro.Clear();
            txtMunicipio.Clear();
            txtEstado.Clear();
            txtIE.Clear();
            txtTelefone.Clear();
            txtTelefone2.Clear();
            txtEmail.Clear();
            txtEmail_2.Clear();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Excluir este Cliente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // instanciar o objeto
                ExcluirClientes excluirclientes = new ExcluirClientes();
                ClientesDTO dados = new ClientesDTO();

                //Receber os dados dos TXT's
                dados.Nome = txtNome.Text;

                //executar o método
                excluirclientes.ExcluirClientesGRID(dados);
                //Limpar grid
                dgvClientes.Rows.Clear();

                btnPesquisarCliente_Click(null, null);

                MessageBox.Show(dados.msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            {
                // instanciar o objeto
                EditarClientes editarclientes = new EditarClientes();
                ClientesDTO dados = new ClientesDTO();

                //Receber os dados dos TXT's
                dados.Nome = txtNome.Text;
                dados.CNPJ = txtCNPJ.Text;
                dados.Endereco = txtEndereco.Text;
                dados.CEP = txtCEP.Text;
                dados.Bairro = txtBairro.Text;
                dados.Municipio = txtMunicipio.Text;
                dados.Estado = txtEstado.Text;
                dados.IE = txtIE.Text;
                dados.Telefone = txtTelefone.Text;
                dados.Telefone2 = txtTelefone2.Text;
                dados.Email = txtEmail.Text;
                dados.Email2 = txtEmail_2.Text;


                //executar o método
                editarclientes.EditarClientesGRID(dados);
                //Limpar grid
                dgvClientes.Rows.Clear();

                btnPesquisarCliente_Click(null, null);

                MessageBox.Show(dados.msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {

            {
                LimparTela();

                btnIncluirClientes.Visible = true;
                btnEditarCliente.Visible = false;

            }
        }
        public void LimparTela()
        {
            txtNome.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCEP.Clear();
            txtTelefone.Clear();
            txtTelefone2.Clear();
            txtEmail.Clear();
            txtEmail_2.Clear();
            txtMunicipio.Clear();
            txtCNPJ.Clear();
            txtIE.Clear();
            txtEstado.Clear();

        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            {
                // instanciar o objeto
                ConsultarClientes PesquisarClientes = new ConsultarClientes();
                ClientesDTO dados = new ClientesDTO();

                //Receber os dados dos txt's
                dados.Nome = txtNome.Text;
                dados.Endereco = txtEndereco.Text;
                dados.Bairro = txtBairro.Text;
                dados.CEP = txtCEP.Text;
                dados.Telefone = txtTelefone.Text;
                dados.Email = txtEmail.Text;
                dados.Email2 = txtEmail_2.Text;
                dados.Municipio = txtMunicipio.Text;
                dados.CNPJ = txtCNPJ.Text;
                dados.IE = txtIE.Text;
                dados.Estado = txtEstado.Text;
                dados.Telefone2 = txtTelefone2.Text;

                //executar o método
                PesquisarClientes.CarregarGridClientes(dados);
                //Limpar grid
                dgvClientes.Rows.Clear();

                //Carregar o grid com os dados do
                //DataTable, através de um loop
                foreach (DataRow linha in PesquisarClientes.ClientesDataTable.Rows)

                {
                    //popular o grid
                    dgvClientes.Rows.Add(linha.ItemArray);
                }
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Esconde o botão Salvar e e habilita o botão Editar
            btnEditarCliente.Visible = true;
            btnIncluirClientes.Visible = false;

            //Campo = Mandar informações do grid para os TXT.
            txtIDCliente.Text = dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text      = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCNPJ.Text      = dgvClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEndereco.Text  = dgvClientes.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCEP.Text       = dgvClientes.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtBairro.Text    = dgvClientes.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtMunicipio.Text = dgvClientes.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtEstado.Text    = dgvClientes.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtIE.Text        = dgvClientes.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtTelefone.Text  = dgvClientes.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtTelefone2.Text = dgvClientes.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtEmail.Text     = dgvClientes.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtEmail_2.Text   = dgvClientes.Rows[e.RowIndex].Cells[12].Value.ToString();

        }

        private void btnIncluirClientes_Click_1(object sender, EventArgs e)
        {
            
            //Verifica Se Os Campos Foram Preenchidos.
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Favor Preencher o campo NOME!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.Focus();
            }

            else if (txtCNPJ.Text == string.Empty)
            {
                MessageBox.Show("Favor Preencher o CNPJ!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCNPJ.Focus();
            }

            else if (txtEndereco.Text == string.Empty)
            {
                MessageBox.Show("Favor Preencher o ENDEREÇO!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEndereco.Focus();
            }

            else if (txtCEP.Text == string.Empty)
            {
                MessageBox.Show("Favor Preencher o CEP!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCEP.Focus();
            }

            else if (txtBairro.Text == string.Empty)
            {
                MessageBox.Show("Favor Preencher o BAIRRO!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBairro.Focus();
            }

            else if (txtMunicipio.Text == string.Empty)
            {
                MessageBox.Show("Favor Preencher o MUNICÍPIO!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMunicipio.Focus();
            }

            else if (txtEstado.Text == string.Empty)
            {
                MessageBox.Show("Favor Preencher o ESTADO!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEstado.Focus();
            }

            else if (txtIE.Text == string.Empty)
            {
                MessageBox.Show("Favor Preencher o IE!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIE.Focus();
            }

            else if (txtTelefone.Text == string.Empty)
            {
                MessageBox.Show("Favor Preencher o TELEFONE!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTelefone.Focus();
            }

            else if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Favor Preencher o EMAIL!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail.Focus();
            }
            else
            {


                //Instanciar a classe SalvarCliente
                SalvarCliente salvarcliente = new SalvarCliente();
                ClientesDTO dados = new ClientesDTO();


                //Popular os campos
                dados.Nome = txtNome.Text;
                dados.CNPJ = txtCNPJ.Text;
                dados.Endereco = txtEndereco.Text;
                dados.CEP = txtCEP.Text;
                dados.Bairro = txtBairro.Text;
                dados.Municipio = txtMunicipio.Text;
                dados.Estado = txtEstado.Text;
                dados.IE = txtIE.Text;
                dados.Telefone = txtTelefone.Text;
                dados.Telefone2 = txtTelefone2.Text;
                dados.Email = txtEmail.Text;
                dados.Email2 = txtEmail_2.Text;


                //Chamar o método para incluir cliente
                salvarcliente.IncluirCliente(dados);

                MessageBox.Show("Cliente Cadastrado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Quando o cadastro é efetuado com sucesso é limpo todos os campos.
            txtNome.Clear();
            txtCNPJ.Clear();
            txtEndereco.Clear();
            txtCEP.Clear();
            txtBairro.Clear();
            txtMunicipio.Clear();
            txtEstado.Clear();
            txtIE.Clear();
            txtTelefone.Clear();
            txtTelefone2.Clear();
            txtEmail.Clear();
            txtEmail_2.Clear();
        }

        private void frmcadastroControl_Load(object sender, EventArgs e)
        {

        }

        private void lblIE_Click(object sender, EventArgs e)
        {

        }

        private void lblCNPJ_Click(object sender, EventArgs e)
        {

        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void lblMunicipio_Click(object sender, EventArgs e)
        {

        }

        private void lblCelular_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_2_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefone_Click(object sender, EventArgs e)
        {

        }

        private void lblEndereco_Click(object sender, EventArgs e)
        {

        }

        private void lblBairro_Click(object sender, EventArgs e)
        {

        }

        private void lblCEP_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}


