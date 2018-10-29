using ProjetoNull.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNull.Repositories
{
    public interface IDependentesRepository
    {
        void Cadastrar(Dependente dependente);
        void Editar(Dependente dependente);
        void Excluir(int id);
        IList<Dependente> Listar();
        Dependente BuscarPorCodigo(int id);
        IList<Dependente> BuscarPor(Expression<Func<Dependente, bool>> filtro);
    }
}
