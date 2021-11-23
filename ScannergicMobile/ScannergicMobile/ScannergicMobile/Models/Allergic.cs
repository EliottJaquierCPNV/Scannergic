using System;
using System.Collections.Generic;
using System.Text;

namespace ScannergicMobile.Models
{
    public class Allergic
    {
        private List<Allergen> allergens;

        public Allergic()
        {
            allergens = new List<Allergen>();
        }
        public List<Allergen> Allergens
        {
            get { return allergens; }
            set { allergens = value; }
        }

        public void AddAllergen(Allergen allergen)
        {
            allergens.Add(allergen);
        }

        public List<Allergen> FindProblematicAllergens(Product product)
        {
            List<Allergen> problematicAllergens = new List<Allergen>();
            foreach (Allergen allergen in product.Allergens)
            {
                foreach (Allergen problematicAllergen in allergens)
                {
                    if (problematicAllergen.Id == allergen.Id)
                        problematicAllergens.Add(allergen);
                }
            }
            return problematicAllergens;
        }
    }
}