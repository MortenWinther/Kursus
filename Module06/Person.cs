using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06
{
    internal class Person //intern klasse
    {

        public string navn;
        public int alder;
        public bool erILive;

        //ctor
        public Person() : this("",0,true)
        {

            // log
            // sikkerhed

            // initialisering

            navn = "";
            erILive = true;
        }

        public Person(string navn, int alder, bool erILive)
        {
            //this
            if (alder < 0 || alder > 110)
                this.alder = 0;
            else this.alder = alder;


            this.alder = alder;
            this.navn = navn;
            this.erILive = erILive;
        }


    }
}
