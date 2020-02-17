using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProject
{
    class auto
    {
        private string marka;
        private string modell;
        private int evjarat;
        private int kilometer;
        private string uzemanyag;
        private int ar;

        public auto(string marka, string modell, int evjarat, int kilometer, string uzemanyag, int ar)
        {
            this.marka = marka;
            this.modell = modell;
            this.evjarat = evjarat;
            this.kilometer = kilometer;
            this.uzemanyag = uzemanyag;
            this.ar = ar;
        }

        public string Marka { get => marka; set => marka = value; }
        public string Modell { get => modell; set => modell = value; }
        public int Evjarat { get => evjarat; set => evjarat = value; }
        public int Kilometer { get => kilometer; set => kilometer = value; }
        public string Uzemanyag { get => uzemanyag; set => uzemanyag = value; }
        public int Ar { get => ar; set => ar = value; }

        public override string ToString()
        {
            return String.Format(marka + "; " + modell + "; " + evjarat + "; " + kilometer + "; " + uzemanyag + "; " + ar);
        }
        
    }
}
