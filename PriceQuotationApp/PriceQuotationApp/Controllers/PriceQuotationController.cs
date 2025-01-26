using Microsoft.AspNetCore.Mvc;
using PriceQuotationApp.Models;

namespace PriceQuotationApp.Controllers
{
    public class PriceQuotationController : Controller
    {
        // Handles the GET request for the Index page
        public IActionResult Index()
        {
            // Create a new instance of the PriceQuotation model with default values
            var model = new PriceQuotation
            {
                // Default subtotal and discount percent value
                Subtotal = 0,
                DiscountPercent = 0
            };
            return View(model);
        }


        // Handles the POST request for the Index page
        [HttpPost]
        public IActionResult Index(PriceQuotation model)
        {
            if (ModelState.IsValid)
            {
                // If the form input is valid, process and display the results
                return View(model);
            }
            else
            {
                // If the form input is invalid, return the view with validation errors
                return View(model);
            }
        }

        // Clears the form data by redirecting to the Index action
        public IActionResult Clear()
        {
            // Redirect the user to the Index page, effectively resetting the form
            return RedirectToAction("Index");
        }
    }
}
