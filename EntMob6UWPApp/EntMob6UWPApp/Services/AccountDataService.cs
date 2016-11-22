using EntMob6UWP.DAL;
using EntMob6UWP.Domain;

namespace EntMob6UWPApp.Services
{
    public class AccountDataService : IAccountDataService
    {
        IAccountRepository repository = new AccountRepository();

        public Account GetAccount(string username, string password)
        {
            return repository.GetAccount(username, password);
        }
    }
}