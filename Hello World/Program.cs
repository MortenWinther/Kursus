using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast navn");
            String navn=Console.ReadLine();
            String stort = navn.ToUpper();
            Console.WriteLine("Velkommen "+stort);
            Console.WriteLine("Tryk på en tast for at fortsætte");
            Console.ReadKey(); 


        }
    }
}
