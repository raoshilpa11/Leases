using System;

namespace WebApp.Models
{
    public class SaleBoardModel
    {
        public string BoardSize { get; set; }
        public string Location { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }
    }
}