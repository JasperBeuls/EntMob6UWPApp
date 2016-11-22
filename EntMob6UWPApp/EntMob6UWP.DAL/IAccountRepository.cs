using EntMob6UWP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntMob6UWP.DAL
{
    public interface IAccountRepository
    {
        Account GetAccount(string username, string password);
        
    }
}
