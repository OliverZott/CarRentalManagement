using CarRentalManagement.Client.Contracts;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Services;

public class HttpRepository<T> : IDisposable, IHttpRepository<T> where T : class
{
	private readonly HttpClient _httpClient;
	private readonly HttpInterceptorService _httpInterceptorService;

	public HttpRepository(HttpClient httpClient, HttpInterceptorService httpInterceptorService)
	{
		_httpClient = httpClient;
		_httpInterceptorService = httpInterceptorService;
	}


	public async Task<T> Get(string url, int id)
	{
		_httpInterceptorService.MonitorEvent();
		return await _httpClient.GetFromJsonAsync<T>($"{url}/{id}");
	}

	public async Task<T> GetDetails(string url, int id)
	{
		_httpInterceptorService.MonitorEvent();
		return await _httpClient.GetFromJsonAsync<T>($"{url}/{id}/details");
	}

	public async Task<IList<T>> GetAll(string url)
	{
		_httpInterceptorService.MonitorEvent();
		return await _httpClient.GetFromJsonAsync<IList<T>>(url);
	}

	public async Task Create(string url, T obj)
	{
		_httpInterceptorService.MonitorEvent();
		await _httpClient.PostAsJsonAsync(url, obj);
	}

	public async Task Update(string url, T obj, int id)
	{
		_httpInterceptorService.MonitorEvent();
		await _httpClient.PutAsJsonAsync($"{url}/{id}", obj);
	}

	public async Task Delete(string url, int id)
	{
		_httpInterceptorService.MonitorEvent();
		await _httpClient.DeleteAsync($"{url}/{id}");

	}

	public void Dispose()
	{
		_httpInterceptorService.DisposeEvent();
	}
}