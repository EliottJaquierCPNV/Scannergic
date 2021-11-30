using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ScannergicMobile.Models;
namespace TestScannergicMobile
{
    public class TestAllergic
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Allergens_NominalCase_Pass()
        {
            //given
            Allergic allergic = new Allergic();
            List<Allergen> actualAllergens;

            //when
            actualAllergens = allergic.Allergens;

            //then
            Assert.IsTrue(actualAllergens != null);
        }

        [Test]
        public void AddAllergens_NominalCase_Pass()
        {
            //given
            Allergic allergic = new Allergic();
            Allergen actualAllergens = new Allergen(1,"Arachides");
            Allergen expectedAllergens;

            //when
            allergic.AddAllergen(actualAllergens);
            expectedAllergens = allergic.Allergens[0];

            //then
            Assert.AreEqual(actualAllergens,expectedAllergens);
        }

        [Test]
        public void AddAllergens_DuplicateValue_Pass()
        {
            //given
            Allergic allergic = new Allergic();
            Allergen allergen = new Allergen(1, "Arachides");
            List<Allergen> actualList;
            allergic.AddAllergen(allergen);

            //when
            allergic.AddAllergen(allergen);
            actualList = allergic.Allergens;

            //then
            Assert.IsTrue(actualList.Count == 1);
        }

        [Test]
        public void RemoveAllergens_NominalCase_Pass()
        {
            //given
            Allergic allergic = new Allergic();
            Allergen allergen = new Allergen(1, "Arachides");
            List<Allergen> actualList;
            allergic.AddAllergen(allergen);

            //when
            allergic.RemoveAllergen(allergen);
            actualList = allergic.Allergens;

            //then
            Assert.IsTrue(actualList.Count == 0);
        }
    }
}
