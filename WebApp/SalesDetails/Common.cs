using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models;

public class Common
{
    enum States { VIC, NSW, TAS, WA, NT };

    public static List<SalesPrice> ListOfPrices()
    {
        List<SalesPrice> salesPrice = new List<SalesPrice>();

        salesPrice.Add(new SalesPrice() { BoardSize = "Small", Location = "VIC", Price = 20 });
        salesPrice.Add(new SalesPrice() { BoardSize = "Large", Location = "VIC", Price = 30 });
        salesPrice.Add(new SalesPrice() { BoardSize = "Small", Location = "NSW", Price = 50 });
        salesPrice.Add(new SalesPrice() { BoardSize = "Large", Location = "NSW", Price = 60 });
        salesPrice.Add(new SalesPrice() { BoardSize = "Small", Location = "TAS", Price = 15 });
        salesPrice.Add(new SalesPrice() { BoardSize = "Large", Location = "TAS", Price = 20 });
        salesPrice.Add(new SalesPrice() { BoardSize = "Small", Location = "WA", Price = 20 });
        salesPrice.Add(new SalesPrice() { BoardSize = "Large", Location = "WA", Price = 30 });
        salesPrice.Add(new SalesPrice() { BoardSize = "Small", Location = "NT", Price = 20 });
        salesPrice.Add(new SalesPrice() { BoardSize = "Large", Location = "NT", Price = 30 });

        return salesPrice;
    }


    public static int CalculatePrice(string boardSize, string location)
    {
        List<SalesPrice> salesPrice = Common.ListOfPrices();
        int dateDiff = 10;

        var price = salesPrice.Where(x => x.BoardSize.Equals(boardSize) && x.Location.Equals(location)).Select(m => m.Price).FirstOrDefault();

        if (dateDiff >= 10)
        {
            if (location.Equals("NSW") && boardSize.Equals("Large"))
            {
                price = price - (15 * price) / 100;
            }
            else
            {
                price = price - (10 * price) / 100;
            }
        }

        return price;
    }

}
