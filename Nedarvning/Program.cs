using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedarvning
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    // Klasse Terning
    public class Terning
    {
        //Privat instans af Random
        private static System.Random rnd;
        //Privat felt værdi
        private int værdi;

        //Offentlig egenskab Værdi
        public int Værdi
        {
            get
            {
                Console.WriteLine("Terning aflæses som " + this.værdi);
                return this.værdi;
            }
            set
            {
                if (value < 0 || value > 6)
                    value = 1;
                Console.WriteLine("Terning tildeles " + value);
                this.værdi = value;
            }


        }

        //Offentlig metode Skriv
        public void Skriv()
        {
            Console.WriteLine("[" + this.værdi + "]");
        }

        //Offentlig metode Ryst
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


    public class LudoTerning : Terning
    {
        public bool ErGlobus()
        {
            return this.Værdi == 3;
        }
        public bool ErStjerne()
        {
            return this.Værdi == 5;
        }
        public LudoTerning() : base()
        { }
        public LudoTerning(int værdi) : base(værdi)
        { }
    }
}
