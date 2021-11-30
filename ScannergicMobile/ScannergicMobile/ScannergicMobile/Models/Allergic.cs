using System;
using System.Collections.Generic;
using System.Text;

namespace ScannergicMobile.Models
{
    /// <summary>
    /// An Allergic is a Person who has allergies
    /// </summary>
    public class Allergic
    {
        private List<Allergen> allergens;

        /// <summary>
        /// Instanciate Allergic
        /// </summary>
        public Allergic()
        {
            allergens = new List<Allergen>();
        }

        /// <summary>
        /// Get the problematic Allergen
        /// </summary>
        public List<Allergen> Allergens
        {
            get { return allergens; }
        }

        /// <summary>
        /// Add an Allergen (which is not a duplicate)
        /// </summary>
        /// <param name="allergen">The Allergen to add</param>
        public void AddAllergen(Allergen allergen)//N'autorise pas les doublons
        {
            if(!isAllergenInList(allergen.Id))
                allergens.Add(allergen);
        }

        /// <summary>
        /// Remove an Allergen
        /// </summary>
        /// <param name="allergen">The Allergen to delete</param>
        public void RemoveAllergen(Allergen allergen)
        {
            allergens.Remove(allergen);
        }

        /// <summary>
        /// Get the problematic list of Allergen
        /// </summary>
        /// <param name="product">Return the list of problematic Allergen</param>
        /// <returns></returns>
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

        /// <summary>
        /// Is an allergen already in list ?
        /// </summary>
        /// <param name="allergenID">Allergen ID</param>
        /// <returns>Bool of the result</returns>
        private bool isAllergenInList(int allergenID)
        {
            foreach (var item in allergens)
            {
                if (item.Id == allergenID)
                    return true;
            }
            return false;
        }
    }
}