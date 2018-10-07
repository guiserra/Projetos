using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClassLibrary1.Model;

namespace ClassLibrary1.Persistence
{
    public class UsuarioDAL : Conexao
    {

        public void CadastrarUsu(Usuario u)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("INSERT INTO Usuario (Nome, Email, Senha) VALUES (@v1, @v2, @v3)", Con);

                Cmd.Parameters.AddWithValue("@v1", u.Nome);
                Cmd.Parameters.AddWithValue("@v2", u.Email);
                Cmd.Parameters.AddWithValue("@v3", u.Senha);

                Cmd.ExecuteNonQuery(); //Executa o metodo
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao Cadastrar o Usuário: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public Usuario PesquisarPorCodigo(object codigo)
        {
            throw new NotImplementedException();
        }

        public void AtualizarUsu(Usuario u)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("UPDATE Usuario SET Nome = @v1, Email = @v2, Senha = @v3 WHERE Codigo = @v4", Con);

                Cmd.Parameters.AddWithValue("@v1", u.Nome);
                Cmd.Parameters.AddWithValue("@v2", u.Email);
                Cmd.Parameters.AddWithValue("@v3", u.Senha);
                Cmd.Parameters.AddWithValue("@v4", u.Codigo);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao atualizar o Usuário: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void ExcluirUsu(int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("DELETE FROM Usuario WHERE Codigo = @v1", Con);

                Cmd.Parameters.AddWithValue("@v1", Codigo);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao excluir o Usuário: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public Usuario PesquisarId(int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("SELECT * FROM Usuario WHERE Codigo = @v1", Con);
                Cmd.Parameters.AddWithValue("@v1", Codigo);
                Dr = Cmd.ExecuteReader(); //Execucao da leitura das informaçoes no BD

                Usuario u = null;

                if (Dr.Read())
                {
                    u = new Usuario();

                    u.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    u.Nome = Convert.ToString(Dr["Nome"]);
                    u.Email = Convert.ToString(Dr["Email"]);
                    u.Senha = Convert.ToString(Dr["Senha"]);
                }

                return u;
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

        public List<Usuario> ListarUsu()
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("SELECT * FROM Usuario", Con);
                Dr = Cmd.ExecuteReader();

                List<Usuario> lista = new List<Usuario>();

                while (Dr.Read())
                {
                    Usuario u = new Usuario();

                    u.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    u.Nome = Convert.ToString(Dr["Nome"]);
                    u.Email = Convert.ToString(Dr["Email"]);
                    u.Senha = Convert.ToString(Dr["Senha"]);

                    lista.Add(u);
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao listar os Usuários: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public Usuario ValidarLogin(Usuario u)
        {
            List<Usuario> ul = ListarUsu();
            Usuario cont = new Usuario();

            for (int i = 0; i < ul.Count; i++)
            {
                if (ul[i].Email == u.Email && ul[i].Senha == u.Senha)
                { 
                    cont.Codigo = ul[i].Codigo;
                    cont.Senha = ul[i].Senha;
                    cont.Nome = ul[i].Nome;
                    cont.Email = ul[i].Email;
                }
            }
            return cont;
        }

        public Usuario PesquisarPorCodigo(int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Usuario where Codigo=@v1", Con);

                Cmd.Parameters.AddWithValue("@v1", Codigo);

                Dr = Cmd.ExecuteReader();

                Usuario pessoaEncontrada = new Usuario();

                if (Dr.Read())
                {
                    pessoaEncontrada.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    pessoaEncontrada.Nome = Convert.ToString(Dr["Nome"]);
                    pessoaEncontrada.Email = Convert.ToString(Dr["Email"]);
                    pessoaEncontrada.Senha = Convert.ToString(Dr["Senha"]);
                }

                return pessoaEncontrada;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar o Usuario" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
