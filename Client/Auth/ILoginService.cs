using System.Threading.Tasks;

namespace BrowserTravel.Client.Auth
{
    /// <summary>
    /// Santiago Perea 2022-Mar-03
    /// Login Services
    /// </summary>   
    public interface ILoginService
    {
        Task Login(string token);
        Task Logout();
    }
}
