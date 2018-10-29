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
    public class CandidatoInfoRepository : ICandidatoInfoRepository
    {

        private NullContext _context;

        public CandidatoInfoRepository(NullContext nullContext)
        {
            _context = nullContext;
        }

        public IList<InfoCandidato> BuscarPor(Expression<Func<InfoCandidato, bool>> filtro)
        {
            return _context.InfoCandidatos.Where(filtro).ToList();
        }

        public InfoCandidato BuscarPorCodigo(int id)
        {
            return _context.InfoCandidatos.Find(id);
        }

        public void Cadastrar(InfoCandidato infoCand)
        {
            _context.InfoCandidatos.Add(infoCand);
        }

        public void Editar(InfoCandidato infoCand)
        {
            _context.Entry(infoCand).State = EntityState.Modified;
        }

        public void Excluir(int id)
        {
            var candidato = BuscarPorCodigo(id);
            _context.InfoCandidatos.Remove(candidato);
        }

        public IList<InfoCandidato> Listar()
        {
            return _context.InfoCandidatos.ToList();
        }
    }
}