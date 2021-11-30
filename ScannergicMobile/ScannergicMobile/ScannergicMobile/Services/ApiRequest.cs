using ScannergicMobile.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScannergicMobile.Services
{
    /// <summary>
    /// This class manage and make calls to the API 
    /// </summary>
    public class ApiRequest
    {
        /// <summary>
        /// The principal server URL where the api is.
        /// </summary>
        public const string SERVER_URL = "";

        /// <summary>
        /// Get the list of all Allergens 
        /// </summary>
        /// <returns>The list of all allergens</returns>
        public List<Allergen> GetAllAllergens()
        {
            List<Allergen> allergens = new List<Allergen>(0);
            allergens.Add(new Allergen(1, "Arachides"));
            allergens.Add(new Allergen(2, "Gluten"));
            allergens.Add(new Allergen(3, "Oeufs"));
            return allergens;
        }
    }
}
