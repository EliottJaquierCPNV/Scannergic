using System;
using System.Collections.Generic;
using System.Text;
using ScannergicMobile.Models;
using NUnit.Framework;
namespace TestScannergicMobile
{
    public class TestAppManager
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Me_NominalCase_Pass()
        {
            //given
            Allergic actualResult;
            AppManager.Init();

            //when
            actualResult = AppManager.Me;

            //then
            Assert.IsTrue(actualResult != null);
        }
    }
}
