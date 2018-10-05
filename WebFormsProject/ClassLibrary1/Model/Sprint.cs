using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Model
{
    public class Sprint
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Semanas { get; set; }
        public Boolean Status { get; set; }
        public string Observacoes { get; set; }

        public Sprint(int Codigo, string Nome, int Semanas, Boolean Status, string Observacoes)
        {
            this.Codigo = Codigo;
            this.Nome = Nome;
            this.Semanas = Semanas;
            this.Status = Status;
            this.Observacoes = Observacoes;
        }
    }
}
