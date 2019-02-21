using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelevesJatek
{
    class JatekTer
    {
        const int Max_Elemszam = 1000;
        private int elemN;
        private JatekElem[] elemek = new JatekElem[Max_Elemszam];
        private int meretX;
        public int MeretX
        {
            get { return meretX; }
        }
        private int meretY;

        public int MeretY
        {
            get { return meretY; }
            set { meretY = value; }
        }
        public JatekTer(int meretX , int meretY)
        {
            this.meretX = meretX;
            this.meretY = meretY;
        }
        /// <summary>
        /// felesz 1 elemet az elemek tömbbe 
        /// </summary>
        /// <param name="jatekelem"> 1 darab jatekelem </param>
        public void Felvetel(JatekElem jatekelem)
        {
            elemN++;
            elemek[elemN] = jatekelem;
        }
        /// <summary>
        /// törli az adot jatek elemet a tömb böl 
        /// </summary>
        /// <param name="jatekelem"></param>
        public void Törles(JatekElem jatekelem)
        {
            int j = 0;
            while (elemek[j] != jatekelem && j <= elemN)
            {
                if (elemek[j] == jatekelem)
                {
                    elemek[j] = null;
                    elemN--;
                }
                j++;
            }
            if (j > elemN)
            {
                Console.WriteLine("Nincs ilyen elem ");

            }
           
        }






    }
}
