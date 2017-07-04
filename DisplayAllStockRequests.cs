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

        /* Exit if StockRequest is null, 
        an error occured reading the file*/
        if (sr == null)
        {
            PrintReadError();
            return;
        }

        while (!done)
        {
            PrintHeader();
            PrintItems();

            done = GetItem();
        }
    }

    public void ProcessFilteredRequests()
    {
        bool filter;
        bool done = false;

        /* Exit if StockRequest is null, 
        an error occured reading the file*/
        if (sr == null)
        {
            PrintReadError();
            return;
        }

        //Console.WriteLine("Enter filter: True or False");
        filter = ValidateFilter();

        while (!done)
        {
            PrintHeader();
            PrintFilterItems(filter);

            done = GetItem();
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
        foreach (var item in sr)
        {
            string itemLine = $"{item.Id,-5}{item.Store,-15}{item.Product,-20}{item.Quantity,-25}{item.CurrentStock,-25}{item.StockAvailability,-15}";
            Console.WriteLine(itemLine);
        }
    }

    public void PrintFilterItems(bool filter)
    {
        foreach (var item in sr)
        {
            if (item.StockAvailability == filter)
            {
                string itemLine = $"{item.Id,-5}{item.Store,-15}{item.Product,-20}{item.Quantity,-25}{item.CurrentStock,-25}{item.StockAvailability,-15}";
                Console.WriteLine(itemLine);
            }
        }
    }

    /* Gets item input
       Processes if valid item
       returns true if wmpty string entered */
    public bool GetItem()
    {
        Console.Write("\n\nEnter Request to process: ");
        string input = Console.ReadLine();

        // pressing enter (empty string) returns to previous menu
        if (input.Equals("")) { return true; }
        try
        {
            int option = Int32.Parse(input);
            //if (option == 0) { done = true;  }

            // process items here
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format\npress enter to continue");
            Console.ReadLine();
        }
        return false;
    }

    public void PrintReadError()
    {
        Console.Clear();
        Console.WriteLine("An Error occured reading the stock request file:");
        Console.WriteLine("Press any key to return to the previous menu");
        Console.ReadLine();
    }

    public bool ValidateFilter()
    {
        string input;
        while (true)
        { 
            Console.Clear();
            Console.WriteLine("Enter filter: True or False");
            input = Console.ReadLine();
 
            switch (input)
            {
                case "TRUE":
                    return true;
                    break;
                case "T":
                    return true;
                    break;
                case "True":
                    return true;
                    break;
                case "true":
                    return true;
                    break;
                case "FALSE":
                    return false;
                    break;
                case "F":
                    return false;
                    break;
                case "False":
                    return false;
                    break;
                case "false":
                    return false;
                    break;
                default:
                    Console.WriteLine("Invalid input: please retry\nPress any key to continue");
                    Console.ReadLine();
                    break;
            }
        }

        //return true;
    }
}
