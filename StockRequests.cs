using System;

public class StockRequest
{
    public int Id { get; set; }
    public string Store { get; set; }
    public string Product { get; set; }
    public int Quantity { get; set; }
    public int CurrentStock { get; set; }
    public bool StockAvailability { get; set; }

    public StockRequest()
	{
	}


}
