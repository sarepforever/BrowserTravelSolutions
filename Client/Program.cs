using BrowserTravel.Client.Auth;
using BrowserTravel.Client.Helpers;
using BrowserTravel.Client.Repositories;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BrowserTravel.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddSingleton<ServiceSingleton>();
            builder.Services.AddTransient<ServiceTransient>();
            builder.Services.AddAuthorizationCore();

            builder.Services.AddScoped<IRepository, Repository>();
            builder.Services.AddScoped<IMostrarMensajes, MostrarMensajes>();
            builder.Services.AddScoped<ProveedorAutenticationJWT>();

            builder.Services.AddScoped<AuthenticationStateProvider, ProveedorAutenticationJWT>(
               provider => provider.GetRequiredService<ProveedorAutenticationJWT>());

            builder.Services.AddScoped<ILoginService, ProveedorAutenticationJWT>(
                provider => provider.GetRequiredService<ProveedorAutenticationJWT>());

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
    }
}
