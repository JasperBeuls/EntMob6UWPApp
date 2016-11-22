using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using EntMob6UWP.Domain;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EntMob6UWP.DAL
{
    public class BrightnessRepository : IBrightnessRepository
    {
        public List<Brightness> GetAllBrightnesses()
        {
            using (var client = new HttpClient())
            {

                string endpoint = Helper.API_BASE_URL + "/brightness"; // api url ingeven
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = (new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Helper.getBaseEncodedAccount()));
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = Task.Run(() => client.GetAsync(endpoint)).Result;
                if (response.IsSuccessStatusCode)
                {
                    var str = Task.Run(() => response.Content.ReadAsStringAsync()).Result;

                    var root = JsonConvert.DeserializeObject<List<Brightness>>(str);
                    return root;
                }


            }
            return null;



        }
        public Brightness GetLatestBrightness()
        {


            using (var client = new HttpClient())
            {

                string endpoint = Helper.API_BASE_URL + "/brightness/latest"; // api url ingeven
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = (new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Helper.getBaseEncodedAccount()));
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = Task.Run(() => client.GetAsync(endpoint)).Result;
                if (response.IsSuccessStatusCode)
                {
                    var str = Task.Run(() => response.Content.ReadAsStringAsync()).Result;

                    var root = JsonConvert.DeserializeObject<Brightness>(str);
                    return root;
                }


            }
            return null;

        }




        public List<BrightnessAverage> GetAllBrightnessAveragesMinute()
        {
            using (var client = new HttpClient())
            {

                string endpoint = Helper.API_BASE_URL + "/brightness/minute"; // api url ingeven
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = (new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Helper.getBaseEncodedAccount()));
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = Task.Run(() => client.GetAsync(endpoint)).Result;
                if (response.IsSuccessStatusCode)
                {
                    var str = Task.Run(() => response.Content.ReadAsStringAsync()).Result;

                    var root = JsonConvert.DeserializeObject<List<BrightnessAverage>>(str);
                    return root;
                }


            }
            return null;
        }

        public List<BrightnessAverage> GetAllBrightnessAveragesHour()
        {
            using (var client = new HttpClient())
            {

                string endpoint = Helper.API_BASE_URL + "/brightness/hour"; // api url ingeven
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = (new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Helper.getBaseEncodedAccount()));
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = Task.Run(() => client.GetAsync(endpoint)).Result;
                if (response.IsSuccessStatusCode)
                {
                    var str = Task.Run(() => response.Content.ReadAsStringAsync()).Result;

                    var root = JsonConvert.DeserializeObject<List<BrightnessAverage>>(str);
                    return root;
                }


            }
            return null;
        }

        public List<BrightnessAverage> GetAllBrightnessAveragesDay()
        {
            using (var client = new HttpClient())
            {

                string endpoint = Helper.API_BASE_URL + "/brightness/day"; // api url ingeven
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = (new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Helper.getBaseEncodedAccount()));
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = Task.Run(() => client.GetAsync(endpoint)).Result;
                if (response.IsSuccessStatusCode)
                {
                    var str = Task.Run(() => response.Content.ReadAsStringAsync()).Result;

                    var root = JsonConvert.DeserializeObject<List<BrightnessAverage>>(str);
                    return root;
                }


            }
            return null;
        }

        public List<BrightnessAverage> GetAllBrightnessAveragesMonth()
        {
            using (var client = new HttpClient())
            {

                string endpoint = Helper.API_BASE_URL + "/brightness/month"; // api url ingeven
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = (new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Helper.getBaseEncodedAccount()));
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = Task.Run(() => client.GetAsync(endpoint)).Result;
                if (response.IsSuccessStatusCode)
                {
                    var str = Task.Run(() => response.Content.ReadAsStringAsync()).Result;

                    var root = JsonConvert.DeserializeObject<List<BrightnessAverage>>(str);
                    return root;
                }


            }
            return null;
        }

        
    }
}

