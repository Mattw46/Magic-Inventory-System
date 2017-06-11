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
        Console.WriteLine("Place holder text");
    }

    public int GetInput()
    {
        return 4;
    }
}
