using System;
using System.Collections.Generic;
using System.Text;
using ScannergicMobile.Models;
using NUnit.Framework;
namespace TestScannergicMobile
{
    /// <summary>
    /// Intgration testing (Global app manager, app lifetime)
    /// </summary>
    public class TestAppManager
    {
        [SetUp]
        public void Setup()
        {
            
        }
        /// <summary>
        /// Getting the default Allergic
        /// </summary>
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
