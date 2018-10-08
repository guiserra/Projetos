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

        public void CadastrarSprt(Sprint sp, int cod)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("INSERT INTO Sprint (Nome, Semanas, Status, Observacoes, Cod_Proj) VALUES (@v1, @v2, @v3, @v4, @v5)", Con);

                Cmd.Parameters.AddWithValue("@v1", sp.Nome);
                Cmd.Parameters.AddWithValue("@v2", sp.Semanas);
                Cmd.Parameters.AddWithValue("@v3", sp.Status);
                Cmd.Parameters.AddWithValue("@v4", sp.Observacoes);
                Cmd.Parameters.AddWithValue("@v5", cod);

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
                Cmd = new SqlCommand("UPDATE Sprint SET Nome = @v1, Semanas = @v2, Status = @v3, Observacoes = @v4 WHERE Codigo = @v5", Con);

                Cmd.Parameters.AddWithValue("@v1", sp.Nome);
                Cmd.Parameters.AddWithValue("@v2", sp.Semanas);
                Cmd.Parameters.AddWithValue("@v3", sp.Status);
                Cmd.Parameters.AddWithValue("@v4", sp.Observacoes);
                Cmd.Parameters.AddWithValue("@v5", sp.Codigo);

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

        public Sprint PesquisarId(int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("SELECT * FROM Sprint WHERE Codigo = @v1", Con);
                Cmd.Parameters.AddWithValue("@v1", Codigo);
                Dr = Cmd.ExecuteReader(); //Execucao da leitura das informaçoes no BD

                Sprint p = null;

                if (Dr.Read())
                {
                    p = new Sprint();

                    p.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    p.Nome = Convert.ToString(Dr["Nome"]);
                    p.Semanas = Convert.ToInt32(Dr["Semanas"]);
                    p.Status = Convert.ToBoolean(Dr["Status"]);
                    p.Observacoes = Convert.ToString(Dr["Observacoes"]);
                }

                return p;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao buscar Sprint: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<Sprint> ListarSprt(int cod)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("SELECT * FROM Sprint WHERE Cod_Proj = @v1", Con);
                Cmd.Parameters.AddWithValue("@v1", cod);
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
