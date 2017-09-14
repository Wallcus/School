using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga06
{
    class Datum
    {
        private int dan;
        private int mesec;
        private int leto;

        public Datum()
        {
            dan = 1;
            mesec = 1;
            leto = 2000;
        }

        public Datum(int dan, int mesec, int leto)
        {
            this.dan = dan;
            this.mesec = mesec;
            this.leto = leto;
        }

        public Datum(Datum prvotni)
        {
            this.dan = prvotni.dan;
            this.mesec = prvotni.mesec;
            this.leto = prvotni.leto;
        }

        public int Dan
        {
            get
            {
                return dan;
            }

            set
            {
                dan = value;
            }
        }

        public int Mesec
        {
            get
            {
                return mesec;
            }

            set
            {
                mesec = value;
            }
        }

        public int Leto
        {
            get
            {
                return leto;
            }

            set
            {
                leto = value;
            }
        }

        public bool PreveriVeljavnost()
        {
            if (dan > 31 || dan <= 0)
            {
                RazveljaviVrednosti();
                return false;
            }

            if (mesec > 12 || mesec <= 0)
            {
                RazveljaviVrednosti();
                return false;
            }

            if (leto <= 0)
            {
                RazveljaviVrednosti();
                return false;
            }

            return true;
        }

        private void RazveljaviVrednosti()
        {
            dan = 0;
            mesec = 0;
            leto = 0;
        }

        public string Izpis()
        {
            return String.Format("{0}.{1}.{2}", dan, mesec, leto);
        }
    }

    class Oseba
    {
        private string ime;
        private string priimek;
        private Datum datumRojstva;
 
        public Oseba()
        {
            ime = null;
            priimek = null;
            datumRojstva = null;
        }

        public Oseba(string ime, string priimek, Datum datumRojstva)
        {
            this.ime = ime;
            this.priimek = priimek;
            this.datumRojstva = new Datum(datumRojstva);
        }

        public Oseba(Oseba prvotni)
        {
            this.ime = prvotni.ime;
            this.priimek = prvotni.priimek;
            this.datumRojstva = new Datum(prvotni.datumRojstva);
        }

        public void IzpisPodatkov()
        {
            Console.WriteLine("ime: " + ime);
            Console.WriteLine("priimek: " + priimek);
            Console.WriteLine("datum rojstva: " + datumRojstva.Izpis());
        }

        public string Ime
        {
            get 
            {
                if (ime != null)
                {
                    return ime;
                }
                else
                {
                    return String.Empty;
                }
            }

            set
            {
                if (value != null)
                {
                    ime = value;
                } 
            }
        }

        public string Priimek
        {
            get
            {
                if (priimek != null)
                {
                    return priimek;
                }
                else
                {
                    return String.Empty;
                }
            }

            set
            {
                if (value != null)
                {
                    priimek = value;
                } 
            }
        }

        public Datum DatumRojstva
        {
            get
            {
                return datumRojstva;
            }

            set
            {
                if (value != null)
                {
                    datumRojstva = value;
                } 
            }
        }
    }

    class Program06
    {
        static void Main(string[] args)
        {
            Oseba begunc = new Oseba();
            begunc.Ime = "Abdul";
            begunc.Priimek = "Al Mohammed";
            begunc.DatumRojstva = new Datum(1, 1, 1995);
            Oseba zenaOdBegunca = new Oseba(begunc);
            Oseba miha = new Oseba("Miha", "Podravnikar", new Datum(4, 5, 1998));

            begunc.IzpisPodatkov();
            Console.WriteLine();
            zenaOdBegunca.IzpisPodatkov();
            Console.WriteLine();
            miha.IzpisPodatkov();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
