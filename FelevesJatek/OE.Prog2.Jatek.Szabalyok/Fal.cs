using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelevesJatek.OE.Prog2.Jatek.Szabalyok
{
    class Fal : RogzitettJatekElem
    {

        public Fal(int x ,int y):base (x,y)
        {

        }
        public override int  Meret ()
        {
            return 1;
        }
        public override void  Utkozes(JatekElem Parameter)
        {
            // valami
            //if (Parameter as Jatekos)
            //{
            //    // ha igen
            //   Parameter.PontotSzerez(50);
               
            //}
            //else
            //{
            //    Parameter.Torol();
            //}

        }

    }
}
