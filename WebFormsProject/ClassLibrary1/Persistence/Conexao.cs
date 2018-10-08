using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClassLibrary1.Persistence
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
                Con = new SqlConnection("Data Source=DESKTOP-A9G9V52\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
                Con.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao acessar Banco de Dados.\n" + e.Message);
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
                throw new Exception("Erro ao Fechar Conexão.\n" + e.Message);
            }
        }
    }
}
