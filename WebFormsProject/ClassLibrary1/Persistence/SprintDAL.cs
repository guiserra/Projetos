using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClassLibrary1.Model;

namespace ClassLibrary1.Persistence
{
    public class SprintDAL : Conexao
    {

        public void CadastrarSprt(Sprint sp)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("INSERT INTO Sprint (Nome, Semanas, Status, Observacoes) VALUES (@v1, @2, @3, @4)", Con);

                Cmd.Parameters.AddWithValue("@v1", sp.Nome);
                Cmd.Parameters.AddWithValue("@v2", sp.Semanas);
                Cmd.Parameters.AddWithValue("@v3", sp.Status);
                Cmd.Parameters.AddWithValue("@v4", sp.Observacoes);

                Cmd.ExecuteNonQuery(); //Executa o metodo
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao Cadastrar o Sprint: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void AtualizarSprt(Sprint sp)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("UPDATE Sprint SET Nome = @v1, Semanas = @v2, Status = @3, Observacoes = @4 WHERE Codigo = @v5", Con);

                Cmd.Parameters.AddWithValue("@v1", sp.Nome);
                Cmd.Parameters.AddWithValue("@v2", sp.Semanas);
                Cmd.Parameters.AddWithValue("@v3", sp.Status);
                Cmd.Parameters.AddWithValue("@v4", sp.Codigo);
                Cmd.Parameters.AddWithValue("@v5", sp.Observacoes);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao atualizar o Sprint: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void ExcluirSprt(int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("DELETE FROM Sprint WHERE Codigo = @v1", Con);

                Cmd.Parameters.AddWithValue("@v1", Codigo);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao excluir o Sprint: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<Sprint> ListarSprt()
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("SELECT * FROM Sprint", Con);
                Dr = Cmd.ExecuteReader();

                List<Sprint> lista = new List<Sprint>();

                while (Dr.Read())
                {
                    Sprint sp = new Sprint( 
                        Convert.ToInt32(Dr["Codigo"]),
                        Convert.ToString(Dr["Nome"]),
                        Convert.ToInt32(Dr["Semanas"]),
                        Convert.ToBoolean(Dr["Status"]),
                        Convert.ToString(Dr["Observacoes"])
                    );
                    lista.Add(sp);
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao listar os Sprint: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

    }
}
