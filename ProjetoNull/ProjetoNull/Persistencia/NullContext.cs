using ProjetoNull.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoNull.Persistencia
{
    public class NullContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<InfoCandidato> InfoCandidatos { get; set; }
        public DbSet<Dependente> Dependentes { get; set; }
        public DbSet<CadastroCandidato> CadastroCandidatos { get; set; }
        public DbSet<Fase> Fases { get; set; }

    }
}