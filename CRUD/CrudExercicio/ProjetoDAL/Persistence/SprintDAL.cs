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
    }
}