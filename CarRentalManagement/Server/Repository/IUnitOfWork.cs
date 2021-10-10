using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Http;

namespace CarRentalManagement.Server.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Make> Make { get; }
        IGenericRepository<Color> Color { get; }
        //IGenericRepository<Model> Model { get; }
        //IGenericRepository<Vehicle> Vehicle { get; }
        //IGenericRepository<Customer> Customer { get; }
        //IGenericRepository<Booking> Booking { get; }

        Task Save(HttpContext httpContext);
    }
}
