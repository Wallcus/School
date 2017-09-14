using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja01
{
    class Kvadrat1
    {
        public double stranica;

        public double IzracunajPloscino()
        {
            return Math.Pow(stranica, 2);
        }

        public double IzracunajObseg()
        {
            return 4 * stranica;
        }
    }

    class Kvadrat2
    {
        private double stranica;

        public void NastaviStranico(double stranica)
        {
            if (stranica < 0)
            {
                stranica = 0;
            }
            this.stranica = stranica;
        }

        public double IzracunajPloscino()
        {
            return Math.Pow(stranica, 2);
        }

        public double IzracunajObseg()
        {
            return 4 * stranica;
        }
    }

    class Program01
    {
        static void Main(string[] args)
        {
            Kvadrat1 a1 = new Kvadrat1();
            Kvadrat1 a2 = new Kvadrat1();

            a1.stranica = 3;
            a2.stranica = 5;

            Console.WriteLine("a1: " + a1.IzracunajPloscino());
            Console.WriteLine("a1: " + a1.IzracunajObseg());

            Console.WriteLine("a2: " + a2.IzracunajPloscino());
            Console.WriteLine("a2: " + a2.IzracunajObseg());




            Kvadrat2 b1 = new Kvadrat2();
            Kvadrat2 b2 = new Kvadrat2();

            b1.NastaviStranico(3);
            b2.NastaviStranico(5);

            Console.WriteLine("b1: " + b1.IzracunajPloscino());
            Console.WriteLine("b1: " + b1.IzracunajObseg());

            Console.WriteLine("b2: " + b2.IzracunajPloscino());
            Console.WriteLine("b2: " + b2.IzracunajObseg());

            Console.ReadKey();
        }
    }
}
