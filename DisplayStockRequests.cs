using System;

public class DisplayStockRequests
{
	public DisplayStockRequests()
	{
	}

    public void ProcessRequests()
    {
        Console.Clear();
        Console.WriteLine("Stock Requests\n\n");
        Console.WriteLine("ID\tStore\tProduct\tQuantity\tCurrent Stock\tStock Availability");
        Console.WriteLine("------------------------------------------------------------------");
        // insert display logic
        Console.Write("\n\nEnter Request to process: ");
        Console.ReadLine();
    }
}
