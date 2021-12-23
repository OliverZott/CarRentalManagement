using Microsoft.AspNetCore.Components;
using System;
using System.Net;
using Toolbelt.Blazor;

namespace CarRentalManagement.Client.Services
{
    public class HttpInterceptorService
    {
        private readonly HttpClientInterceptor _interceptor;
        private readonly NavigationManager _navigationManager;

        public HttpInterceptorService(HttpClientInterceptor interceptor, NavigationManager navigationManager)
        {
            _interceptor = interceptor;
            _navigationManager = navigationManager;
        }

        public void MonitorEvent() => _interceptor.AfterSend += InterceptResponse;

        public void DisposeEvent() => _interceptor.AfterSend -= InterceptResponse;


        //public void MonitorEvent()
        //{
        //    _interceptor.AfterSend += InterceptResponse;
        //}


        private void InterceptResponse(object? sender, HttpClientInterceptorEventArgs e)
        {
            string message = string.Empty;

            if (!e.Response.IsSuccessStatusCode)
            {
                var responseCode = e.Response.StatusCode;

                switch (responseCode)
                {
                    case HttpStatusCode.NotFound:
                        _navigationManager.NavigateTo("/404");
                        message = "The requested resource was not found :(";
                        break;
                    case HttpStatusCode.Unauthorized:
                    case HttpStatusCode.Forbidden:
                        _navigationManager.NavigateTo("/unauthorized");
                        message = "You are not authorized.";
                        break;
                    default:
                        _navigationManager.NavigateTo("/500");
                        message = "Something went wrong.";
                        break;
                }
                throw new Exception(message);
            }
        }
    }
}
