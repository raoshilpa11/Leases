using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using WebApp.Models;
using static Common;

public class Lease
{
    public static SaleBoard CalculatePrice(SaleBoard sales)
    {
        int price = 0;
       // int discount = 0;
        List<SalesPrice> salesPrice = PriceList.ListOfPrices();

        DateTime dateFrom = Convert.ToDateTime(sales.DateFrom.Date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)).Date;
        DateTime dateTo = Convert.ToDateTime(sales.DateTo.Date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)).Date;

        int dateDiff = Math.Abs((dateTo - dateFrom).Days);
        //TimeSpan dateDiff = dateTo - dateFrom;
        //TimeSpan dateDiff = dateFrom.Subtract(dateTo);
        var totalDays = Math.Abs(dateDiff) + 1;

        price = salesPrice.Where(x => x.BoardSize.Equals(sales.BoardSize) && x.Location.Equals(sales.Location)).Select(m => m.Price).FirstOrDefault();

        if (totalDays >= 10)
        {
            if (sales.Location.Equals(States.NSW) && sales.BoardSize.Equals(BoardSize.Large))
            {
                //discount = (15 * price) / 100;
                sales.Price = (price - ((15 * price) / 100)) * totalDays;
                sales.Discount = 15;
            }
            else
            {
                //discount = (10 * price) / 100;
                sales.Price = (price - ((10 * price) / 100)) * totalDays;
                sales.Discount = 10;
            }
        }
        else
        {
            sales.Price = price * totalDays;
            sales.Discount = 0;
        }

        return sales;
    }   
}