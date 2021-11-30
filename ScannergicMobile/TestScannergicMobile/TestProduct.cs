using System;
using System.Collections.Generic;
using System.Text;
using ScannergicMobile.Models;
using NUnit.Framework;
namespace TestScannergicMobile
{
    public class TestProduct
    {
        List<Allergen> allergens;
        [SetUp]
        public void Setup()
        {
            allergens = new List<Allergen>(0);
            allergens.Add(new Allergen(1, "Arachides"));
            allergens.Add(new Allergen(2, "Gluten"));
        }

        [Test]
        public void Allergens_NominalCase_Pass()
        {
            //Given
            Product product = new Product(allergens);
            List<Allergen> expectedResult = allergens;
            List<Allergen> result;

            //When
            result = product.Allergens;

            //Then
            Assert.AreEqual(expectedResult,result);
        }
    }
}
