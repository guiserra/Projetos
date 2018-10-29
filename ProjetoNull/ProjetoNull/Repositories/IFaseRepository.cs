using ProjetoNull.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNull.Repositories
{
    public interface IFaseRepository
    {
        void Cadastrar(Fase fase);
        void Editar(Fase fase);
        void Excluir(int id);
        IList<Fase> Listar();
        Fase BuscarPorCodigo(int id);
        IList<Fase> BuscarPor(Expression<Func<Fase, bool>> filtro);
    }
}
