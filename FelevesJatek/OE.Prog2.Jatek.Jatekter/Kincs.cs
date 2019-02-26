using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelevesJatek.OE.Prog2.Jatek.Jatekter
{
    class Kincs : RogzitettJatekElem
    {
        public Kincs(int x , int y ) : base(x,y)
        {

        }
        public override int Meret()
        {
            return 1;
        }
        public override void Utkozes(JatekElem Parameter)
        {
            if (Parameter is Jatekos)
            {

            }
        }

    }
}
