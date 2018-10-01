using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjetoDAL.Persistence
{
    public class Conexao
    {
        protected SqlConnection Con;
        protected SqlCommand Cmd;
        protected SqlDataReader Dr;

        protected void AbrirConexao()
        {
            try
            {
                Con = new SqlConnection("Data Source=DESKTOP-A9G9V52/SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
                Con.Open();
            }
            catch (Exception e)
            {

                throw new Exception("Não foi possivel conectar-se ao banco :" + e.Message);
            }
        }
        protected void FecharConexao()
        {
            try
            {
                Con.Close();
            }
            catch (Exception e)
            {

                throw new Exception("Não foi possivel fechar a conexão :" + e.Message);
            }
        }

    }
}