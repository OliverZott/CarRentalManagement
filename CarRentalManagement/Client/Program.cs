using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Toolbelt.Blazor.Extensions.DependencyInjection;

namespace CarRentalManagement.Client;

public class Program
{
	public static async Task Main(string[] args)
	{
		var builder = WebAssemblyHostBuilder.CreateDefault(args);
		builder.RootComponents.Add<App>("#app");

		builder.Services.AddHttpClient("CarRentalManagement.ServerAPI", (sp, client) =>
			{
				client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
				client.EnableIntercept(sp);
			})
			.AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();  // Authorization is ALWAYS needed! On Login Token is generated and saved as cookie, so api request works!

		// Supply HttpClient instances that include access tokens when making requests to the server project
		builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("CarRentalManagement.ServerAPI"));

		builder.Services.AddHttpClientInterceptor();
		builder.Services.AddScoped<HttpInterceptorService>();
		builder.Services.AddTransient(typeof(IHttpRepository<>), typeof(HttpRepository<>));

		builder.Services.AddApiAuthorization();

		await builder.Build().RunAsync();
	}
}