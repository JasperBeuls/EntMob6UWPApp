using EntMob6UWP.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EntMob6UWP.DAL
{
    public class AirPressureRepository : IAirPressureRepository
    {
        public List<AirPressure> GetAllAirPressures()
        {
            using (var client = new HttpClient())
            {

                string endpoint = Helper.API_BASE_URL + "/airPressure"; // api url ingeven
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = (new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Helper.getBaseEncodedAccount()));
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = Task.Run(() => client.GetAsync(endpoint)).Result;
                if (response.IsSuccessStatusCode)
                {
                    var str = Task.Run(() => response.Content.ReadAsStringAsync()).Result;

                    var root = JsonConvert.DeserializeObject<List<AirPressure>>(str);
                    return root;
                }


            }
            return null;



        }
        public AirPressure GetLatestAirPressure()
        {


            using (var client = new HttpClient())
            {

                string endpoint = Helper.API_BASE_URL + "/airPressure/latest"; // api url ingeven
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = (new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Helper.getBaseEncodedAccount()));
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = Task.Run(() => client.GetAsync(endpoint)).Result;
                if (response.IsSuccessStatusCode)
                {
                    var str = Task.Run(() => response.Content.ReadAsStringAsync()).Result;

                    var root = JsonConvert.DeserializeObject<AirPressure>(str);
                    return root;
                }


            }
            return null;

        }




        public List<AirPressureAverage> GetAllAirPressureAveragesMinute()
        {
            using (var client = new HttpClient())
            {

                string endpoint = Helper.API_BASE_URL + "/airPressure/minute"; // api url ingeven
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = (new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Helper.getBaseEncodedAccount()));
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = Task.Run(() => client.GetAsync(endpoint)).Result;
                if (response.IsSuccessStatusCode)
                {
                    var str = Task.Run(() => response.Content.ReadAsStringAsync()).Result;

                    var root = JsonConvert.DeserializeObject<List<AirPressureAverage>>(str);
                    return root;
                }


            }
            return null;
        }

        public List<AirPressureAverage> GetAllAirPressureAveragesHour()
        {
            using (var client = new HttpClient())
            {

                string endpoint = Helper.API_BASE_URL + "/airPressure/hour"; // api url ingeven
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = (new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Helper.getBaseEncodedAccount()));
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = Task.Run(() => client.GetAsync(endpoint)).Result;
                if (response.IsSuccessStatusCode)
                {
                    var str = Task.Run(() => response.Content.ReadAsStringAsync()).Result;

                    var root = JsonConvert.DeserializeObject<List<AirPressureAverage>>(str);
                    return root;
                }


            }
            return null;
        }

        public List<AirPressureAverage> GetAllAirPressureAveragesDay()
        {
            using (var client = new HttpClient())
            {

                string endpoint = Helper.API_BASE_URL + "/airPressure/day"; // api url ingeven
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = (new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Helper.getBaseEncodedAccount()));
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = Task.Run(() => client.GetAsync(endpoint)).Result;
                if (response.IsSuccessStatusCode)
                {
                    var str = Task.Run(() => response.Content.ReadAsStringAsync()).Result;

                    var root = JsonConvert.DeserializeObject<List<AirPressureAverage>>(str);
                    return root;
                }


            }
            return null;
        }

        public List<AirPressureAverage> GetAllAirPressureAveragesMonth()
        {
            using (var client = new HttpClient())
            {

                string endpoint = Helper.API_BASE_URL + "/airPressure/month"; // api url ingeven
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = (new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Helper.getBaseEncodedAccount()));
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = Task.Run(() => client.GetAsync(endpoint)).Result;
                if (response.IsSuccessStatusCode)
                {
                    var str = Task.Run(() => response.Content.ReadAsStringAsync()).Result;

                    var root = JsonConvert.DeserializeObject<List<AirPressureAverage>>(str);
                    return root;
                }


            }
            return null;
        }


    }
}

