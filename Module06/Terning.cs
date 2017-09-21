using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06
{
    public class Terning 
    {
        private int værdi;

        public Terning() : this(4)
        {
            //this.værdi = 4;
        }
        public Terning(int startVærdi)
        {
            if(startVærdi<1||startVærdi>6)
            this.værdi = 1;
            startVærdi = 1;

        }

        public void Skriv()
        {
            Console.WriteLine();
        }

        public int HentVærdi()
        {
            return this.værdi;
        }

        public void GemVærdi(int værdi)
        {
            if (værdi < 1 || værdi > 6)  
                værdi = 1;
        }

            
    }
}
