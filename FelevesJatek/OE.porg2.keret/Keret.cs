﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelevesJatek
{
    class Keret

    {

        const int PALYA_MERET_X = 21;
        const int PALYA_MERET_Y = 11;
        const int Kincsek_Szama = 10;
        private bool jatekVege = false;
        private JatekTer ter;
        
private void PalyaGenerálás(int x, int y)
        {
            int db=0;
            Random r = new Random();
            int[] kincsX= new int[10];
            for (int i = 0; i < kincsX.Length; i++)
			{
                kincsX[i]=r.Next(1,21);
			}
            kincsX.OrderBy<int>;
            int[] kincsY= new int[10];
            for (int i = 0; i < kincsY.Length; i++)
			{
                kincsX[i]=r.Next(1,10);
			}
            int kincsSzamlalo = 0;
            ter = new JatekTer(x, y);
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (j==0 || x==j)
                    {
                        ter.Felvetel(new Fal(j,i ));
                    }
                    else if (i == 0 || i ==y)
                    {
                        ter.Felvetel(new Fal(j,i));
                    }
                    else if (i!=1 || j !=1 || kincsX[db]==j|| kincsY[db]==i)
                    {
                        ter.Felvetel(new Kincs(j,i));
                        db++;
                    }
                }
            }
           
        }
        public void Futtatás()
        {
            Jatekos jatekos = new Jatekos("Béla", 1, 1, ter);
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.LeftArrow) jatekos.Megy(-1, 0);
                if (key.Key == ConsoleKey.RightArrow) jatekos.Megy(1, 0);
                if (key.Key == ConsoleKey.UpArrow) jatekos.Megy(0, -1);
                if (key.Key == ConsoleKey.DownArrow) jatekos.Megy(0, 1);
                if (key.Key == ConsoleKey.Escape) jatekVege = true;
            } while (!jatekVege);
        }
        public Keret()
        {
            this.ter = new JatekTer(PALYA_MERET_X, PALYA_MERET_Y);
            PalyaGenerálás(PALYA_MERET_X, PALYA_MERET_Y);
            
        }

    }
}
