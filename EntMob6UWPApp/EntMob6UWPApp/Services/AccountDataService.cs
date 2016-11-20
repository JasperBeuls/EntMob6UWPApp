using EntMob6UWP.DAL;
using EntMob6UWP.Domain;

namespace EntMob6UWPApp.Services
{
    public class AccountDataService
    {
        IEntMob6Repository repository = new EntMob6APIRepository();

        public Account GetAccount(string username, string password)
        {
            return repository.GetAccount(username, password);
        }
    }
}