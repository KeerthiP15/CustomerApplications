using System;
using Xunit;
using CustomerApplication.Controllers;
using CustomerApplication.Models;
using Microsoft.AspNetCore.Mvc;
namespace DiscountCalculationTests
{
    public class DiscountCalculatorTests
    {
        [Fact]
        public void CalculateDiscount_ValidInputs_ReturnsCorrectDiscount()
        {
            // Arrange
            var calculator = new ProductController();
    
            var product = new ProductModel { OrderAmount = 100 };
           
            var result = calculator.CalculateDiscount(product) as ViewResult;
            Assert.NotNull(result);  // Ensure it's not null

            var result1 = result.Model as ProductModel;
            Assert.NotNull(result1);  // Ensure model is not null

            decimal productPrice = Convert.ToDecimal(result1.Total);
            
            // Assert
            Assert.Equal(90, productPrice);
        }

       
        
    }
}
