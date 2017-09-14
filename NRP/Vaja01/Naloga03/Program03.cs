using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga03
{
    class Semafor
    {
        private string stanje;

        public Semafor()
        {
            stanje = "rdeca";
        }

        public void NastaviZelenoLuc()
        {
            stanje = "zelena";
        }

        public void NastaviRumenoLuc()
        {
            stanje = "rumena";
        }

        public void NastaviRdecoLuc()
        {
            stanje = "rdeča";
        }

        public bool PoskusPreckanjeCeste()
        {
            if (stanje == "zelena") 
                return true;
            else 
                return false;
        }
    }

    class Program03
    {
        static void Main(string[] args)
        {
            Semafor prehod1 = new Semafor();

            Console.WriteLine(prehod1.PoskusPreckanjeCeste());
            prehod1.NastaviRumenoLuc();
            Console.WriteLine(prehod1.PoskusPreckanjeCeste());
            prehod1.NastaviZelenoLuc();
            Console.WriteLine(prehod1.PoskusPreckanjeCeste());

        }
    }
}
