using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Model
{
    public class Projeto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public List<Usuario> listaUsu;
        public List<Sprint> listaSprint;
    }
}
