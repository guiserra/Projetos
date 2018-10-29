using ProjetoNull.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNull.Repositories
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuario);
        void Editar(Usuario usuario);
        void Excluir(int id);
        IList<Usuario> Listar();
        Usuario BuscarPorCodigo(int id);
        IList<Usuario> BuscarPor(Expression<Func<Usuario, bool>> filtro);
    }
}
