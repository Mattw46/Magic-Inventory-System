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
                int input = main.GetInput();

                switch (input)
                {
                    case 1:
                        // call something
                        break;
                    case 2:
                        // call something
                        break;
                    case 3:
                        // call something
                        break;
                    case 4:
                        running = false;
                        break;
                }
            }
        }
    }
}
