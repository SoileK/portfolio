using System;

namespace SoileHarjoitustyöOpiskeluOnHauskaa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Määritetään opiskelu on hauskaa ja luetaan se char-taulukkoon
            string k = "opiskeluonhauskaa";
            char[] opiskelu =k.ToCharArray(0, k.Length);
            
            //Pyydetään merkkijono ja luetaan se char-taulukkoon
            Console.Write("Anna merkkijono: ");
            string syote = Console.ReadLine();
            syote = syote.ToLower();
            char[] taulu = syote.ToCharArray(0, syote.Length);

            Console.WriteLine();
            Console.WriteLine("Verrataan syötettä lauseeseen 'Opiskelu on hauskaa'");
            Console.WriteLine();

            //Muunnetaan täsmäävät merkit väliviivoiksi
            for (int i = 0; i < taulu.Length; i++)
            {
                for (int j = 0; j < opiskelu.Length; j++)
                {
                    if (taulu[i] == opiskelu[j])
                    {
                        taulu[i] = '-';
                        opiskelu[j] = '-';
                    }
                }
            }

            //lasketaan opiskelutaulusta väliviivoiksi muutettujen indeksien määrä
            int lkm = 0;

            for (int j = 0; j < opiskelu.Length; j++)
            {
                if (opiskelu[j] == '-')
                {
                    lkm++;
                }
            }

            //Tulostetaan lopputulos väliviivojen määrän perusteella
            if (lkm == 17)
            {
                Console.WriteLine("tulostus onnistui, ylimääräiset merkit:");
                tulostataulu(taulu);
            }
            else
            {
                Console.WriteLine("Tulostus epäonnistui, puuttuvat merkit: ");
                tulostataulu(opiskelu);
            }

            Console.WriteLine();
            Console.ReadKey();
        }

        private static void tulostataulu(char[] taulu)
        {
            //Taulujen tulostus aliohjelmassa
            for (int i = 0; i < taulu.Length; i++)
            {
                if (taulu[i] != '-')
                {
                    Console.Write(taulu[i]+" ");
                }
            }
        }        
    }
}
