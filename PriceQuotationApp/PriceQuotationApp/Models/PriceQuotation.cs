﻿using System.ComponentModel.DataAnnotations;

namespace PriceQuotationApp.Models
{
    public class PriceQuotation
    {
        // The sales price of the product or service
        [Required(ErrorMessage = "The sales price is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a sale price")]
        public decimal Subtotal { get; set; }


        // The sales price of the product or service
        [Required(ErrorMessage = "The discount percent is required.")]
        [Range(0, 100, ErrorMessage = "Please enter a discount percent between 0 and 100.")]
            public decimal DiscountPercent { get; set; }

        // Calculates the discount amount based on the subtotal and discount percentage
        public decimal DiscountAmount => Subtotal * (DiscountPercent / 100);

        // Calculates the total price after applying the discount
        public decimal Total => Subtotal - DiscountAmount;
    }
}