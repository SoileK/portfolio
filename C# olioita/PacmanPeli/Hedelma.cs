using System;
using System.Collections.Generic;
using System.Text;

namespace PacmanPeli
{
    class Hedelma
    {
        private bool nakyvissa;

        public Hedelma()
        {
            nakyvissa = true;
        }

        public void Katoa()
        {
            nakyvissa = false;
            Console.WriteLine("Hedelmä piilotettu");
        }
    }
}
