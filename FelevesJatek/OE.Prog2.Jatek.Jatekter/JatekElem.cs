using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelevesJatek
{
    class JatekElem
    {
        int x;
        int y;
        private JatekTer ter{get => ref this.ter ;}
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    
           public JatekElem (int x, int y, ref JatekTer ter)
	{
            this.x = x;
            this.y = y;
            this.ter = ter;
            ter.Felvetel(JatekElem);
	}
}
}
