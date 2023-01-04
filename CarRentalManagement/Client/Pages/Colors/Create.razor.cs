using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Colors;

public partial class Create
{
	[Inject] private IHttpRepository<Color> Repository { get; set; }
	[Inject] private NavigationManager NavigationManager { get; set; }

	private readonly Color _color = new();

	private async Task CreateNewColor()
	{
		await Repository.Create($"{Endpoints.ColorsEndpoint}", _color);
		NavigationManager.NavigateTo("/colors/");
	}
}