using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasserOgArraysIgen
{
    class Program
    {
        static void Main(string[] args)
        {
            YatzyBæger b = new YatzyBæger();
            b.Skriv();
            b.Ryst();
            b.Skriv();
        }
    }

    public class YatzyBæger
    {
        private Terning[] terninger;

        public YatzyBæger()
        {
            terninger = new Terning[5];
            for (int i = 0; i < 5; i++)
                terninger[i]= new Terning();
        }
        public void Ryst()
        {
            foreach (var item in this.terninger)
                item.Ryst();           
        }
        public void Skriv()
        {
            foreach (var item in this.terninger)
                item.Skriv();
            Console.WriteLine();
        }
        
    }

    public class Terning
    {
        private static System.Random rnd;
        private int værdi;

        public int Værdi
        {
            get {
                return this.værdi;
                    }
            set
            {
                if (value < 0 || value > 6)
                    value = 1;
                this.værdi = value;
            }
        }

        public virtual void Skriv()
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

        static Terning()
        {
            rnd = new Random();
        }
    }
}
