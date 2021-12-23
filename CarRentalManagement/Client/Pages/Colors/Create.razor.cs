using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Colors
{
    public partial class Create : IDisposable
    {
        [Inject] private HttpClient _httpClient { get; set; }
        [Inject] private NavigationManager _navigationManager { get; set; }
        [Inject] HttpInterceptorService _httpInterceptorService { get; set; }

        private readonly Color _color = new Color();

        private async Task CreateNewColor()
        {
            _httpInterceptorService.MonitorEvent();
            await _httpClient.PostAsJsonAsync($"{Endpoints.ColorsEndpoint}", _color);
            _navigationManager.NavigateTo("/colors/");
        }

        public void Dispose()
        {
            _httpInterceptorService.DisposeEvent();
        }
    }
}
