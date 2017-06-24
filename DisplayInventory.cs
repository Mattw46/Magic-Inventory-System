using System;

public class DisplayInventory
{
	public DisplayInventory()
	{
	}

    public void ProcessRequests()
    {
        Console.Clear();
        Console.WriteLine("Inventory\n\n");
        Console.WriteLine("ID\tProduct\tCurrent Stock\tRe-Stock");
        Console.WriteLine("-------------------------------------------------------");
        // Add logic here
        Console.WriteLine("Enter Request to process");
        Console.ReadLine();
    }
}
