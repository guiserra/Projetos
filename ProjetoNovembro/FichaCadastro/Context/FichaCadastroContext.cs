using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using FichaCadastro.Models;

namespace FichaCadastro.Context
{
    public class FichaCadastroContext : DbContext
    {
        public FichaCadastroContext()
            : base("DESKTOP-I4HO4A0")
        {

        }

        public DbSet<FichaDeCadastro> FichaDeCadastros { get; set; }
    }
}