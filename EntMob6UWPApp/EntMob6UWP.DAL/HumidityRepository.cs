using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EntMob6UWP.Domain;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EntMob6UWP.DAL
{
    public class HumidityRepository : IHumidityRepository
    {
       
      
     

        public List<Humidity> GetAllHumidities()
        {
          
        
            using (var client = new HttpClient())
            {
            
                string endpoint = Helper.API_BASE_URL + "/humidity"; // api url ingeven
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = (new System.Net.Http.Headers.AuthenticationHeaderValue("Basic",Helper.getBaseEncodedAccount()));
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = Task.Run(()=> client.GetAsync(endpoint)).Result;
                if (response.IsSuccessStatusCode)
                {
                 var   str = Task.Run(() => response.Content.ReadAsStringAsync()).Result;
                    
                    var root = JsonConvert.DeserializeObject<List<Humidity>>(str);
                    return root;
                }
       

            }
            return null;

        }
        public Humidity GetLatestHumidity()
        {


            using (var client = new HttpClient())
            {

                string endpoint = Helper.API_BASE_URL + "/humidity/latest"; // api url ingeven
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = (new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Helper.getBaseEncodedAccount()));
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = Task.Run(() => client.GetAsync(endpoint)).Result;
                if (response.IsSuccessStatusCode)
                {
                    var str = Task.Run(() => response.Content.ReadAsStringAsync()).Result;

                    var root = JsonConvert.DeserializeObject<Humidity>(str);
                    return root;
                }


            }
            return null;

        }

       
        

        public List<HumidityAverage> GetAllHumidityAveragesMinute()
        {
            using (var client = new HttpClient())
            {

                string endpoint = Helper.API_BASE_URL + "/humidity/minute"; // api url ingeven
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = (new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Helper.getBaseEncodedAccount()));
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = Task.Run(() => client.GetAsync(endpoint)).Result;
                if (response.IsSuccessStatusCode)
                {
                    var str = Task.Run(() => response.Content.ReadAsStringAsync()).Result;

                    var root = JsonConvert.DeserializeObject<List<HumidityAverage>>(str);
                    return root;
                }


            }
            return null;
        }

        public List<HumidityAverage> GetAllHumidityAveragesHour()
        {
            using (var client = new HttpClient())
            {

                string endpoint = Helper.API_BASE_URL + "/humidity/hour"; // api url ingeven
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = (new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Helper.getBaseEncodedAccount()));
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = Task.Run(() => client.GetAsync(endpoint)).Result;
                if (response.IsSuccessStatusCode)
                {
                    var str = Task.Run(() => response.Content.ReadAsStringAsync()).Result;

                    var root = JsonConvert.DeserializeObject<List<HumidityAverage>>(str);
                    return root;
                }


            }
            return null;
        }

        public List<HumidityAverage> GetAllHumidityAveragesDay()
        {
            using (var client = new HttpClient())
            {

                string endpoint = Helper.API_BASE_URL + "/humidity/day"; // api url ingeven
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = (new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Helper.getBaseEncodedAccount()));
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = Task.Run(() => client.GetAsync(endpoint)).Result;
                if (response.IsSuccessStatusCode)
                {
                    var str = Task.Run(() => response.Content.ReadAsStringAsync()).Result;

                    var root = JsonConvert.DeserializeObject<List<HumidityAverage>>(str);
                    return root;
                }


            }
            return null;
        }

        public List<HumidityAverage> GetAllHumidityAveragesMonth()
        {
            using (var client = new HttpClient())
            {

                string endpoint = Helper.API_BASE_URL + "/humidity/month"; // api url ingeven
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = (new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Helper.getBaseEncodedAccount()));
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = Task.Run(() => client.GetAsync(endpoint)).Result;
                if (response.IsSuccessStatusCode)
                {
                    var str = Task.Run(() => response.Content.ReadAsStringAsync()).Result;

                    var root = JsonConvert.DeserializeObject<List<HumidityAverage>>(str);
                    return root;
                }


            }
            return null;
        }

       

        
      
      
    }
}
