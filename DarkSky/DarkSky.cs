using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace DarkSkySharp
{
    public static class API
    {
        internal static string key = "F000000000000000000000000000000000000000";
        internal static string uri = "https://api.darkskyapp.com/v1";
        internal static string userAgent = "DarkSkySharp: v1, .NET CLR";
    }

    public class Geolocation
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Geolocation(double lat = 42.3916667, double lon = -71.5666667)
        {
            Latitude = lat;
            Longitude = lon;
        }

        public override string ToString()
        {
 	        return String.Format("{0},{1}", Latitude, Longitude);
        }
    }

    #region DataContracts for parsing JSON results from DarkSky

    [DataContract]
    public class TimePrecipitationObject
    {
        [DataMember(Name = "probability")]
        public double Probability { get; set; }

        [DataMember(Name = "intensity")]
        public double Intensity { get; set; } 

        [DataMember(Name = "error")]
        public double Error { get; set; } 

        [DataMember(Name = "type")]
        public string Type { get; set; } 

        [DataMember(Name = "time")]
        public int Time { get; set; } 
    }

    [DataContract]
    public class DayPrecipitationObject
    {
        [DataMember(Name = "probability")]
        public double Probability { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "time")]
        public int Time { get; set; }
    }

    [DataContract]
    public class ForecastObject
    {
        [DataMember(Name = "currentSummary")]
        public string CurrentSummary { get; set; }

        [DataMember(Name = "hourSummary")]
        public string HourSummary { get; set; }

        [DataMember(Name = "radarStation")]
        public string RadarStation { get; set; }

        [DataMember(Name = "hourPrecipitation")]
        public List<TimePrecipitationObject> HourPrecipitationList;

        [DataMember(Name = "dayPrecipitation")]
        public List<DayPrecipitationObject> DayPrecipitationList;
    }

    [DataContract]
    public class PrecipitationObject
    {
        [DataMember(Name = "precipitation")]
        public List<TimePrecipitationObject> PrecipitationList;
    }

    #endregion

    public class DarkSky
    {
        public Geolocation Location { get; set; }

        public ForecastObject Forecast(Geolocation location)
        {
            string url = String.Format("{0}/forecast/{1}/{2}", API.uri, API.key, location);
            string s = DoGetRequest(url);
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ForecastObject));
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(s));
            ForecastObject forecastObject = serializer.ReadObject(ms) as ForecastObject;
            return forecastObject;
        }

        public PrecipitationObject Precipitation(List<KeyValuePair<Geolocation,int>> locationsAndTimes)
        {
            string query = "";
            foreach (var kv in locationsAndTimes)
            {
                if (query.Length > 0)
                    query += ";";
                query += String.Format("{0},{1}", kv.Key, kv.Value);
            }
            string url = String.Format("{0}/precipitation/{1}/{2}", API.uri, API.key, query);
            string s = DoGetRequest(url);
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(PrecipitationObject));
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(s));
            PrecipitationObject precipitationObject = serializer.ReadObject(ms) as PrecipitationObject;
            return precipitationObject;
        }

        private string DoGetRequest(string url)
        {
            WebClient c = new WebClient();
            c.Headers.Add("user-agent", API.userAgent);
            Stream data = c.OpenRead(url);
            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();
            data.Close();
            reader.Close();
            return s;
        }
    }
}
