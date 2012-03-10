using DarkSkySharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DarkSkySharp.Tests
{
    
    
    /// <summary>
    ///This is a test class for DarkSkyTest and is intended
    ///to contain all DarkSkyTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DarkSkyTest
    {
        //public static string sampleForecastData = '{"radarStation":"mux","hourPrecipitation":[{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331405371},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331405431},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331405491},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331405551},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331405611},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331405671},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331405731},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331405791},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331405851},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331405911},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331405971},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331406031},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331406091},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331406151},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331406211},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331406271},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331406331},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331406391},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331406451},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331406511},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331406571},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331406631},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331406691},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331406751},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331406811},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331406871},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331406931},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331406991},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331407051},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331407111},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331407171},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331407231},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331407291},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331407351},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331407411},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331407471},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331407531},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331407591},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331407651},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331407711},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331407771},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331407831},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331407891},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331407951},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331408011},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331408071},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331408131},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331408191},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331408251},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331408311},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331408371},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331408431},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331408491},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331408551},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331408611},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331408671},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331408731},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331408791},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331408851},{"probability":0,"intensity":0,"error":0,"type":"rain","time":1331408911}],"dayPrecipitation":[{"time":1331406000,"probability":0,"type":"rain"},{"time":1331409600,"probability":0,"type":"rain"},{"time":1331413200,"probability":0,"type":"rain"},{"time":1331416800,"probability":0,"type":"rain"},{"time":1331420400,"probability":0,"type":"rain"},{"time":1331424000,"probability":0,"type":"rain"},{"time":1331427600,"probability":0,"type":"rain"},{"time":1331431200,"probability":0,"type":"rain"},{"time":1331434800,"probability":0,"type":"rain"},{"time":1331438400,"probability":0,"type":"rain"},{"time":1331442000,"probability":0,"type":"rain"},{"time":1331445600,"probability":0,"type":"rain"},{"time":1331449200,"probability":0,"type":"rain"},{"time":1331452800,"probability":0,"type":"rain"},{"time":1331456400,"probability":0,"type":"rain"},{"time":1331460000,"probability":0,"type":"rain"},{"time":1331463600,"probability":0.02,"type":"rain"},{"time":1331467200,"probability":0.03,"type":"rain"},{"time":1331470800,"probability":0.06,"type":"rain"},{"time":1331474400,"probability":0.1,"type":"rain"},{"time":1331478000,"probability":0.13,"type":"rain"},{"time":1331481600,"probability":0.11,"type":"rain"},{"time":1331485200,"probability":0.08,"type":"rain"},{"time":1331488800,"probability":0.07,"type":"rain"},{"time":1331492400,"probability":0.06,"type":"rain"}],"currentSummary":"clear","hourSummary":"clear"}';




        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Forecast
        ///</summary>
        [TestMethod()]
        public void ForecastTest()
        {
            DarkSky darkSky = new DarkSky();
            Geolocation location = new Geolocation();
            //string expected = string.Empty; // TODO: Initialize to an appropriate value
            ForecastObject fo = darkSky.Forecast(location);
            Console.WriteLine("{0}", fo.DayPrecipitationList[0].Type);
            //Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
