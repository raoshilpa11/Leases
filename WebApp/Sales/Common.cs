using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Common
{
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
}
