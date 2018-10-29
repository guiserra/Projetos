using ProjetoNull.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNull.Repositories
{
    public interface ICandidatoInfoRepository
    {
        void Cadastrar(InfoCandidato infoCand);
        void Editar(InfoCandidato infoCand);
        void Excluir(int id);
        IList<InfoCandidato> Listar();
        InfoCandidato BuscarPorCodigo(int id);
        IList<InfoCandidato> BuscarPor(Expression<Func<InfoCandidato, bool>> filtro);
    }
}
