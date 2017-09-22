using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvPerson
{
    class Program
    {
        static void Main(string[] args)
            //Skab objekter med New
        {
            Person p = new Person() { Efternavn = "x", Fornavn = "y" };
            Elev e = new Elev() { Efternavn = "t", Fornavn = "g", Klasselokale = "A" };
            Instruktør i = new Instruktør() { Efternavn = "2", Fornavn = "s", NøgleID = 1};
            Console.WriteLine(p.Fuldtnavn());
            Console.WriteLine(e.Fuldtnavn());
            Console.WriteLine(i.Fuldtnavn());
            
        }
    }
    //Klasse Person
    public class Person
    {
        //Egenskaber Fornavn og Efternavn
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }        
        //Metode Fuldtnavn
        public string Fuldtnavn()
        {
            return $"{Fornavn} {Efternavn}";
        }

    }
    //Klasse Elev
    public class Elev : Person     {
        public string  Klasselokale { get; set; }
     }
    //Klasse instruktør
    public class Instruktør : Person { 
    public int NøgleID { get; set; }
    }
}
