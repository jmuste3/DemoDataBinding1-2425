using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDataBinding1
{
    public class Llibre
    {
        //propietats
        public string Titol { get; set; }
        public string Autor { get; set; }
        public int Any { get; set; }
        public bool Prestat { get; set; }

        //constructor
        public Llibre(string titol, string autor, int any, bool prestat)
        {
            Titol = titol;
            Autor = autor;
            Any = any;
            Prestat = prestat;
        }
    }
}
