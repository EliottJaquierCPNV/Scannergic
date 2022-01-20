using NUnit.Framework;
using ScannergicMobile.Models;
using ScannergicMobile.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestScannergicMobile
{
    /// <summary>
    /// The the ApiRequest class
    /// </summary>
    public class TestApiRequest
    {
        ApiRequest api;
        [SetUp]
        public void Setup()
        {
            api = new ApiRequest();
        }

        /// <summary>
        /// Test getting all allergens 
        /// </summary>
        /// <returns>The async task (waiting to the web API time)</returns>
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
        /// <summary>
        /// Finding allergens in a product (founded)
        /// </summary>
        /// <returns>The async task (waiting to the web API time)</returns>
        [Test]
        public async Task GetAllergensInProduct_ProductFound_PassAsync()
        {
            //Given
            List<Allergen> allergensReturned;

            //When
            allergensReturned = await api.GetAllergensInProduct("7612345978901");

            //Then
            Assert.IsTrue(allergensReturned != null);
        }
        /// <summary>
        /// Finding allergens in a product (product not found)
        /// </summary>
        [Test]
        public void GetAllergensInProduct_ProductNotFound_Pass()
        {
            //When + Then
            Assert.ThrowsAsync<ResourceNotFoundException>(() => api.GetAllergensInProduct("7612345978901"));
        }
    }
}
