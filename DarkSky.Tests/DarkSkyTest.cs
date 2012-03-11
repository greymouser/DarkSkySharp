using DarkSkySharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace DarkSkySharp.Tests
{
    /// <summary>
    ///This is a test class for DarkSkyTest and is intended
    ///to contain all DarkSkyTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DarkSkyTest
    {
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

        /// <summary>
        ///A test for Precipitation
        ///</summary>
        [TestMethod()]
        public void PrecipitationTest()
        {
            DarkSky darkSky = new DarkSky();
            Geolocation location = new Geolocation();
            //string expected = string.Empty; // TODO: Initialize to an appropriate value
            List<KeyValuePair<Geolocation, int>> list = new List<KeyValuePair<Geolocation, int>>()
            {
                new KeyValuePair<Geolocation, int>(location, 1331416523),
                new KeyValuePair<Geolocation, int>(location, 1331416777)
            };
            PrecipitationObject po = darkSky.Precipitation(list);
            Console.WriteLine("{0}", po.PrecipitationList[0].Type);
            //Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
