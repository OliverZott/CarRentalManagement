using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Colors;

public partial class Index
{
    [Inject] private IHttpRepository<Color> HttpRepository { get; set; }
    [Inject] private IJSRuntime _js { get; set; }

    private IList<Color> _colors;

    protected override async Task OnInitializedAsync()
    {
        Console.WriteLine("Hitting Code Behind Form =)");
        _colors = await HttpRepository.GetAll(Endpoints.ColorsEndpoint);
    }

    private async void Delete(int colorId)
    {
        var color = _colors.ToList().Find(x => x.Id == colorId);

        if (!await _js.InvokeAsync<bool>("confirm", $"Do you want to delete {color.Name}?")) return;
        await HttpRepository.Delete(Endpoints.ColorsEndpoint, colorId);
        await OnInitializedAsync();
    }
}