using Microsoft.AspNetCore.Mvc;
using WebProject1.Data;
using WebProject1.Services;

namespace WebProject1.Controllers
{
    public class SellersController : Controller
    {

        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService) 
        {
           _sellerService = sellerService;
        }


        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }
    }
}
