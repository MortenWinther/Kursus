
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int xx = 1; xx < 11; xx++)
            {
                for (int yy = 1; yy < 11; yy++)
                { }
                string tal = (xx * yy).ToString();
                if ((xx * yy) < 50)
                    Console.ForegroundColor = ConsoleColor.Yellow;
                else
                    Console.ForegroundColor = ConsoleColor.White;
                Console.Write(tal.PadLeft(4));
            }
            Console.WriteLine();
            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

    } 

            
     
}
