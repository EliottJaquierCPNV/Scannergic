using System;
using System.Collections.Generic;
using System.Text;

namespace ScannergicMobile.Models
{
    public class Product
    {
        private List<Allergen> allergens;

        public List<Allergen> Allergens
        {
            get { return allergens; }
        }

        public Product(List<Allergen> allergens)
        {
            this.allergens = allergens;
        }
    }
}
