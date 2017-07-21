using eManager.Domain;
using System.Web.Mvc;

namespace IdentitySample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDepartmentDataSource _db;

        public HomeController(IDepartmentDataSource db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            var departments = _db.Departments;
            return View(departments);
        }

        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
