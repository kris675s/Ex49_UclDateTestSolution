using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DateClassLibrary;

namespace DateUnitTestProject
{
    [TestClass]
    public class UnitTestDate
    /*
     * test types
     * 
     * arrange
     * act
     * assert
     * 
     * to types of deffenitions
     * 
     */
    {
        UclDate TestDate;
        [TestInitialize]
        public void TestInitalize()
        {
            TestDate = new UclDate(2019, 2, 6);
        }
        [TestMethod]
        public void TestMethod_DateConstructor()
        {
            UclDate aDate = new UclDate(2019, 2, 6);
            Assert.IsNotNull(aDate, "UclDate Constructor is not working");
        }
        [TestMethod]
        public void TestMethod_GetDay()
        {
            int day = TestDate.GetDay();
            Assert.AreEqual("6", day);
        }

    }
}
