using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Namespace para conexão e acesso a dados
using System.Data;
using System.Data.SqlClient;
using AcessoBanco.Properties;

namespace AcessoBanco
{
    public class Conexao
    {

        //Criar Conexão
        private static string strConn = Settings.Default.StrConexao;

        //Representa a conexão com o banco
        private static SqlConnection conn = null;

        //Método que Permite Obter a Conexão

        public static SqlConnection obterConexao()
        {
            //Vamos Criar a Conexao
            //Instanciar
            conn = new SqlConnection(strConn);

            //Tratamento de Erros
            try
            {

                //Abre a Conexão e a Devolve ao Chamador do Método
                conn.Open();

            }
            catch (SqlException e)
            {

                //Retorna a Variável Como Nulo
                conn = null;
                //Apresentar a Mensagem de Excessão
                throw e;

            }
            return conn;

        }
    }
}
