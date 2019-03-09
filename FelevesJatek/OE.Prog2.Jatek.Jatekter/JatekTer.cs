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

        public JatekElem[] MegadottHelyenLevök ( int x, int y, int tavolsag)
        {
            
            int i=0;
            
            int[] megfelelöelemek = new int[Max_Elemszam]; //idx-eit tárolja az elemeknek amik teljesítik a kitételt
            int idx =0;
            for (int j = 0; j < elemek.Length; j++)
			{
                if (Math.Abs(x-elemek[j].X) <= tavolsag &&  Math.Abs(y-elemek[j].Y) <= tavolsag)
                {
                i++;  
                    megfelelöelemek[idx]=j;
                }
			}

            JatekElem[] megadottHelyenLevok = new JatekElem[i];
            
                for (int j = 0; j < megadottHelyenlevok.Length; j++)
			    {
                    MegadottHelyenLevök[j]= elemek[megfelelöelemek[j]];
			    }
            return megadottHelyenLevok;
        }

        public JatekElem[] MegadottHelyenLevök ( int x, int y)
            {
            MegadottHelyenLevök(x, y, 0)
            ;}



    }
}
