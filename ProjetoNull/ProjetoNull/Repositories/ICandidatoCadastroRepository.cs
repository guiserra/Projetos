using ProjetoNull.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNull.Repositories
{
    public interface ICandidatoCadastroRepository
    {
        void Cadastrar(CadastroCandidato candidatoCadastro);
        void Editar(CadastroCandidato candidatoCadastro);
        void Excluir(int id);
        IList<CadastroCandidato> Listar();
        CadastroCandidato BuscarPorCodigo(int id);
        IList<CadastroCandidato> BuscarPor(Expression<Func<CadastroCandidato, bool>> filtro);
    }
}
