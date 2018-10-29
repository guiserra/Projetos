using ProjetoNull.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ProjetoNull.Models;
using System.Web;
using System.Data.Entity;

namespace ProjetoNull.Repositories
{
    public class DependenteRepository : IDependentesRepository
    {

        private NullContext _context;

        public DependenteRepository(NullContext nullContext)
        {
            _context = nullContext;
        }

        public IList<Dependente> BuscarPor(Expression<Func<Dependente, bool>> filtro)
        {
            return _context.Dependentes.Where(filtro).ToList();
        }

        public Dependente BuscarPorCodigo(int id)
        {
            return _context.Dependentes.Find(id);
        }

        public void Cadastrar(Dependente dependente)
        {
            _context.Dependentes.Add(dependente);
        }

        public void Editar(Dependente dependente)
        {
            _context.Entry(dependente).State = EntityState.Modified;
        }

        public void Excluir(int id)
        {
            var est = BuscarPorCodigo(id);
            _context.Dependentes.Remove(est);
        }

        public IList<Dependente> Listar()
        {
            return _context.Dependentes.ToList();
        }
    }
}