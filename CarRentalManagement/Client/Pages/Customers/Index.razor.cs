using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Customers
{
    public partial class Index
    {
        [Inject] private HttpClient _httpClient { get; set; }
        [Inject] private IJSRuntime _js { get; set; }

        private List<Customer> _customers;

        protected override async Task OnInitializedAsync()
        {
            _customers = await _httpClient.GetFromJsonAsync<List<Customer>>(Endpoints.CustomersEndpoint);
        }

        async void Delete(int customerId)
        {
            var customer = _customers.First(q => q.Id == customerId);

            if (!await _js.InvokeAsync<bool>("confirm", $"Do you want to delete {customer.EmailAddress}")) return;
            await _httpClient.DeleteAsync($"{Endpoints.CustomersEndpoint}/{customerId}");
            await OnInitializedAsync();
        }
    }
}
