using BrowserTravel.Client.Helpers;
using BrowserTravel.Client.Repositories;
using BrowserTravel.Shared.DTOs;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowserTravel.Client.Pages
{
    public partial class Index
    {
        [Inject] IRepository repository { get; set; }
        [Inject] IMostrarMensajes ShowMessage { get; set; }

        public List<GETBookDTO> _GETLibrosDTO { get; set; }
        public GETBookIdDTO BookDTO { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var responseHttp = await repository.Get<ICollection<GETBookDTO>>($"api/Book");
            if (responseHttp.Error)
            {
                await ShowMessage.ShowMessageError(await responseHttp.GetBody());
                return;
            }
            _GETLibrosDTO = responseHttp.Response.ToList();

        }
        public async Task DetailsBook(GETBookDTO item)
        {
            var responseHttp = await repository.Get<GETBookIdDTO>($"api/Book/{item.id}");
            if (responseHttp.Error)
            {
                await ShowMessage.ShowMessageError(await responseHttp.GetBody());
                return;
            }
            BookDTO = responseHttp.Response;
            await js.ShowModal("modalBook");
        }
    }
}
