using System;

public abstract class Menu
{
    public abstract void PrintMenu();

    public int GetInput()
    {
        bool valid = false;
        int input = 0;

        PrintMenu();

        while (!valid)
        {
            try
            {
                input = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input: You entered a invalid character.\n" +
                                    "press any key to continue");
                Console.ReadLine();
                Console.Clear();
                PrintMenu();
                input = int.Parse(Console.ReadLine());
            }

            if (input >= 1 && input <= 4) // replace 4 with variable to swap out values
            {
                valid = true;
            }
            else
            {
                Console.Clear();
                PrintMenu();
                Console.WriteLine("Invalid option try again");
            }
        }
        return input;
    }
}
