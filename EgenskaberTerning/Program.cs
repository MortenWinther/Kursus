using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgenskaberTerning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning();
            t.Skriv();
            t.Ryst();
            t.Skriv();
            t.Værdi = 7;
            t = new Terning(6);
            t.Skriv();

        }
    }
    public class Terning
    {

        private static System.Random rnd = new Random();
        public int Værdi
        {
            get
            {
                Console.WriteLine("Terning værdi " + this.Værdi);
                return this.Værdi;
            }
            set
            {
                if (value < 0 || value > 6)
                    value = 1;
                Console.WriteLine("Terning værdi " + value);
                this.Værdi=value;            }
        }
        public void Skriv()
        {
            Console.WriteLine("[" + this.Værdi + "]");
        }
        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7); 
        }
        public Terning()
        {
            this.Ryst();
        }
        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }

    }
}
