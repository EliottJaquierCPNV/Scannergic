using NUnit.Framework;
using ScannergicMobile.Models;
using ScannergicMobile.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestScannergicMobile
{
    public class TestApiRequest
    {
        ApiRequest api;
        [SetUp]
        public void Setup()
        {
            api = new ApiRequest();
        }

        [Test]
        public void GetAllAllergens_NominalCase_Pass()
        {
            //Given
            List<Allergen> allergensReturned;

            //When
            allergensReturned = api.GetAllAllergens();

            //Then
            Assert.IsTrue(allergensReturned != null);
        }
    }
}
