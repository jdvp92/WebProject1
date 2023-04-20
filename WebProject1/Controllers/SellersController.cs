using Microsoft.AspNetCore.Mvc;
using WebProject1.Data;

namespace WebProject1.Controllers
{
    public class SellersController : Controller
    {

        private readonly WebProject1Context _context;

        public SellersController(WebProject1Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
