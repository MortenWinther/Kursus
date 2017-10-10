using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher w =
                new System.IO.FileSystemWatcher(@"c:\temp", "*");
            w.EnableRaisingEvents = true;
            w.NotifyFilter = System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.Size | System.IO.NotifyFilters.DirectoryName;

            w.Changed += W_Changed;
            //do { } while (true);
            Console.ReadKey();

        }

        private static void W_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine(e.Name + " User: " + Environment.UserName);
        }
    }
}
