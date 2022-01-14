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
        [Test]
        public async Task GetAllergensInProduct_ProductFound_PassAsync()
        {
            //Given
            List<Allergen> allergensReturned;

            //When
            allergensReturned = await api.GetAllergensInProduct("7612345978900");

            //Then
            Assert.IsTrue(allergensReturned != null);
        }
        [Test]
        public void GetAllergensInProduct_ProductNotFound_Pass()
        {
            //When + Then
            Assert.ThrowsAsync<ResourceNotFoundException>(() => api.GetAllergensInProduct("7612345978901"));
        }
    }
}
