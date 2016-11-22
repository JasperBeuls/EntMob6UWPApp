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
    public class AccountRepository : IAccountRepository
    {
        public Account GetAccount(string username, string password)
        {
            //return new Account() {Enabled = true,Password = "Beuls",Username = "Jasper",Roles = new List<string>()};
            using (var client = new HttpClient())
            {

                string endpoint = Helper.API_BASE_URL + "/login?username=" + username + "&password="+password; // api url ingeven
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = Task.Run(() => client.GetAsync(endpoint)).Result;
                if (response.IsSuccessStatusCode)
                {
                    var str = Task.Run(() => response.Content.ReadAsStringAsync()).Result;

                    var root = JsonConvert.DeserializeObject<Account>(str);
                    Helper.LoggedInUser = root;
                    return root;
                }


            }
            return null;
        }
    }
}
