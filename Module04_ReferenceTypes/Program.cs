using System;


namespace Module04_ReferenceTypes
{
    class Program
    {
                   

        static void Main(string[] args)
        {

            PersonStruct p1;
            p1.Id = 1;
            //p1.ErILive = true;

            PersonStruct p2 = new PersonStruct();
            p2.Id = 2;
            //p2.ErILive = true;

            PersonClass p3;
            p3 = new PersonClass();
            p3.Id = 3;
            Console.WriteLine(p3.Id);

            PersonClass p4;
            p4 = new PersonClass();
            p4.Id = 4;
            //p4.ErILive = false;
            Console.WriteLine(p3.Id);

            p3 = p4;

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }

    struct PersonStruct
    {
        public int Id;  
    }

    class PersonClass
    {
        public int Id;      
    }
}
