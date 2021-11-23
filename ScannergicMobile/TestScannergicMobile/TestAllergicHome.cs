using NUnit.Framework;
using ScannergicMobile;
using ScannergicMobile.ViewModels;

namespace TestScannergicMobile
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Title_NominalCase_Success()
        {
            //GIVEN
            AllergicHome home = new AllergicHome();
            string expectedTitle = "Title changed!";
            string actualTitle;
            home.Title = expectedTitle;

            //WHEN
            actualTitle = home.Title;

            //THEN
            Assert.AreEqual(expectedTitle, actualTitle);
        }
    }
}