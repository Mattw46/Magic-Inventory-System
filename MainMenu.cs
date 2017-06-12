using System;

public class MainMenu : Screen
{
    //const int InvalidInputFormat = -1;
    int maxItems;

    public MainMenu()
    {
        maxItems = 4;
    }

    public override int GetMenuItem()
    {
        return GetMenuInput(maxItems);
    }

    /*public int GetMenuItem()
    {
        bool valid = false;
        int input = 0;
        string errorString = "";

        while (!valid)
        {
            // print menu
            PrintMenu();
            if (errorString.Length > 0) { Console.WriteLine(errorString); }

            // get valid input
            input = GetMenuInput();

            if (input >= 1 && input <= maxItems) 
            {
                valid = true;
            }
            else if (input == InvalidInputFormat)
            {
                errorString = "\nInvalid input, only numbers allowed\nEnter an option:";
            }
            else
            {
                errorString = "Invalid numuber try again";
            }
        }

        return input;
    }*/

    protected override void PrintMenu() // consider calling abstract method of create interface
    {
        Console.WriteLine("Welcome to Marvellous Magic");
        Console.WriteLine("======================================\n");
        Console.WriteLine("      1.    Owner\n");
        Console.WriteLine("      2.    Franchise Owner\n");
        Console.WriteLine("      3.    Customer\n");
        Console.WriteLine("      4.    Quit\n");
        Console.WriteLine("Enter an option:");
    }

    /*private int GetMenuInput()
    {
        int number = 0;

        try
        {
            number = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("invalid input");
            return InvalidInputFormat;
        }
        return number;
    }*/
}
