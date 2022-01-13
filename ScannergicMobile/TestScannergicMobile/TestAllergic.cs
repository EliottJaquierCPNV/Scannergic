using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ScannergicMobile.Models;
namespace TestScannergicMobile
{
    public class TestAllergic
    {
        Allergic allergic;
        [SetUp]
        public void Setup()
        {
            allergic = new Allergic();
        }

        [Test]
        public void Allergens_NominalCase_Pass()
        {
            //given
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
            Allergen allergen = new Allergen(1, "Arachides");
            List<Allergen> actualList;
            allergic.AddAllergen(allergen);

            //when
            allergic.RemoveAllergen(allergen);
            actualList = allergic.Allergens;

            //then
            Assert.IsTrue(actualList.Count == 0);
        }

        [Test]
        public void FindProblematicAllergens_FoundProblematicAllergen_Pass()
        {
            //given
            Allergen arachides = new Allergen(1, "Arachides");
            Allergen gluten = new Allergen(2, "Gluten");
            allergic.AddAllergen(arachides);
            allergic.AddAllergen(gluten);
            List<Allergen> productAllergens = new List<Allergen>() { arachides };
            List<Allergen> expectedProblematicAllergens = new List<Allergen>() { arachides };
            List<Allergen> actualProblematicAllergens;

            //when
            actualProblematicAllergens = allergic.FindProblematicAllergens(productAllergens);

            //then
            Assert.AreEqual(expectedProblematicAllergens, actualProblematicAllergens);
        }

        [Test]
        public void FindProblematicAllergens_FoundProblematicAllergens_Pass()
        {
            //given
            Allergen arachides = new Allergen(1, "Arachides");
            Allergen gluten = new Allergen(2, "Gluten");
            allergic.AddAllergen(arachides);
            allergic.AddAllergen(gluten);
            List<Allergen> productAllergens = new List<Allergen>() { arachides, gluten };
            List<Allergen> expectedProblematicAllergens = new List<Allergen>() { arachides, gluten };
            List<Allergen> actualProblematicAllergens;

            //when
            actualProblematicAllergens = allergic.FindProblematicAllergens(productAllergens);

            //then
            Assert.AreEqual(expectedProblematicAllergens, actualProblematicAllergens);
        }

        [Test]
        public void FindProblematicAllergens_NoProblematicAllergens_Pass()
        {
            //given
            Allergen arachides = new Allergen(1, "Arachides");
            Allergen gluten = new Allergen(2, "Gluten");
            Allergen oeufs = new Allergen(3, "Oeufs");
            allergic.AddAllergen(arachides);
            List<Allergen> productAllergens = new List<Allergen>() { gluten, oeufs };
            List<Allergen> expectedProblematicAllergens = new List<Allergen>() {};
            List<Allergen> actualProblematicAllergens;

            //when
            actualProblematicAllergens = allergic.FindProblematicAllergens(productAllergens);

            //then
            Assert.AreEqual(expectedProblematicAllergens, actualProblematicAllergens);
        }
    }
}
