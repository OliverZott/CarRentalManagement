using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Makes
{
    public partial class Index
    {
        [Inject] private HttpClient _httpClient { get; set; }
        [Inject] private IJSRuntime _js { get; set; }

        private List<Make> _makes;

        protected override async Task OnInitializedAsync()
        {
            _makes = await _httpClient.GetFromJsonAsync<List<Make>>(Endpoints.MakesEndpoint);
        }

        async void Delete(int makeId)
        {
            var make = _makes.First(q => q.Id == makeId);

            var confirm = await _js.InvokeAsync<bool>("confirm", $"Do you want to delete {make.Name}");
            if (confirm)
            {
                await _httpClient.DeleteAsync($"{Endpoints.MakesEndpoint}/{makeId}");
                await OnInitializedAsync();
            }

        }
    }
}
