using System;

public class NewMainMenu
{
    const int InvalidInputFormat = -1;
    const int maxItems = 4;

	public NewMainMenu()
	{
	}

    public int GetMenuItem()
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

            if (input >= 1 && input <= maxItems) //4 is max number
            {
                valid = true;
            }
            else if (input == InvalidInputFormat)
            {
                errorString = "Invalid input, only numbers allowed";
            }
            else
            {
                //Console.Clear();
                errorString = "Invalid numuber try again";
                //Console.WriteLine("Invalid numuber try again \n\n");
            }
        }

        return input;
    }

    private void PrintMenu() // consider calling abstract method of create interface
    {
        Console.WriteLine("Welcome to Marvellous Magic");
        Console.WriteLine("======================================\n");
        Console.WriteLine("      1.    Owner\n");
        Console.WriteLine("      2.    Franchise Owner\n");
        Console.WriteLine("      3.    Customer\n");
        Console.WriteLine("      4.    Quit\n");
        Console.WriteLine("Enter an option:");
    }

    private int GetMenuInput()
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
    }
}
