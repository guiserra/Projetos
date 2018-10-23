using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoNull.Models
{
    public class Dependente
    {
        public int DependenteId { get; set; }
        public string Nome { get; set; }
        public string GrauParentesco { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public bool IRRF { get; set; }
    }
}