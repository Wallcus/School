using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga02
{
    class Denarnica
    {
        private double stanje;

        public Denarnica()
        {
            Console.WriteLine("Privzeti konstruktor");
            stanje = 0;
        }

        public Denarnica(double zacetnoStanje)
        {
            Console.WriteLine("Pretvorni Konstruktor");
            stanje = zacetnoStanje;
        }

        public Denarnica(Denarnica original)
        {
            Console.WriteLine("Kopirni konstruktor");
            this.stanje = original.stanje;
        }

        public void Dvig(double vsota)
        {
            stanje -= vsota;
        }

        public void Polog(double vsota)
        {
            stanje += vsota;
        }

        public double VrniStanje()
        {
            return stanje;
        }
    }


    class Program02
    {
        static void Main(string[] args)
        {
            Denarnica mirko = new Denarnica();
            Denarnica marko = new Denarnica(mirko);
            Denarnica darko = new Denarnica(100);

            Console.WriteLine("Mirko: " + mirko.VrniStanje());
            mirko.Polog(25);
            mirko.Dvig(5);
            Console.WriteLine(mirko.VrniStanje());

            Console.WriteLine("Marko: " + marko.VrniStanje());
            marko.Polog(25);
            marko.Dvig(5);
            Console.WriteLine(marko.VrniStanje());

            Console.WriteLine("Darko: " + darko.VrniStanje());
            darko.Polog(42);
            darko.Dvig(36);
            Console.WriteLine(darko.VrniStanje());
        }
    }
}
