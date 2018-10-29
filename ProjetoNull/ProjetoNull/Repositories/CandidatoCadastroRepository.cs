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
    public class CandidatoCadastroRepository : ICandidatoCadastroRepository
    {

        private NullContext _context;

        public CandidatoCadastroRepository(NullContext nullContext)
        {
            _context = nullContext;
        }

        public IList<CadastroCandidato> BuscarPor(Expression<Func<CadastroCandidato, bool>> filtro)
        {
            return _context.CadastroCandidatos.Where(filtro).ToList();
        }

        public CadastroCandidato BuscarPorCodigo(int id)
        {
            return _context.CadastroCandidatos.Find(id);
        }

        public void Cadastrar(CadastroCandidato candidatoCadastro)
        {
            _context.CadastroCandidatos.Add(candidatoCadastro);
        }

        public void Editar(CadastroCandidato candidatoCadastro)
        {
            _context.Entry(candidatoCadastro).State = EntityState.Modified;
        }

        public void Excluir(int id)
        {
            var candidato = BuscarPorCodigo(id);
            _context.CadastroCandidatos.Remove(candidato);
        }

        public IList<CadastroCandidato> Listar()
        {
            return _context.CadastroCandidatos.ToList();
        }
    }
}