using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

public class StockRequestReader
{
	/*public Class1()
	{
	}*/
    public string ReadFile()
    {
        var file = File.ReadAllText("stockrequests.json");
        return file;
    }

    public List<StockRequest> GetStockRequests()
    {
        List<StockRequest> requests;
        var input = ReadFile();
        try
        {
            requests = JsonConvert.DeserializeObject<List<StockRequest>>(input);
        }
        catch(Newtonsoft.Json.JsonSerializationException)
        {
            Console.WriteLine("An error occured reading the file");
            requests = null;
        }
        return requests;
    }
}
