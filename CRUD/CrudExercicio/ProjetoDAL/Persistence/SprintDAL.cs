using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using ProjetoDAL.Model;

namespace ProjetoDAL.Persistence
{
    public class SprintDAL : Conexao
    {
        public void Cadastrar(Sprint p)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("insert into Sprint (Nome, Descricao, Duracao, DtInicio) values(@v1, @v2, @v3, @v4)", Con);

                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Descricao);
                Cmd.Parameters.AddWithValue("@v3", p.Duracao);
                Cmd.Parameters.AddWithValue("@v4", p.DtInicio);

                Cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                throw new Exception("Não foi possivel cadastrar no banco: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void Atualizar(Sprint p)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("update Sprint set Nome=@v1, Descricao=@v2, Duracao=@v3, DtInicio=@v4 where Codigo=@v5", Con);

                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Descricao);
                Cmd.Parameters.AddWithValue("@v3", p.Duracao);
                Cmd.Parameters.AddWithValue("@v4", p.DtInicio);
                Cmd.Parameters.AddWithValue("@v5", p.SprintId);

                Cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                throw new Exception("Erro ao atualizar a sprint: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public Sprint PesquisarPorCodigo(int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Sprint where Codigo=@v1", Con);

                Cmd.Parameters.AddWithValue("@v1", Codigo);
                Dr = Cmd.ExecuteReader();

                Sprint u = null;

                if (Dr.Read())
                {
                    u = new Sprint();

                    u.SprintId = Convert.ToInt32(Dr["Codigo"]);
                    u.Nome = Convert.ToString(Dr["Nome"]);
                    u.Descricao = Convert.ToString(Dr["Descricao"]);
                    u.DtInicio = Convert.ToDateTime(Dr["DataInicio"]);
                    u.Duracao = Convert.ToInt32(Dr["Duracao"]);
                }
                return u;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<Sprint> Listar()
        {
            try
            {
                AbrirConexao();

                Cmd = new SqlCommand("select * from Sprint", Con);
                Dr = Cmd.ExecuteReader();

                List<Sprint> lista = new List<Sprint>();

                while (Dr.Read())
                {
                    Sprint u = new Sprint();

                    u.SprintId = Convert.ToInt32(Dr["Codigo"]);
                    u.Nome = Convert.ToString(Dr["Nome"]);
                    u.Descricao = Convert.ToString(Dr["Descricao"]);
                    u.DtInicio = Convert.ToDateTime(Dr["DataInicio"]);
                    u.Duracao = Convert.ToInt32(Dr["Duracao"]);

                    lista.Add(u);
                }
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception("Erro ao listar as sprints: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}