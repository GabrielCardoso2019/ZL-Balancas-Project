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
    //Class de UsuarioDTO - Usuarios para acesso ao Sistema
    public class UsuariosDTO
    {
        int _idUsuario;
        string _usuario;
        string _senha;
        string _msg;
        int _nivelAcesso;
        int _Logado;



        public int Codigo_Usuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }


        public string msg
        {
            get { return _msg; }
            set { _msg = value; }
        }


        public int nivelAcesso
        {
            get { return _nivelAcesso; }
            set { _nivelAcesso = value; }
        }

        public int Logado
        {
            get { return _Logado; }
            set { _Logado = value; }
        }





    }

    //Class ClienteDTO - EMPRESA - Empresas Cadastramento

    public class ClientesDTO
    {
        int _idCliente;
        string _Nome;
        string _CNPJ;
        string _Endereco;
        string _CEP;
        string _Bairro;
        string _Municipio;
        string _Estado;
        string _IE;
        string _Telefone;
        string _Telefone2;
        string _Email;
        string _Email2;
        string _msg;


        public int idCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public string CNPJ
        {
            get { return _CNPJ; }
            set { _CNPJ = value; }
        }

        public string Endereco
        {
            get { return _Endereco; }
            set { _Endereco = value; }
        }


        public string CEP
        {
            get { return _CEP; }
            set { _CEP = value; }
        }


        public string Bairro
        {
            get { return _Bairro; }
            set { _Bairro = value; }
        }

        public string Municipio
        {
            get { return _Municipio; }
            set { _Municipio = value; }
        }

        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        public string IE
        {
            get { return _IE; }
            set { _IE = value; }
        }

        public string Telefone
        {
            get { return _Telefone; }
            set { _Telefone = value; }
        }

        public string Telefone2
        {
            get { return _Telefone2; }
            set { _Telefone2 = value; }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public string Email2
        {
            get { return _Email2; }
            set { _Email2 = value; }
        }

        public string msg
        {
            get { return _msg; }
            set { _msg = value; }
        }


    }

    public static class LoginSistema
    {
        private static string _Senha;
        private static string _usuario;

        public static string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public static string Senha
        {
            get { return _Senha; }
            set { _Senha = value; }
        }
    }

    public class SalvarUsuario
    {
        public void IncluirUsuarios(UsuariosDTO dados)
        {
            //Definir parâmetros para o SQL Server
            //Tratamento de excessões
            try
            {
                SqlCommand cmd = new SqlCommand("sp_IncluirUsuarioZL", Conexao.obterConexao());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", dados.usuario);
                cmd.Parameters.AddWithValue("@senha", dados.Senha);
                cmd.Parameters.AddWithValue("@nivelAcesso", dados.nivelAcesso);


                //Executar os comandos SQL
                cmd.ExecuteNonQuery();

            }

            catch (SqlException e)
            {

            }
        }

        public void VerificarUsuarios(UsuariosDTO dados)
        {
            //Definir parâmetros para o SQL Server
            //Tratamento de excessões
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ValidarUsuario", Conexao.obterConexao());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", dados.usuario);
                cmd.Parameters.AddWithValue("@Senha", dados.Senha);


                //Executar os comandos SQL
                //cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();
                //Verificar a existência de registros (linha)
                if (dr.HasRows)
                {
                    //Percorre os registros
                    while (dr.Read())
                    {
                        //Popular os dados de retorno da Stored Procedure
                        dados.nivelAcesso = Convert.ToInt32(dr.GetValue(0).ToString());
                    }
                }
            }

            catch (SqlException e)
            {

            }


        }

    }


    public class SalvarCliente
    {
        public void IncluirCliente(ClientesDTO dados)
        {
            //Definir parâmetros para o SQL Server
            //Tratamento de excessões
            try
            {
                SqlCommand cmd = new SqlCommand("sp_IncluirClienteZL", Conexao.obterConexao());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nome", dados.Nome);
                cmd.Parameters.AddWithValue("@CNPJ", dados.CNPJ);
                cmd.Parameters.AddWithValue("@Endereco", dados.Endereco);
                cmd.Parameters.AddWithValue("@CEP", dados.CEP);
                cmd.Parameters.AddWithValue("@Bairro", dados.Bairro);
                cmd.Parameters.AddWithValue("@Municipio", dados.Municipio);
                cmd.Parameters.AddWithValue("@Estado", dados.Estado);
                cmd.Parameters.AddWithValue("@IE", dados.IE);
                cmd.Parameters.AddWithValue("@Telefone", dados.Telefone);
                cmd.Parameters.AddWithValue("@Telefone2", dados.Telefone2);
                cmd.Parameters.AddWithValue("@Email", dados.Email);
                cmd.Parameters.AddWithValue("@Email2", dados.Email2);


                //Executar os comandos SQL
                cmd.ExecuteNonQuery();

            }

            catch (SqlException e)
            {

            }
        }
    }
      
    public class ValidarUsuario
    {
        public void IncluirUsuarios(UsuariosDTO dados)
        {
            //definir parametros para o SQL Server.
            //Tratamento de excessões
            try
            {
                SqlCommand cmd = new SqlCommand("sp_IncluirUsuarios", Conexao.obterConexao());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", dados.usuario);
                cmd.Parameters.AddWithValue("@Senha", dados.Senha);

                //Executar os comandos SQL
                cmd.ExecuteNonQuery();
            }

            catch (SqlException e)
            {

            }
        }

        public void VerificarUsuarios(UsuariosDTO dados)
        {
            //definir parametros para o SQL Server.
            //Tratamento de excessões
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ValidarUsuario", Conexao.obterConexao());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", dados.usuario);
                cmd.Parameters.AddWithValue("@Senha", dados.Senha);


                //Executar os comandos SQL
                // cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                //Verificara existência de registro (linhas)
                if (dr.HasRows)
                {
                    //percrrer os registros
                    while (dr.Read())
                    {
                        // Popular com os dados de retorno da Stored Procedure
                        dados.Logado = Convert.ToInt32(dr.GetValue(0).ToString());
                        LoginSistema.usuario = dados.usuario;
                        LoginSistema.Senha = dr.GetValue(1).ToString();

                    }
                }
            }

            catch (SqlException e)
            {

            }
        }
        public void DesconectarUsuario(UsuariosDTO dados)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_DesconectarUsuario", Conexao.obterConexao());
                cmd.CommandType = CommandType.StoredProcedure;
                // popular os parâmetros da Stored Procedure
                cmd.Parameters.AddWithValue("@Usuario", dados.usuario);
                cmd.Parameters.AddWithValue("@Senha", dados.Senha);

                //Utilizar uma tabela temporária
                SqlDataReader dr = cmd.ExecuteReader();

                // Verificar a existência de registros (linhas)
                if (dr.HasRows)
                {
                    // Percorre os registros
                    while (dr.Read())
                    {
                        //Popular com os dados de retorno da Stored Procedure
                        //   dados.Logado = dr.GetValue(0).ToString();
                        //  LoginSistema.usuario = dados.NomeUsuario;
                    }

                }

            }
            catch (SqlException e)
            {
                //dados.msg = "Erro - ValidarUsuario - VerificarUsuario " + e.Message;
            }

        }


    }
    public class ConsultarUsuarios
    {

        //Container para daddos
        public DataTable UsuariosDataTable;
        //Método para popular o DataGridView
        public void CarregarGridUsuarios(UsuariosDTO dados)
        {

            //Instruções TSQL
            //Tratamento de excessoões
            try
            {

                string sql = "Select usuario,nivelAcesso,logado from tbUsuarioZL where usuario like'%" + dados.usuario + "%' order by idUsuario";
                //Interação de dados
                SqlDataAdapter ClientesDataAdaptar = new SqlDataAdapter(sql, Conexao.obterConexao());
                //Instanciar o Objeto
                UsuariosDataTable = new DataTable();
                //Popular Datatable
                ClientesDataAdaptar.Fill(UsuariosDataTable);
            }
            catch (SqlException e) { }

        }
    }
    public class ConsultarClientes
    {

        //Container para daddos
        public DataTable ClientesDataTable;
        //Método para popular o DataGridView
        public void CarregarGridClientes(ClientesDTO dados)
        {

            //Instruções TSQL
            //Tratamento de excessoões
            try
            {

                string sql = "Select idCliente,Nome,CNPJ,Endereco,CEP,Bairro,Municipio,Estado,IE,Telefone,telefone_2,Email,Email_2 from tbClienteZL where Nome like'%" + dados.Nome + "%' order by idCliente";
                //Interação de dados
                SqlDataAdapter ClientesDataAdaptar = new SqlDataAdapter(sql, Conexao.obterConexao());
                //Instanciar o Objeto
                ClientesDataTable = new DataTable();
                //Popular Datatable
                ClientesDataAdaptar.Fill(ClientesDataTable);
            }
            catch (SqlException e) { }

        }
    }
    public class EditarClientes
    {

        public void EditarClientesGRID(ClientesDTO dados)
        {
            //Definir parâmetros para o SQL Server
            //Tratamento de excessões
            try
            {
                SqlCommand cmd = new SqlCommand("sp_EditarClientesGRID", Conexao.obterConexao());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", dados.Nome);
                cmd.Parameters.AddWithValue("@cnpj", dados.CNPJ);
                cmd.Parameters.AddWithValue("@endereco", dados.Endereco);
                cmd.Parameters.AddWithValue("@cep", dados.CEP);
                cmd.Parameters.AddWithValue("@bairro", dados.Bairro);
                cmd.Parameters.AddWithValue("@municipio", dados.Municipio);
                cmd.Parameters.AddWithValue("@estado", dados.Estado);
                cmd.Parameters.AddWithValue("@ie", dados.IE);
                cmd.Parameters.AddWithValue("@telefone", dados.Telefone);
                cmd.Parameters.AddWithValue("@telefone2", dados.Telefone2);
                cmd.Parameters.AddWithValue("@email", dados.Email);
                cmd.Parameters.AddWithValue("@email2", dados.Email2);

                //Executar os comandos SQL
                cmd.ExecuteNonQuery();

                dados.msg = "Alterado com Sucesso!";

            }

            catch (SqlException e)
            {
                dados.msg = "Erro - EditarClientes - EditarClientesGRID " + e.Message.ToString();
            }
        }
    }
    public class ExcluirClientes
    {

        public void ExcluirClientesGRID(ClientesDTO dados)
        {
            //Definir parâmetros para o SQL Server
            //Tratamento de excessões
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ExcluirClientesGRID", Conexao.obterConexao());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", dados.Nome);
              
                //Executar os comandos SQL
                cmd.ExecuteNonQuery();

                dados.msg = "Excluido com Sucesso";

            }

            catch (SqlException e)
            {
                dados.msg = "Erro - ExcluirClientes - ExcluirClientesGRID " + e.Message.ToString();
            }
        }
    }

    public class ExcluirUsuarios
    {

        public void ExcluirUsuariosGRID(UsuariosDTO dados)
        {
            //Definir parâmetros para o SQL Server
            //Tratamento de excessões
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ExcluirUsuariosGRID", Conexao.obterConexao());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", dados.usuario);

                //Executar os comandos SQL
                cmd.ExecuteNonQuery();

                dados.msg = "Excluido com Sucesso";

            }

            catch (SqlException e)
            {
                dados.msg = "Erro - ExcluirUsuarios - ExcluirUsuariosGRID " + e.Message.ToString();
            }
        }
    }

    public class RemoverAdmin
    {

        public void RemoverAdminGRID(UsuariosDTO dados)
        {
            //Definir parâmetros para o SQL Server
            //Tratamento de excessões
            try
            {
                SqlCommand cmd = new SqlCommand("sp_RemoverAdminGRID", Conexao.obterConexao());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", dados.usuario);
                

                //Executar os comandos SQL
                cmd.ExecuteNonQuery();

                dados.msg = "Nível de acesso rebaixado!";

            }

            catch (SqlException e)
            {
                dados.msg = "Erro - RemoverAdmin - RemoverAdminGRID " + e.Message.ToString();
            }
        }
    }

    public class PromoverOperador
    {

        public void PromoverOperadorGRID(UsuariosDTO dados)
        {
            //Definir parâmetros para o SQL Server
            //Tratamento de excessões
            try
            {
                SqlCommand cmd = new SqlCommand("sp_PromoverOperadorGRID", Conexao.obterConexao());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", dados.usuario);


                //Executar os comandos SQL
                cmd.ExecuteNonQuery();

                dados.msg = "Nível de acesso promovido!";

            }

            catch (SqlException e)
            {
                dados.msg = "Erro - PromoverOperador - PromverOperadorGRID " + e.Message.ToString();
            }
        }
    }

    public class PesquisaClienteOS
    {
        //Container para daddos
        public DataTable ClientesDataTableOS;
        //Método para popular o DataGridView
        public void CarregarCOMBOBOXClientes(ClientesDTO dados)
        {

            //Instruções TSQL
            //Tratamento de excessoões
            try
            {

                string sql = "Select Nome,CNPJ,Endereco,CEP,Bairro,Municipio,Estado,IE,Telefone,telefone_2,Email,Email_2 from tbClienteZL where Nome like'%" + dados.Nome + "%' order by idCliente";
                //Interação de dados
                SqlDataAdapter ClientesOSDataAdaptar = new SqlDataAdapter(sql, Conexao.obterConexao());
                //Instanciar o Objeto
                ClientesDataTableOS = new DataTable();
                //Popular Datatable
                ClientesOSDataAdaptar.Fill(ClientesDataTableOS);
            }
            catch (SqlException e) { }

        }
    }

}







