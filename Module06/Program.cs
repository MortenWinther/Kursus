using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06
{
    class Program
    {
        static void Main(string[] args)
        {

            Person i=null;
            Console.WriteLine(i);

            i = new Person();
            Console.WriteLine(i);

            i.navn = "Mikkel";
            i.alder = 14;
            i.erILive = true;

            Person u = new Person("Lene", 48, true);
            

            Person w;

            u = null;
            u = i;
            Console.WriteLine(i.navn);
            Console.WriteLine(u.navn);
            w = u;
            Console.WriteLine(w.navn);

            w = null;
            //Console.WriteLine(w.navn);

            Terning t1 = new Terning();
            t1.Skriv();
            Terning t2 = new Terning(6);
            t2.Skriv();
            Terning t3 = new Terning(60);
            t3.Skriv();
            Console.WriteLine(t3.HentVærdi());
            t3.GemVærdi(5);
            t3.Skriv();
            t3.GemVærdi(555);
            t3.Skriv();


        }
    }
}
