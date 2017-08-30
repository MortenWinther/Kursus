using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4Array
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] månedsløn = { 10000, 20000, 30000, 40000, 50000, 60000 };
            double sum = 0;
            for (int i = 0; i < månedsløn.Length; i++)
            {
                sum += månedsløn[i];
                double gns = sum / månedsløn.Length;

                for int i=0;i<månedsløn.Length;i++)
                {
                    Console.WriteLine(månedsløn[i]); 
                }

                //Console.WriteLine("Gennemsnit "+gns.ToString("N2"));

            }
            //Console.WriteLine("Gennemsnit " + gns.ToString("N2"));

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
