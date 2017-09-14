using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga04
{
    class Stevec
    {
        private int vrednost;

        public Stevec()
        {
            vrednost = 0;
        }

        public Stevec(int zacetnaVrednost)
        {
            vrednost = zacetnaVrednost;
        }

        public Stevec(Stevec prvotni)
        {
            this.vrednost = prvotni.vrednost;
        }

        public void PristejEno()
        {
            vrednost++;
        }

        public void OdstejEno()
        {
            vrednost--;
        }

        public int Vrednost()
        {
            return vrednost;
        }
    }

    class Program04
    {
        static void Main(string[] args)
        {
            Stevec stevec1 = new Stevec();
            Stevec stevec2 = new Stevec(3);
            Stevec stevec3 = new Stevec(stevec2);

            Console.WriteLine(stevec1.Vrednost());
            stevec1.PristejEno();
            stevec1.PristejEno();
            stevec1.PristejEno();
            stevec1.PristejEno();
            Console.WriteLine(stevec1.Vrednost());

            Console.WriteLine();

            Console.WriteLine(stevec2.Vrednost());
            stevec2.OdstejEno();
            stevec2.OdstejEno();
            Console.WriteLine(stevec2.Vrednost());

            Console.WriteLine();

            Console.WriteLine(stevec3.Vrednost());
            stevec2.OdstejEno();
            stevec2.OdstejEno();
            Console.WriteLine(stevec2.Vrednost());
        }
    }
}
