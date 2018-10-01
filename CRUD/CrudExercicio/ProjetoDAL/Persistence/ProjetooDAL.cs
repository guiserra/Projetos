using ProjetoDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ProjetoDAL.Persistence
{
    public class ProjetooDAL : Conexao
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

        public Projeto PesquisarPorCodigo(int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Projeto where Codigo=@v1", Con);

                Cmd.Parameters.AddWithValue("@v1", Codigo);
                Dr = Cmd.ExecuteReader();

                Projeto u = null;

                if (Dr.Read())
                {
                    u = new Projeto();

                    u.ProjetoId = Convert.ToInt32(Dr["Codigo"]);
                    u.Nome = Convert.ToString(Dr["Nome"]);
                    u.Tipo = Convert.ToString(Dr["Tipo"]);
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

        public List<Projeto> Listar()
        {
            try
            {
                AbrirConexao();

                Cmd = new SqlCommand("select * from Projeto", Con);
                Dr = Cmd.ExecuteReader();

                List<Projeto> lista = new List<Projeto>();

                while (Dr.Read())
                {
                    Projeto u = new Projeto();

                    u.ProjetoId = Convert.ToInt32(Dr["Codigo"]);
                    u.Nome = Convert.ToString(Dr["Nome"]);
                    u.Tipo = Convert.ToString(Dr["Tipo"]);

                    lista.Add(u);
                }
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception("Erro ao listar os projetos: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}