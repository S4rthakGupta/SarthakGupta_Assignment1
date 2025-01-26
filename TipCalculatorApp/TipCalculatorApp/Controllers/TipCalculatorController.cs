using Microsoft.AspNetCore.Mvc;
using TipCalculatorApp.Models;

namespace TipCalculatorApp.Controllers
{
    // Controller to handle Tip Calculator functionality
    public class TipCalculatorController : Controller
    {
        // Handles GET requests for the Tip Calculator page
        public IActionResult Index()
        {
            // Initialize the model with default values (e.g., MealCost = 0)
            var model = new TipCalculator
            {
                MealCost = 0
            };
            return View(model);
        }

        // Handles POST requests for calculating tips
        [HttpPost]
        public IActionResult Index(TipCalculator model)
        {
            if (ModelState.IsValid)
            {
                // If the model is valid, process and calculate tips
                return View(model);
            }

            // If the input is invalid, reset MealCost to 0 and show $0.00 for tips
            model.MealCost = 0;
            return View(model);
        }

        // Clears the form by redirecting to the Index action
        public IActionResult Clear()
        {
            // Redirect the user to the Index action to reset the form and model
            return RedirectToAction("Index");
        }
    }
}
