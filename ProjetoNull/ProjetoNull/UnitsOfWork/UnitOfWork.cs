using ProjetoNull.Persistencia;
using ProjetoNull.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoNull.UnitsOfWork
{
    public class UnitOfWork : IDisposable
    {

        private NullContext _context = new NullContext();

        private ICandidatoCadastroRepository _candidatoCadastroRepository;
        private ICandidatoInfoRepository _candidatoInfoRepository;
        private IDependentesRepository _dependentesRepository;
        private IFaseRepository _faseRepository;
        private IUsuarioRepository _usuarioRepository;

        public ICandidatoCadastroRepository CandidatoCadastroRepository
        {
            get
            {
                if (_candidatoCadastroRepository == null)
                {
                    _candidatoCadastroRepository = new CandidatoCadastroRepository(_context);
                }
                return _candidatoCadastroRepository;
            }
        }

        public ICandidatoInfoRepository CandidatoInfoRepository
        {
            get
            {
                if (_candidatoInfoRepository == null)
                {
                    _candidatoInfoRepository = new CandidatoInfoRepository(_context);
                }
                return _candidatoInfoRepository;
            }
        }

        public IDependentesRepository DependentesRepository
        {
            get
            {
                if (_dependentesRepository == null)
                {
                    _dependentesRepository = new DependenteRepository(_context);
                }
                return _dependentesRepository;
            }
        }

        public IFaseRepository FaseRepository
        {
            get
            {
                if (_faseRepository == null)
                {
                    _faseRepository = new FaseRepository(_context);
                }
                return _faseRepository;
            }
        }

        public IUsuarioRepository UsuarioRepository
        {
            get
            {
                if (_usuarioRepository == null)
                {
                    _usuarioRepository = new UsuarioRepository(_context);
                }
                return _usuarioRepository;
            }
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}