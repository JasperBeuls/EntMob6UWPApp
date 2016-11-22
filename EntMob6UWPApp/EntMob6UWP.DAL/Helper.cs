using EntMob6UWP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntMob6UWP.DAL
{
   public static class Helper
    {
        public static Account LoggedInUser { get; set; }
        public const string API_BASE_URL = "http://localhost:8080";
        public static String getBaseEncodedAccount()
        {
  
            string authInfo = LoggedInUser.Username + ":" + LoggedInUser.Password;
            authInfo = Convert.ToBase64String(Encoding.UTF8.GetBytes(authInfo));
            return authInfo;
        
        }
    }
}
