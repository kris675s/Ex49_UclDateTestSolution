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
            Assert.AreEqual(6, day);
        }
        [TestMethod]
        public void TestMethod_GetWeek()
        {
            /*
             * implementation error in getweek
             * Message: Assert.AreEqual failed. Expected:<11>. Actual:<10>.
             */
            UclDate TestDate2 = new UclDate(2019, 2, 6);
            ushort week = TestDate2.GetWeek();
            Assert.AreEqual(6, week);
        }
        [TestMethod]
        public void TestMethod_GetMonth()
        {
            int month = TestDate.GetMonth();
            Assert.AreEqual(2, month);
        }
        [TestMethod]
        public void TestMethod_GetYear()
        {
            int year = TestDate.GetYear();
            Assert.AreEqual(2019, year);
        }
        [TestMethod]
        public void TestMethod_GetDatoStringDMY()
        {
            string dmy = TestDate.GetDatoStringDMY();
            Assert.AreEqual("6/2/2019", dmy);
        }
        [TestMethod]
        /*
         * syntax error
         * Message: Assert.AreEqual failed. Expected:<2019/2/6>. Actual:<2019-2-6>.
         */
        public void TestMethod_GetDatoStringYMD()
        {
            string ymd = TestDate.GetDatoStringYMD();
            Assert.AreEqual("2019/2/6", ymd);
        }
        [TestMethod]
        /*
         * syntax error 00-00-00 != 00/00/00
         * Message: Assert.AreEqual failed. Expected:<2019/02/06>. Actual:<9-02-06>. 
         */
        public void TestMethod_GetDatoStringYMMDD()
        {
            string ymmdd = TestDate.GetDatoStringYMMDD();
            Assert.AreEqual("2019/02/06", ymmdd);
        }
        [TestMethod]
        public void TestMethod_GetDatoStringYMMDDAlternativ()
        {
            string ymmddalt = TestDate.GetDatoStringYMMDDAlternativ();
            Assert.AreEqual("2019/06/02", ymmddalt);
        }
        [TestMethod]
        public void TestMethod_GetDatoStringYMMDDAlternativ2()
        {
            string ymmddalt = TestDate.GetDatoStringYMMDDAlternativ();
            Assert.AreEqual("2019-02-06", ymmddalt);
        }
    }
}

