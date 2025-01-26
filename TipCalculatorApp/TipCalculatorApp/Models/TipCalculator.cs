using System.ComponentModel.DataAnnotations;

namespace TipCalculatorApp.Models
{
    // Represents the model for calculating tips based on the meal cost
    public class TipCalculator
    {
        [Required(ErrorMessage = "The cost of the meal is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "The cost of the meal must be greater than 0.")]
        public decimal MealCost { get; set; }

        // Calculates the 15% tip based on the meal cost
        public decimal Tip15 => MealCost * 0.15M;

        // Calculates the 15% tip based on the meal cost
        public decimal Tip20 => MealCost * 0.20M;

        // Calculates the 25% tip based on the meal cost
        public decimal Tip25 => MealCost * 0.25M;
    }
}
