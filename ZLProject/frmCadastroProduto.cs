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
    public partial class frmCadastroProduto : UserControl
    {
        public frmCadastroProduto()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            {
                // instanciar o objeto
                ConsultarProdutos PesquisarProdutos = new ConsultarProdutos();
                ProdutosDTO dados = new ProdutosDTO();

                //Receber os dados do txtnome
                dados.Descricao = txtPesquisar.Text;

                //executar o método
                PesquisarProdutos.CarregarGrid(dados);
                //Limpar grid
                dgvProdutos.Rows.Clear();

                //Carregar o grid com os dados do
                //DataTable, através de um loop
                foreach (DataRow linha in PesquisarProdutos.ProdutosDataTable.Rows)

                {
                    //popular o grid
                    dgvProdutos.Rows.Add(linha.ItemArray);
                }
            }
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {

        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Esconde o botão Salvar e e habilita o botão Editar
            btnEditar.Visible = true;
            btnSalvar.Visible = false;

            //Campo = Mandar informações do grid para os TXT.
            txtID.Text = dgvProdutos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCodProduto.Text = dgvProdutos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDescricao.Text = dgvProdutos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPrecoFornecedor.Text = dgvProdutos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtValor.Text = dgvProdutos.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            {
                // instanciar o objeto
                EditarProdutos editarprodutos = new EditarProdutos();
                ProdutosDTO dados = new ProdutosDTO();

                //Receber os dados dos TXT's
                dados.Cod_Produto       = Convert.ToDouble(txtCodProduto.Text);
                dados.Descricao         = txtDescricao.Text;
                dados.Preco_Fornecedor  = Convert.ToDouble(txtPrecoFornecedor.Text);
                dados.Valor             = Convert.ToDouble(txtValor.Text);

                //executar o método
                editarprodutos.EditarProdutosGRID(dados);
                //Limpar grid
                dgvProdutos.Rows.Clear();

                btnPesquisar_Click(null, null);

                MessageBox.Show(dados.msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BtnNovo_Click(object sender, EventArgs e)
            
        {
            LimparTela();

            btnSalvar.Visible = true;
            btnEditar.Visible = false;

        }
        public void LimparTela()
        {
            txtCodProduto.Clear();
            txtID.Clear();
            txtDescricao.Clear();
            txtPrecoFornecedor.Clear();
            txtValor.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Verifica Se Os Campos Foram Preenchidos.
            if (txtCodProduto.Text == string.Empty)
            {
                MessageBox.Show("Favor Preencher o campo CÓDIGO DO PRODUTO!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCodProduto.Focus();
            }

            else if (txtDescricao.Text == string.Empty)
            {
                MessageBox.Show("Favor Preencher o campo DESCRIÇÃO!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescricao.Focus();
            }

            else if (txtPrecoFornecedor.Text == string.Empty)
            {
                MessageBox.Show("Favor Preencher o campo PREÇO DO FORNECEDOR!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecoFornecedor.Focus();
            }

            else if (txtValor.Text == string.Empty)
            {
                MessageBox.Show("Favor Preencher o campo VALOR DO PRODUTO!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtValor.Focus();
            }
            else
            {
                // instanciar o objeto
                IncluirProdutos incluirprodutos = new IncluirProdutos();
                ProdutosDTO dados = new ProdutosDTO();

                //Receber os dados dos TXT's
                dados.Cod_Produto = Convert.ToDouble(txtCodProduto.Text);
                dados.Descricao = txtDescricao.Text;
                dados.Preco_Fornecedor = Convert.ToDouble(txtPrecoFornecedor.Text);
                dados.Valor = Convert.ToDouble(txtValor.Text);

                //executar o método
                incluirprodutos.IncluirProdutosGRID(dados);
                //Limpar grid
                dgvProdutos.Rows.Clear();

                btnPesquisar_Click(null, null);

                MessageBox.Show(dados.msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Excluir este Produto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // instanciar o objeto
                ExcluirProdutos excluirprodutos = new ExcluirProdutos();
                ProdutosDTO dados = new ProdutosDTO();

                //Receber os dados dos TXT's
                dados.Cod_Produto = Convert.ToDouble(txtCodProduto.Text);

                //executar o método
                excluirprodutos.ExcluirProdutosGRID(dados);
                //Limpar grid
                dgvProdutos.Rows.Clear();

                btnPesquisar_Click(null, null);

                MessageBox.Show(dados.msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

