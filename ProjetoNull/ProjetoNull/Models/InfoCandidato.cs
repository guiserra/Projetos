using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoNull.Models
{
    public class InfoCandidato
    {
        public int InfoCandidatoId { get; set; }
        public bool PresenteF1 { get; set; }
        public bool PresenteF2 { get; set; }
        public bool StatusF1 { get; set; }
        public bool StatusF2 { get; set; }
        public float ProcentagemObtido { get; set; }
        public string Anotacao { get; set; }
        public IEnumerable<double> Notas { get; set; }

        public int Fase1Id { get; set; }
        public Fase1 Fase1 { get; set; }
        public int Fase2Id { get; set; }
        public Fase2 Fase2 { get; set; }
    }
}