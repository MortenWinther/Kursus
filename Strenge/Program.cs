using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            string efternavn = "Cronberg";
            string samletNavn = fornavn + " " + efternavn;
            Console.WriteLine(samletNavn);
            string navnStort = samletNavn.ToUpper();
            Console.WriteLine(navnStort);
            string navnLille = samletNavn.ToLower();
            Console.WriteLine(navnLille);

            string del = samletNavn.Substring(7, 4);
            Console.WriteLine(del);

            string[] ar = samletNavn.Split(' ');
            for (int i = 0; i < ar.Length; i++ )
            Console.WriteLine(ar[i]);

            System.IO.File.WriteAllText("c:\\temp\\testarray.txt", samletNavn);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }

    }  
}
