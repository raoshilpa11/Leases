using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(SaleBoardModel sales)
        {
            string boardSize = sales.BoardSize;
            string location = sales.Location;
            DateTime dateFrom = sales.DateFrom;
            DateTime dateTo = sales.DateTo;


            sales.Price = Common.CalculatePrice(boardSize, location);

            return View(sales);
        }
    }
}