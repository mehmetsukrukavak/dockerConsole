using System;

namespace ConsoleDocker
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            while (i < 10000)
            {

                Console.WriteLine("Hello World! " + i);
                i++;
               System.Threading.Thread.Sleep(1000);
            }
        }
    }
}

