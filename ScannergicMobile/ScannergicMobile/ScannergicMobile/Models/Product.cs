using System;
using System.Collections.Generic;
using System.Text;

namespace ScannergicMobile.Models
{
    /// <summary>
    /// A product is a food containing allergens
    /// </summary>
    public class Product
    {
        private List<Allergen> allergens;

        /// <summary>
        /// Allergens in the Product
        /// </summary>
        public List<Allergen> Allergens
        {
            get { return allergens; }
        }

        /// <summary>
        /// Instantiate a new Product
        /// </summary>
        /// <param name="allergens">A product require allergens</param>
        public Product(List<Allergen> allergens)
        {
            this.allergens = allergens;
        }
    }
}
