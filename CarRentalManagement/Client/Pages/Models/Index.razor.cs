using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Models
{
    public partial class Index
    {
        [Inject] private HttpClient _httpClient { get; set; }
        [Inject] private IJSRuntime _js { get; set; }

        private List<Model> _models;

        protected override async Task OnInitializedAsync()
        {
            _models = await _httpClient.GetFromJsonAsync<List<Model>>(Endpoints.ModelsEndpoint);
        }

        private async void Delete(int modelId)
        {
            var model = _models.Find(x => x.Id == modelId);

            if (!await _js.InvokeAsync<bool>("confirm", $"Do you want to delete {model.Name}")) return;
            await _httpClient.DeleteAsync($"{Endpoints.ModelsEndpoint}/{model.Id}");
            await OnInitializedAsync();
        }

    }
}
