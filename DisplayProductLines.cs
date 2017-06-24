using System;

public class DisplayProductLines
{
	public DisplayProductLines()
	{
	}

    public void ProcessRequests()
    {
        Console.Clear();
        Console.WriteLine("Inventory\n\n");
        Console.WriteLine("ID\tProduct\t\tCurrent Stock");
        Console.WriteLine("-------------               ---------------");
        // insert display logic
        //Console.Write("\n\nEnter Request to process: ");
        Console.ReadLine();
    }
}
