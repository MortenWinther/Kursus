using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            UdvidetRandom r = new UdvidetRandom();
            Console.WriteLine(r.NextBool());

        }
    }
    //Klasse UdvidetRandom med arv fra system.random
    public class UdvidetRandom : System.Random
    {
        //Metode NextBool
        public bool NextBool()
        {
            return this.Next(1, 1002) < 500;
        }
    }

    
}
