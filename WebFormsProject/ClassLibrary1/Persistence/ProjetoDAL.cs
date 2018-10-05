using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClassLibrary1.Model;

namespace ClassLibrary1.Persistence
{
    public class ProjetoDAL : Conexao
    {

        public void CadastrarProj(Projeto p)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("INSERT INTO Projetos (Nome) VALUES (@v1)", Con);

                Cmd.Parameters.AddWithValue("@v1", p.Nome);

                Cmd.ExecuteNonQuery(); //Executa o metodo
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao Cadastrar o Projeto: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void AtualizarProj(Projeto p)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("UPDATE Projetos SET Nome = @v1 WHERE Codigo = @v2", Con);

                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Codigo);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao atualizar o Projeto: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void ExcluirProj(int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("DELETE FROM Projetos WHERE Codigo = @v1", Con);

                Cmd.Parameters.AddWithValue("@v1", Codigo);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao excluir o Projeto: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public Projeto PesquisarId(int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("SELECT * FROM Projetos WHERE Codigo = @v1", Con);
                Cmd.Parameters.AddWithValue("@v1", Codigo);
                Dr = Cmd.ExecuteReader(); //Execucao da leitura das informaçoes no BD

                Projeto p = null;

                if (Dr.Read())
                {
                    p = new Projeto();

                    p.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    p.Nome = Convert.ToString(Dr["Nome"]);
                }

                return p;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao buscar Projeto: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<Projeto> ListarProj()
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("SELECT * FROM Projetos", Con);
                Dr = Cmd.ExecuteReader();

                List<Projeto> lista = new List<Projeto>();

                while (Dr.Read())
                {
                    Projeto p = new Projeto();

                    p.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    p.Nome = Convert.ToString(Dr["Nome"]);

                    lista.Add(p);
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao listar os Projetos: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
