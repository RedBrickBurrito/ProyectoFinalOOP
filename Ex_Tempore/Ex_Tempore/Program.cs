using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_Tempore.Control;

namespace Ex_Tempore
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isReady = false;
            MasterControl play = new MasterControl();

            Console.WriteLine("--------------------------------------------EX TEMPORE------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------presiona enter para jugar-----------------------------------");
            do
            {
                while (!Console.KeyAvailable)
                {
                    isReady = true;
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
            if(isReady == true)
            {
                play.play();
            }
 

        }
    }
}
