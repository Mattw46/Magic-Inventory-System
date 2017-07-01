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
            bool exit = false; 

            /* While current menu running and last called menu 
               not return true for exit */
            while (running && !exit)
            {
                MainMenu main = new MainMenu();
                //main.PrintMenu();
                int input = main.GetMenuItem();

                switch (input)
                {
                    case 1:
                        Console.WriteLine("Calling Owner menu");
                        OwnerMenuDriver omd = new OwnerMenuDriver();
                        exit = omd.RunMenu();
                        break;
                    case 2:
                        Console.WriteLine("Calling Franchise menu");
                        FranchiseMenuDriver fmd = new FranchiseMenuDriver();
                        exit = fmd.RunMenu();
                        break;
                    case 3:
                        Console.WriteLine("Calling Customer menu");
                        CustomerMenuDriver cmd = new CustomerMenuDriver();
                        exit = cmd.RunMenu();
                        break;
                    case 4:
                        // set running to exit
                        running = false;
                        break;
                }
            }
        }
    }
}
