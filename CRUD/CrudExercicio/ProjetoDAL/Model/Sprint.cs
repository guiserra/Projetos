using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDAL.Model
{
    public class Sprint
    {
        public int SprintId { get; set; }
        public string Descricao { get; set; }
        public string Nome { get; set; }
        public int Duracao { get; set; }
        public DateTime DtInicio { get; set; }
    }
}
