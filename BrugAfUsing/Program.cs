using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrugAfUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = System.IO.File.OpenText(@"x:\dyrenavne.txt");
            while (stream.Peek() != -1)
                {
                    string navn  = stream.ReadLine();
                    Console.WriteLine(navn);
                }
            stream.Close();
            stream = null;
            }
    }
}


