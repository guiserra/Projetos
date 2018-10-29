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
    public class UsuarioRepository : IUsuarioRepository
    {
        private NullContext _context;

        public UsuarioRepository(NullContext nullContext)
        {
            _context = nullContext;
        }

        public IList<Usuario> BuscarPor(Expression<Func<Usuario, bool>> filtro)
        {
            return _context.Usuarios.Where(filtro).ToList();
        }

        public Usuario BuscarPorCodigo(int id)
        {
            return _context.Usuarios.Find(id);
        }

        public void Cadastrar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
        }

        public void Editar(Usuario usuario)
        {
            _context.Entry(usuario).State = EntityState.Modified;
        }

        public void Excluir(int id)
        {
            var est = BuscarPorCodigo(id);
            _context.Usuarios.Remove(est);
        }

        public IList<Usuario> Listar()
        {
            return _context.Usuarios.ToList();
        }
    }
}