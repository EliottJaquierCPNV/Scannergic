using NUnit.Framework;
using ScannergicMobile.Models;
using ScannergicMobile.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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
        public async Task GetAllAllergens_NominalCase_PassAsync()
        {
            //Given
            List<Allergen> allergensReturned;

            //When
            allergensReturned = await api.GetAllAllergensAsync();

            //Then
            Assert.IsTrue(allergensReturned != null);
        }
    }
}
