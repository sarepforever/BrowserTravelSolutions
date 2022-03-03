using BrowserTravel.Shared.DTOs;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowserTravel.Client.Shared
{
    public partial class _UserLogin
    {
        [Parameter] public EventCallback<UserInfo> login { get; set; }
        [Parameter] public UserInfo userInfo { get; set; }

        private async Task Login()
        {
            await login.InvokeAsync(userInfo);
        }       
    }
}
