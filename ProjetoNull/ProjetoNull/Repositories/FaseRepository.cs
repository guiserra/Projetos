using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using ProjetoNull.Models;
using ProjetoNull.Persistencia;

namespace ProjetoNull.Repositories
{
    public class FaseRepository : IFaseRepository
    {

        private NullContext _context;

        public FaseRepository(NullContext nullContext)
        {
            _context = nullContext;
        }

        public IList<Fase> BuscarPor(Expression<Func<Fase, bool>> filtro)
        {
            return _context.Fases.Where(filtro).ToList();
        }

        public Fase BuscarPorCodigo(int id)
        {
            return _context.Fases.Find(id);
        }

        public void Cadastrar(Fase fase)
        {
            _context.Fases.Add(fase);
        }

        public void Editar(Fase fase)
        {
            _context.Entry(fase).State = EntityState.Modified;
        }

        public void Excluir(int id)
        {
            var est = BuscarPorCodigo(id);
            _context.Fases.Remove(est);
        }

        public IList<Fase> Listar()
        {
            return _context.Fases.ToList();
        }
    }
}