using System;

public class DisplayInventoryThreshold
{
	public DisplayInventoryThreshold()
	{
	}

    public void ProcessRequests()
    {
        bool validInput = false;

        while (!validInput)
        {
            Console.Clear();
            Console.WriteLine("Inventory\n\n");
            Console.Write("Enter Threshold: ");
            try
            { 
                int threshold = int.Parse(Console.ReadLine());
                Console.WriteLine("You entered: {0}", threshold);
                validInput = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("invalid input");
                continue;
                //return InvalidInputFormat;
            }
            //validInput = true;
        }
        // Add logic here
        //Console.WriteLine("Enter Request to process");
        Console.ReadLine();
    }
}
