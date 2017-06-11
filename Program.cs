using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicInventory
{
    /* Driver class*/
    public class Program
    {
        public static void Main(string[] args)
        {
            bool running = true;
            
            while (running)
            {
                MainMenu main = new MainMenu();
                //main.PrintMenu();
                int input = main.RunScreen();

                switch (input)
                {
                    case 1:
                        // call something
                        Console.WriteLine("Calling Owner menu");
                        break;
                    case 2:
                        // call something
                        Console.WriteLine("Calling Franchise menu");
                        break;
                    case 3:
                        // call something
                        Console.WriteLine("Calling Customer menu");
                        break;
                    case 4:
                        running = false;
                        break;
                }
            }
        }
    }
}
