using NLog;
using System;
namespace LogDemo
{
    class Program
    {
        private static Logger logger=LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            logger.Trace("Enter");
            logger.Debug("Kald test1");
            test1(5, 5);
            logger.Debug("Retur test1");
            logger.Debug("Kald test2");
            test2();
            logger.Debug("Retur test1");
        }
            static void test1(int i, int x)
        {
            Console.WriteLine("test1");
            System.Threading.Thread.Sleep(1000);
        }

        static void test2()
        {
            try
            {
                Console.WriteLine("test2");
                throw new ApplicationException("fejl");
            }
            catch (Exception ex)
            {
                // mangler log
               
            

            }
        }
    }
}

