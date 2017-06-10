using System;

public class MainMenu : Menu
{
    const int itemCount = 4;

    public override void PrintMenu()
    {
        //throw new NotImplementedException();
        Console.WriteLine("Welcome to Marvellous Magic");
        Console.WriteLine("======================================\n");
        Console.WriteLine("      1.    Owner\n");
        Console.WriteLine("      2.    Franchise Owner\n");
        Console.WriteLine("      3.    Customer\n");
        Console.WriteLine("      4.    Quit\n");
        Console.WriteLine("Enter an option:");
    }

    /*public void PrintMenu()
	{

        //Console.Clear();
        Console.WriteLine("Welcome to Marvellous Magic");
        Console.WriteLine("======================================\n");
        Console.WriteLine("      1.    Owner\n");
        Console.WriteLine("      2.    Franchise Owner\n");
        Console.WriteLine("      3.    Customer\n");
        Console.WriteLine("      4.    Quit\n");
        Console.WriteLine("Enter an option:");
    }*/

    /* ensures input is valid and within bounds
        before returning */
    /*public int GetInput()
    {
        int input = 0; // set to value which allows atleast 1 iteration

        while (input < 1 || input > itemCount)
        {

            PrintMenu();
            input = int.Parse(Console.ReadLine());
            
        }

        return input;
    }*/
}
