using Microsoft.AspNetCore.Mvc;
using CustomerApplication.Models;
namespace CustomerApplication.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult OrderEntry()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CalculateDiscount(ProductModel model)
        {
            if (!ModelState.IsValid)
            {
                return NoContent();
            }
            
            if (model.OrderAmount >= 100)
            {
                model.DiscountPercent = 10;
                model.DiscountAmount = (model.OrderAmount * model.DiscountPercent / 100);
                model.Total = model.OrderAmount - model.DiscountAmount;
        
            }
            return View("ProductView", model);


        }
        public IActionResult ProductView(ProductModel model)
        {
            return View(model);
        }

    }
}
