using ProjetoDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ProjetoDAL.Persistence
{
    public class ProjetoDAL : Conexao
    {
        public void Cadastrar(Projeto p)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("insert into Projeto (Nome, Tipo) values(@v1, @v2, @v3)", Con);

                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Tipo);

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

        public void Atualizar(Projeto p)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("update Projeto set Nome=@v1, Tipo=@v2 where Codigo=@v3", Con);

                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Tipo);
                Cmd.Parameters.AddWithValue("@v3", p.ProjetoId);

                Cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                throw new Exception("Erro ao atualizar usuário: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}