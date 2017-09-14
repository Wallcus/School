using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga05
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

    class Program05
    {
        static void Main(string[] args)
        {
        }
    }
}
