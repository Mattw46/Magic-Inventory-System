using System;

public class MainMenu : IScreen
{
    /*public Class1()
	{
	}*/

    public int RunScreen()
    {
        PrintScreen();
        return GetInput();
    }

    public void PrintScreen()
    {
        Console.WriteLine("Welcome to Marvellous Magic");
        Console.WriteLine("======================================\n");
        Console.WriteLine("      1.    Owner\n");
        Console.WriteLine("      2.    Franchise Owner\n");
        Console.WriteLine("      3.    Customer\n");
        Console.WriteLine("      4.    Quit\n");
        Console.WriteLine("Enter an option:");
    }

    public int GetInput()
    {
        Console.ReadLine();
        return 4;
    }
}
