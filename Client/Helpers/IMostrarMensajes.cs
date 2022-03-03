
using System.Threading.Tasks;

namespace BrowserTravel.Client.Helpers
{
    /// <summary>
    /// Santiago Perea 2022-Mar-03
    /// Interface to display messages to the user
    /// </summary>   
    public interface IMostrarMensajes
    {
        Task ShowMessageError(string mensaje);
        Task ShowMessageSuccess(string mensaje);
        Task ShowMessageWarning(string mensaje, string title = "Atención");
    }
}
