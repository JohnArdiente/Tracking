using Microsoft.AspNetCore.Mvc;

namespace fms.Controllers
{
    public class ShipmentController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}
