using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EntMob6UWP.Domain;
using Newtonsoft.Json;

namespace EntMob6UWP.DAL
{
    public class EntMob6APIRepository : IEntMob6Repository
    {
        private static List<Humidity> humidities;
        private List<HumidityAverage> humidityAverages;
        const string API_BASE_URL = "http://localhost:8080";
        public Humidity GetHumidityById(string Id)
        {
            string api = ""; // api url ingeven
            var uri = new Uri(String.Format("{0}?format=json", api+Id));
            var client = new HttpClient();
            var response = Task.Run(() => client.GetAsync(uri)).Result;
            response.EnsureSuccessStatusCode();
            var result = Task.Run(() => response.Content.ReadAsStringAsync()).Result;
            return JsonConvert.DeserializeObject<Humidity>(result);
        }

        public List<Humidity> GetAllHumidities()
        {
         //   throw new Exception("hh");
            string endpoint = API_BASE_URL+"/humidity"; // api url ingeven
            var uri = new Uri(String.Format("{0}?format=json", endpoint));
            var client = new HttpClient();
            var response = Task.Run(() => client.GetAsync(uri)).Result;
            response.EnsureSuccessStatusCode();
            var result = Task.Run(() => response.Content.ReadAsStringAsync()).Result;
            var root = JsonConvert.DeserializeObject<RootObject<Humidity>>(result);
            return root.ResultsList;
        }

        public HumidityAverage GetHumidityAverageById(string Id)
        {
            return null;
        }

        public List<HumidityAverage> GetAllHumidityAverages()
        {
            string api = ""; // api url ingeven
            var uri = new Uri(String.Format("{0}?format=json", api));
            var client = new HttpClient();
            var response = Task.Run(() => client.GetAsync(uri)).Result;
            response.EnsureSuccessStatusCode();
            var result = Task.Run(() => response.Content.ReadAsStringAsync()).Result;
            var root = JsonConvert.DeserializeObject<RootObject<HumidityAverage>>(result);
            return root.ResultsList;
        }
        
        public static DateTime ConvertUnixTimeStamp(long unixTimeStamp)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0).AddMilliseconds(Convert.ToDouble(unixTimeStamp));
        }
        public List<Humidity> LoadHumidities()
        {
            humidities = new List<Humidity>()
            {
                new Humidity()
                {
                    ID = "581222330ee8dd087c92d279",
                    Measured = ConvertUnixTimeStamp(1477582920111),
                    Percentage = 80.5

                },
                new Humidity()
                {
                    ID = "581222530ee8dd087c92d27a",
                    Measured = ConvertUnixTimeStamp(1480261320111),
                    Percentage = 80.5

                },
                new Humidity()
                {
                    ID = "5812236b0ee8dd28e031d276",
                    Measured = ConvertUnixTimeStamp(1474990920111),
                    Percentage = 80.5

                }
            };
            return humidities;
        }

        public List<HumidityAverage> LoadHumidityAverages()
        {
            humidityAverages = new List<HumidityAverage>()
            {
                new HumidityAverage()
                {
                    AvgPercent = 75.0999984741211,
                    Date = ConvertUnixTimeStamp(1478020500000),
                    ID = "5818cdf2b3b9493f15b76a6f"
                },
                new HumidityAverage()
                {
                    AvgPercent = 73.0999984741211,
                    Date = ConvertUnixTimeStamp(1478020620000),
                    ID = "5818ce5eb3b9493f15b76a70"
                },
                new HumidityAverage()
                {
                    AvgPercent = 76.0999984741211,
                    Date = ConvertUnixTimeStamp(1478020980000),
                    ID = "5818d2aab3b9493f15b76a74"
                },
                new HumidityAverage()
                {
                    AvgPercent = 74.0999984741211,
                    Date = ConvertUnixTimeStamp(1478021760000),
                    ID = "5818d31ab3b9493f15b76a75"
                }
            };
            return humidityAverages;
        } 
        class RootObject<T>
        {
            public List<T> ResultsList;
        }
    }
}
