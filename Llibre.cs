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
        private bool _Prestat { get; set; }
        private bool _Comprat { get; set; }
        public bool Prestat
        {
            get => _Prestat;
            //evitar escritures recursives en actualitzar una propietat: s'escriu a les propietats privades
            set
            {
                _Prestat = value;
                _Comprat = !value;
            }
        }
        public bool Comprat
        {
            get => _Comprat;
            set
            {
                _Comprat = !value;
                _Prestat = value;
            }
        }
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
