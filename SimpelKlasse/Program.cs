using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpelKlasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Fornavn = "Morten";
            p1.Efternavn = "Winther";
            p1.Fødselsår = 1964;
            Console.WriteLine(p1.FuldtNavn());
           
        }
    }
    class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;
        public string FuldtNavn()
        {
            return $"{ Fornavn} { Efternavn}";
        }

        public int Alder()
        { 
        int årnu = DateTime.Now.Year;
        return årnu - this.Fødselsår;
        }

        //default constructor
        public Person()
        {
            this.Fornavn = "";
            this.Efternavn = "";
        }

        //custom constructor
        public Person(string Efternavn, string Fornavn , int Fødselsår)
        {

            this.Fornavn = Fornavn.ToUpper();
            this.Efternavn = Efternavn.ToUpper();
            this.Fødselsår = Fødselsår;

        }

    }
}


