using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelevesJatek.OE.Prog2.Jatek.Szabalyok
{
    class Jatekos
    {
        private string nev;
        private int eletero=100;
        private int pontszam = 0;


        public string Nev
        {
            get { return nev; }
        }
        public Jatekos(string nev, int x , int y ,JatekTer jatekter ) :base(x,y,jatekter)
        {
            this.nev = nev;
        }
        public override double Meret()
        {
            return 0.2;
        }
        public override void Utkozes()
        {
            //semmitsecsinálok 
        }
        public void Serul(int sebzes)
        {
            if (eletero != 0)
            {
                if (eletero > sebzes)
                {
                    eletero = eletero - sebzes;
                }
                else
                {
                    eletero = 0;
                    // aktiv tulajdonsag hamis 
                }
            }
        }
        public void PontotSzerez(int pontszam)
        {
            this.pontszam += pontszam;
        }
        public void Megy (int rx , int ry )
        {

            // Athelyez();

        }

    }
}
