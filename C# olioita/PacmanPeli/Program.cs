using System;

namespace PacmanPeli
{
    class Program
    {
        static void Main(string[] args)
        {
            Pacman pacman = new Pacman();

            pacman.TulostaTiedot();            

            Hedelma h1 = new Hedelma();
            Hedelma h2 = new Hedelma();
            Hedelma h3 = new Hedelma();

            Ghost ghost = new Ghost();

            pacman.Syo(h1);
            pacman.TulostaTiedot();

            ghost.SyoPacman(pacman);
            pacman.TulostaTiedot();

            pacman.Syo(h2);
            pacman.TulostaTiedot();

            ghost.SyoPacman(pacman);
            pacman.TulostaTiedot();

            pacman.Syo(h3);
            pacman.TulostaTiedot();

            ghost.SyoPacman(pacman);
            pacman.TulostaTiedot();

            ghost.SyoPacman(pacman);

            Console.ReadKey();
        }
    }
}
