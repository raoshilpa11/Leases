using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class SaleBoardModel
    {
        public string BoardSize { get; set; }
        public string Location { get; set; }
        public DateTime DateFrom { get; set; }    
        public DateTime DateTo { get; set; }
        public int Price { get; set; }
    }
}