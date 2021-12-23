using System;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Services;

namespace CarRentalManagement.Client.Pages.Colors
{
    public partial class Index : IDisposable
    {
        [Inject] private HttpClient _httpClient { get; set; }
        [Inject] private IJSRuntime _js { get; set; }
        [Inject] HttpInterceptorService _httpInterceptorService { get; set; }

        private List<Color> _colors;

        protected override async Task OnInitializedAsync()
        {
            _httpInterceptorService.MonitorEvent();
            Console.WriteLine("Hitting Code Behind Form =)");
            _colors = await _httpClient.GetFromJsonAsync<List<Color>>(Endpoints.ColorsEndpoint);
        }

        private async void Delete(int colorId)
        {
            var color = _colors.Find(x => x.Id == colorId);

            if (!await _js.InvokeAsync<bool>("confirm", $"Do you want to delete {color.Name}?")) return;
            await _httpClient.DeleteAsync($"{Endpoints.ColorsEndpoint}/{color.Id}");
            await OnInitializedAsync();
        }

        public void Dispose()
        {
            _httpInterceptorService.DisposeEvent();
        }
    }
}

