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
        public ActionResult Index(SaleBoard sales)
        {
            sales = Lease.CalculatePrice(sales);

            return View(sales);
        }
    }
}