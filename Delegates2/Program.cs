using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{
    class Program
    {       
        static void Main(string[] args)
        {
            Maskine m = new Maskine();
            m.Log = Console.WriteLine;
            m.Log += AppendLog;

            // ekstra:
            // m.log+= delegate (string txt) { System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n");};
            // m.log += (txt) => { System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n");};

            m.Start();
            m.Stop();


        }

        static void AppendLog(string txt)
        {
            System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n");
        }
    }

    //public delegate void LogDelegate(string txt); //1

    public class Maskine
    {
        public Action<string> Log{ get; set; } //Bruges i stedet for //1
        //public LogDelegate Log { get; set; } //1

        public void Start()
        {
            Log(DateTime.Now.ToLongDateString() + " - " + DateTime.Now.ToLongTimeString() + ": " + "Starter");
        }

        public void Stop()
        {
            Log(DateTime.Now.ToLongDateString() + " - " + DateTime.Now.ToLongTimeString()+": " + "Stopper");
        }
    }
}
