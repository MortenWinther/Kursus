using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {


            

            int heltal=1;
            heltal++;
            heltal--;
            heltal += 20;
            Console.WriteLine(heltal);

            double kommatal=12.5;
            kommatal++;
            kommatal--;
            kommatal*=2;
            Console.WriteLine(kommatal);

            ///String FilTyper;
            FilTyper ft = FilTyper.csv;
            Console.WriteLine(ft);
            Console.WriteLine((int)ft);

            DateTime dato;
            dato=DateTime.Now;
            Console.WriteLine(dato.ToString("ddMMyy"));
            Console.WriteLine(dato.ToString("ddMMyyyy"));
            Console.WriteLine(dato.ToString("d-M-y"));
            Console.WriteLine(dato.ToString("dd-MM-yyyy"));
            Console.WriteLine(dato.Month);

            Person p;
            p.id = 1;
            p.navn = "Mikkel";
            Console.WriteLine(p.navn);  


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }
    }

    public Struct Person
    {
    public int id;
    public string navn;
}
public enum FilTyper {csv,pdf,txt}
  
}

