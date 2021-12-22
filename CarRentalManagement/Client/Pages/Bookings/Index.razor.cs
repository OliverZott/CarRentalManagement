using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Bookings
{
    public partial class Index
    {

        [Inject] private HttpClient _httpClient { get; set; }
        [Inject] private IJSRuntime _js { get; set; }

        private List<Booking> _bookings;

        protected override async Task OnInitializedAsync()
        {
            _bookings = await _httpClient.GetFromJsonAsync<List<Booking>>(Endpoints.BookingsEndpoint);
        }

        async void Delete(int makeId)
        {
            var booking = _bookings.First(q => q.Id == makeId);

            if (!await _js.InvokeAsync<bool>("confirm", $"Do you want to delete booking with Id: {booking.Id}")) return;
            await _httpClient.DeleteAsync($"{Endpoints.BookingsEndpoint}/{makeId}");
            await OnInitializedAsync();
        }
    }
}
