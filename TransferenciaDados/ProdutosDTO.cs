using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Namespace necessário para conexão com o banco de dados
using AcessoBanco;
using System.Data.SqlClient;
using System.Data;

namespace TransferenciaDados
{
    public class ProdutosDTO
    {
        float _ID;
        double _Cod_Produto;
        string _Descricao;
        double _Preco_Fornecedor;
        double _Valor;
        string _msg;

        public float ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public double Cod_Produto
        {
            get { return _Cod_Produto; }
            set { _Cod_Produto = value; }
        }

        public string Descricao
        {
            get { return _Descricao; }
            set { _Descricao = value; }
        }

        public double Preco_Fornecedor
        {
            get { return _Preco_Fornecedor; }
            set { _Preco_Fornecedor = value; }
        }

        public double Valor
        {
            get { return _Valor; }
            set { _Valor = value; }
        }

        public string msg
        {
            get { return _msg; }
            set { _msg = value; }
        }

    }

    public class ConsultarProdutos
    {

        //Container para daddos
        public DataTable ProdutosDataTable;
        //Método para popular o DataGridView
        public void CarregarGrid(ProdutosDTO dados)
        {

            //Instruções TSQL
            //Tratamento de excessoões
            try
            {

                string sql = "Select ID_Produto,Cod_Produto,Descricao,Preco_Fornecedor,Valor from tbProdutoZL where Descricao like'%" + dados.Descricao + "%' order by ID_Produto";
                //Interação de dados
                SqlDataAdapter ProdutosDataAdaptar = new SqlDataAdapter(sql, Conexao.obterConexao());
                //Instanciar o Objeto
                ProdutosDataTable = new DataTable();
                //Popular Datatable
                ProdutosDataAdaptar.Fill(ProdutosDataTable);
            }
            catch (SqlException e) { }

        }
    }

    public class EditarProdutos
    {
      
        public void EditarProdutosGRID(ProdutosDTO dados)
        {
            //Definir parâmetros para o SQL Server
            //Tratamento de excessões
            try
            {
                SqlCommand cmd = new SqlCommand("sp_EditarProdutosGRID", Conexao.obterConexao());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigoproduto", dados.Cod_Produto);
                cmd.Parameters.AddWithValue("@descricao", dados.Descricao);
                cmd.Parameters.AddWithValue("@precoforn", dados.Preco_Fornecedor);
                cmd.Parameters.AddWithValue("@valor", dados.Valor);
             
                //Executar os comandos SQL
                cmd.ExecuteNonQuery();

                dados.msg = "Alterado com Sucesso!";

            }

            catch (SqlException e)
            {
                dados.msg = "Erro - EditarProdutos - EditarProdutosGRID " + e.Message.ToString();
            }
        }
    }

    public class IncluirProdutos
    {

        public void IncluirProdutosGRID(ProdutosDTO dados)
        {
            //Definir parâmetros para o SQL Server
            //Tratamento de excessões
            try
            {
                SqlCommand cmd = new SqlCommand("sp_IncluirProdutosGRID", Conexao.obterConexao());
                cmd.CommandType = CommandType.StoredProcedure;
              //  cmd.Parameters.AddWithValue("@idProduto", dados.Cod_Produto);
                cmd.Parameters.AddWithValue("@codigoproduto", dados.Cod_Produto);
                cmd.Parameters.AddWithValue("@descricao", dados.Descricao);
                cmd.Parameters.AddWithValue("@precoforn", dados.Preco_Fornecedor);
                cmd.Parameters.AddWithValue("@valor", dados.Valor);

                //Executar os comandos SQL
                cmd.ExecuteNonQuery();

                dados.msg = "Incluido com Sucesso!";

            }

            catch (SqlException e)
            {
                dados.msg = "Erro - IncluirProdutos - IncluirProdutosGRID " + e.Message.ToString();
            }
        }
    }

    public class ExcluirProdutos
    {

        public void ExcluirProdutosGRID(ProdutosDTO dados)
        {
            //Definir parâmetros para o SQL Server
            //Tratamento de excessões
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ExcluirProdutosGRID", Conexao.obterConexao());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigoproduto", dados.Cod_Produto);
                

                //Executar os comandos SQL
                cmd.ExecuteNonQuery();

                dados.msg = "Exlcuido com Sucesso!";

            }

            catch (SqlException e)
            {
                dados.msg = "Erro - ExcluirProdutos - ExcluirProdutosGRID " + e.Message.ToString();
            }
        }
    }

    public class PesquisaProdutosOS
    {
        //Container para daddos
        public DataTable ProdutosDataTableOS;
        //Método para popular o DataGridView
        public void CarregarCOMBOBOXProdutos(ProdutosDTO dados)
        {

            //Instruções TSQL
            //Tratamento de excessoões
            try
            {

                string sql = "Select Cod_Produto,Descricao,Preco_Fornecedor,Valor FROM tbProdutoZL WHERE Descricao like'%" + dados.Descricao + "%' order by ID_Produto";
                //Interação de dados
                SqlDataAdapter ProdutosOSDataAdaptar = new SqlDataAdapter(sql, Conexao.obterConexao());
                //Instanciar o Objeto
                ProdutosDataTableOS = new DataTable();
                //Popular Datatable
                ProdutosOSDataAdaptar.Fill(ProdutosDataTableOS);
            }
            catch (SqlException e) { }

        }
    }
}
