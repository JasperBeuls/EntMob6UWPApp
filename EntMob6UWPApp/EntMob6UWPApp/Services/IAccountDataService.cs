using EntMob6UWP.Domain;

namespace EntMob6UWPApp.Services
{
    public interface IAccountDataService
    {
        Account GetAccount(string username, string password);
    }
}