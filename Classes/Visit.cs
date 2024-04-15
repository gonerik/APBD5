using System.Runtime.InteropServices.JavaScript;

namespace API5_1.Classes;

public class Visit
{
    public Visit(string date, string descroption, double price)
    {
        Date = date;
        Descroption = descroption;
        Price = price;
    }

    public string Date { get; set; }
    public string Descroption { get; set; }
    public double Price { get; set; }
    
}