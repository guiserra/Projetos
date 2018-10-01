using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using ProjetoDAL.Model;

namespace ProjetoDAL.Persistence
{
    public class UsuarioDAL : Conexao
    {

        public void Cadastrar(Usuario u)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("insert into Usuario (Nome, Login, Senha) values(@v1, @v2, @v3)", Con);

                Cmd.Parameters.AddWithValue("@v1", u.Nome);
                Cmd.Parameters.AddWithValue("@v2", u.Login);
                Cmd.Parameters.AddWithValue("@v3", u.Senha);

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

        public void Atualizar(Usuario u)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("update Usuario set Nome=@v1, Login=@v2, Senha=@v3 where Codigo=@v4", Con);

                Cmd.Parameters.AddWithValue("@v1", u.Nome);
                Cmd.Parameters.AddWithValue("@v2", u.Login);
                Cmd.Parameters.AddWithValue("@v3", u.Senha);
                Cmd.Parameters.AddWithValue("@v4", u.UsuarioId);

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

        public void Excluir(int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("delete from Usuario where Codigo=@v1", Con);

                Cmd.Parameters.AddWithValue("@v1", Codigo);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception("Erro ao excluir usuario: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<Usuario> Listar()
        {
            try
            {
                AbrirConexao();

                Cmd = new SqlCommand("select * from Usuario", Con);
                Dr = Cmd.ExecuteReader();

                List<Usuario> lista = new List<Usuario>();

                while (Dr.Read())
                {
                    Usuario u = new Usuario();

                    u.UsuarioId = Convert.ToInt32(Dr["Codigo"]);
                    u.Nome = Convert.ToString(Dr["Nome"]);
                    u.Login = Convert.ToString(Dr["Login"]);
                    u.Senha = Convert.ToString(Dr["Senha"]);

                    lista.Add(u);
                }
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception("Erro ao listar os clientes: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}