using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Megaengine
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            //max (120,30)
           Window window = new Window(20,30);
            window.Build(ConsoleColor.Red);
            window.MiddleText();
            Console.ReadLine();
        }
    }
}
