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
    public class TemperatureRepository : ITemperatureRepository
    {
        public List<Temperature> GetAllTemperatures()
        {
            using (var client = new HttpClient())
            {

                string endpoint = Helper.API_BASE_URL + "/temperature"; // api url ingeven
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = (new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Helper.getBaseEncodedAccount()));
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = Task.Run(() => client.GetAsync(endpoint)).Result;
                if (response.IsSuccessStatusCode)
                {
                    var str = Task.Run(() => response.Content.ReadAsStringAsync()).Result;

                    var root = JsonConvert.DeserializeObject<List<Temperature>>(str);
                    return root;
                }


            }
            return null;



        }
        public Temperature GetLatestTemperature()
        {


            using (var client = new HttpClient())
            {

                string endpoint = Helper.API_BASE_URL + "/temperature/latest"; // api url ingeven
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = (new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Helper.getBaseEncodedAccount()));
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = Task.Run(() => client.GetAsync(endpoint)).Result;
                if (response.IsSuccessStatusCode)
                {
                    var str = Task.Run(() => response.Content.ReadAsStringAsync()).Result;

                    var root = JsonConvert.DeserializeObject<Temperature>(str);
                    return root;
                }


            }
            return null;

        }




        public List<TemperatureAverage> GetAllTemperatureAveragesMinute()
        {
            using (var client = new HttpClient())
            {

                string endpoint = Helper.API_BASE_URL + "/temperature/minute"; // api url ingeven
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = (new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Helper.getBaseEncodedAccount()));
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = Task.Run(() => client.GetAsync(endpoint)).Result;
                if (response.IsSuccessStatusCode)
                {
                    var str = Task.Run(() => response.Content.ReadAsStringAsync()).Result;

                    var root = JsonConvert.DeserializeObject<List<TemperatureAverage>>(str);
                    return root;
                }


            }
            return null;
        }

        public List<TemperatureAverage> GetAllTemperatureAveragesHour()
        {
            using (var client = new HttpClient())
            {

                string endpoint = Helper.API_BASE_URL + "/temperature/hour"; // api url ingeven
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = (new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Helper.getBaseEncodedAccount()));
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = Task.Run(() => client.GetAsync(endpoint)).Result;
                if (response.IsSuccessStatusCode)
                {
                    var str = Task.Run(() => response.Content.ReadAsStringAsync()).Result;

                    var root = JsonConvert.DeserializeObject<List<TemperatureAverage>>(str);
                    return root;
                }


            }
            return null;
        }

        public List<TemperatureAverage> GetAllTemperatureAveragesDay()
        {
            using (var client = new HttpClient())
            {

                string endpoint = Helper.API_BASE_URL + "/temperature/day"; // api url ingeven
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = (new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Helper.getBaseEncodedAccount()));
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = Task.Run(() => client.GetAsync(endpoint)).Result;
                if (response.IsSuccessStatusCode)
                {
                    var str = Task.Run(() => response.Content.ReadAsStringAsync()).Result;

                    var root = JsonConvert.DeserializeObject<List<TemperatureAverage>>(str);
                    return root;
                }


            }
            return null;
        }

        public List<TemperatureAverage> GetAllTemperatureAveragesMonth()
        {
            using (var client = new HttpClient())
            {

                string endpoint = Helper.API_BASE_URL + "/temperature/month"; // api url ingeven
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = (new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Helper.getBaseEncodedAccount()));
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = Task.Run(() => client.GetAsync(endpoint)).Result;
                if (response.IsSuccessStatusCode)
                {
                    var str = Task.Run(() => response.Content.ReadAsStringAsync()).Result;

                    var root = JsonConvert.DeserializeObject<List<TemperatureAverage>>(str);
                    return root;
                }


            }
            return null;
        }


    }
}

