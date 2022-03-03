using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BrowserTravel.Client.Helpers
{
    public class MostrarMensajes : IMostrarMensajes
    {
        private readonly IJSRuntime js;

        public MostrarMensajes(IJSRuntime js)
        {
            this.js = js;
        }

        public async Task ShowMessageError(string mensaje)
        {
            await ShowMessage("Error", mensaje, "error");
        }

        public async Task ShowMessageSuccess(string mensaje)
        {
            await ShowMessage("Bien!", mensaje, "success");
        }

        public async Task ShowMessageWarning(string mensaje, string title = "Atención")
        {
            await ShowMessage(title, mensaje, "warning");
        }

        private async ValueTask ShowMessage(string titulo, string mensaje, string tipoMensaje)
        {
            await js.InvokeVoidAsync("Swal.fire", titulo, mensaje, tipoMensaje);
        }

    }
}
