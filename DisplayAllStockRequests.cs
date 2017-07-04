using System;
using System.Collections.Generic;

public class DisplayAllStockRequests
{
    List<StockRequest> sr;

    public DisplayAllStockRequests()
	{
        StockRequestReader srr = new StockRequestReader();
        sr = srr.GetStockRequests();
	}

    public void ProcessRequests()
    {
        bool done = false;

        if (sr == null)
        {
            PrintReadError();
            return;
        }

        while (!done)
        {
            PrintHeader();
            foreach (var item in sr)
            {
                string itemLine = $"{item.Id,-5}{item.Store,-15}{item.Product,-20}{item.Quantity,-25}{item.CurrentStock,-25}{item.StockAvailability,-15}";
                Console.WriteLine(itemLine);
            }

            Console.Write("\n\nEnter Request to process: ");
            string input = Console.ReadLine();

            // pressing enter (empty string) returns to previous menu
            if (input.Equals("")) { return; } 
            try { 
                int option = Int32.Parse(input);
                if (option == 0) { done = true;  }
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid input format\npress enter to continue");
                Console.ReadLine();
            }
            // process item
        }
    }

    public void PrintHeader()
    {
        string header = $"{"ID",-5}{"Store",-15}{"Product",-20}{"Quantity",-25}{"Current Stock",-25}{"Stock Availability",-15}";
        Console.Clear();
        Console.WriteLine("Stock Requests\n\n");
        Console.WriteLine(header);
        Console.WriteLine(new string('=', header.Length));
    }

    public void PrintItems()
    {

    }

    public void PrintFilterItems()
    {

    }

    public void PrintReadError()
    {
        Console.Clear();
        Console.WriteLine("An Error occured reading the stock request file:");
        Console.WriteLine("Press any key to return to the previous menu");
        Console.ReadLine();
    }
}
