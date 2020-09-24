using System;
using System.Collections.Generic;
using System.Text;

namespace PacmanPeli
{
    class Pacman
    {
        private int pisteet;
        private int elamat;

        public Pacman()
        {
            pisteet = 0;
            elamat = 3;
        }
        public void TulostaTiedot()
        {
            Console.WriteLine("Pisteet: " + pisteet +"\n"+ "Elämät: " + elamat);
            Console.WriteLine();
        }

        public void Syo(Hedelma h)
        {
            Console.WriteLine("Hedelmä syöty");
            h.Katoa();
            pisteet += 1;
        }

        public void VahennaElama()
        {
            if (elamat == 0)
            {
                Console.WriteLine("Game over");
                Console.Write("Kiitos pelistä");
            }
            else if (elamat >= 1)
            {
                Console.WriteLine("Pacman syöty");
                Console.WriteLine("Yksi elämä menetetty");
                elamat -= 1;
            }                
        }
    }
}
