using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bunke b = new Bunke();



        }
    }
    public class Kort {
        public string Kulør { set; get; }
        public int Værdi { set; get; }
        public override string ToString()               
            {
                return this.Kulør + " " + this.Værdi;
            }

    }
    public class Bunke
    {
        private Stack<Kort> bunke = new Stack<Kort>();
        public void TilføjKort(Kort k)
        {
            bunke.Push(k);
        }
    }

 }

