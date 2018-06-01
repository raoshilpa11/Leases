using System;

namespace WebApp.Models
{
    public class SaleBoard
    {
        public string BoardSize { get; set; }
        public string Location { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
    }
}