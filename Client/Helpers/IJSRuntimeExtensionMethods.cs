using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BrowserTravel.Client.Helpers
{
    /// <summary>
    /// Santiago Perea 2022-Mar-03
    /// Implementation of utilities in js
    /// </summary>   
    public static class IJSRuntimeExtensionMethods
    {
        public static async Task ShowModal(this IJSRuntime js, string id)
        {
            await js.InvokeVoidAsync("showModal", id);
        }
        public static async Task HideModal(this IJSRuntime js, string id)
        {
            await js.InvokeVoidAsync("hideModal", id);
        }
        public static async ValueTask InicializarTimerInactivo<T>(this IJSRuntime js,
           DotNetObjectReference<T> dotNetObjectReference) where T : class
        {
            await js.InvokeVoidAsync("timerInactivo", dotNetObjectReference);
        }

        public static async ValueTask<bool> Confirm(this IJSRuntime js, string mensaje)
        {            
            return await js.InvokeAsync<bool>("confirm", mensaje);
        }

        public static ValueTask<object> SetInLocalStorage(this IJSRuntime js, string key, string content)
            => js.InvokeAsync<object>(
                "localStorage.setItem",
                 key, content
       );

        public static ValueTask<string> GetFromLocalStorage(this IJSRuntime js, string key)
            => js.InvokeAsync<string>(
                "localStorage.getItem",
                key
                );

        public static ValueTask<object> RemoveItem(this IJSRuntime js, string key)
            => js.InvokeAsync<object>(
                "localStorage.removeItem",
                key);      
    }
}
