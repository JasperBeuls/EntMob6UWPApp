using System.Collections.Generic;

namespace EntMob6UWP.Domain
{
    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Enabled { get; set; }
        public List<string> Roles { get; set; } 
    }
}