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
            // current menu updated by main menu 
            bool running = true;
            // returned from selected menu, 
            //true returned if exit selected from called menu
            bool exit = false; 
            
            while (running && !exit)
            {
                MainMenu main = new MainMenu();
                //main.PrintMenu();
                int input = main.GetMenuItem();

                switch (input)
                {
                    case 1:
                        // call something
                        Console.WriteLine("Calling Owner menu");
                        OwnerMenuDriver omd = new OwnerMenuDriver();
                        exit = omd.RunMenu();
                        break;
                    case 2:
                        // call something
                        Console.WriteLine("Calling Franchise menu");
                        FranchiseMenuDriver fmd = new FranchiseMenuDriver();
                        exit = fmd.RunMenu();
                        break;
                    case 3:
                        // call something
                        Console.WriteLine("Calling Customer menu");
                        CustomerMenuDriver cmd = new CustomerMenuDriver();
                        exit = cmd.RunMenu();
                        break;
                    case 4:
                        running = false;
                        break;
                }
            }
        }
    }
}
