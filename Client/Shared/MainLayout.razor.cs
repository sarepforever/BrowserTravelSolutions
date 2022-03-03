using BrowserTravel.Client.Auth;
using BrowserTravel.Client.Helpers;
using BrowserTravel.Client.Repositories;
using BrowserTravel.Shared.DTOs;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowserTravel.Client.Shared
{
    public partial class MainLayout
    {
        [Inject] IRepository repository { get; set; }
        [Inject] IMostrarMensajes mostrarMensaje { get; set; }
        [Inject] ILoginService loginService { get; set; }

        public UserInfo UserInfo { get; set; }

        protected override async Task OnInitializedAsync()
        {
            UserInfo = new UserInfo();
        }

        async private Task Login(UserInfo userInfo)
        {
            
            if (!userInfo.type)
            {
                var responseHttp = await repository.Post<UserInfo, UserToken>($"api/Users/Create", userInfo);
                if (responseHttp.Error)
                {
                    await Task.Delay(500);
                    await mostrarMensaje.ShowMessageError(await responseHttp.GetBody());
                    return;
                }
                await loginService.Login(responseHttp.Response.Token);
            }
            else
            {
                var responseHttp = await repository.Post<UserInfo, UserToken>($"api/Users/Login", userInfo);
                if (responseHttp.Error)
                {
                    await Task.Delay(500);
                    await mostrarMensaje.ShowMessageError(await responseHttp.GetBody());
                    return;
                }
                await loginService.Login(responseHttp.Response.Token);
            }
            await js.HideModal("modalLogin");
        }

        async private Task TypeLogin(bool type)
        {
            UserInfo.type = type;
            await js.ShowModal("modalLogin");
        }
        async private Task Logout()
        {
            await loginService.Logout();
        }
    }
}
