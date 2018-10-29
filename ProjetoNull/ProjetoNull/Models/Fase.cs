using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoNull.Models
{
    public class Fase
    {
        public int FaseId { get; set; }
        public Fase1 Fase1 { get; set; }
        public Fase2 Fase2 { get; set; }
    }
}