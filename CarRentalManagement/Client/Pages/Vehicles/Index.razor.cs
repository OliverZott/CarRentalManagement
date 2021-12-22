using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class Index
    {
        [Inject] private HttpClient _httpClient { get; set; }
        [Inject] private IJSRuntime _js { get; set; }

        private List<Vehicle> _vehicles;

        protected override async Task OnInitializedAsync()
        {
            _vehicles = await _httpClient.GetFromJsonAsync<List<Vehicle>>(Endpoints.VehiclesEndpoint);
        }

        private async void Delete(int vehicleId)
        {
            var vehicle = _vehicles.First(v => v.Id == vehicleId);

            if (!await _js.InvokeAsync<bool>("confirm", $"Do you want to delete vehicle with Id: {vehicle.Id}?")) return;
            await _httpClient.DeleteAsync($"api/makes/{vehicleId}");
            await OnInitializedAsync();
        }
    }
}
