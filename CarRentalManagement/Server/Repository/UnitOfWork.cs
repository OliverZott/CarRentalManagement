using CarRentalManagement.Server.Data;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Make> _make;
        private IGenericRepository<Color> _color;
        private IGenericRepository<Model> _model;
        private IGenericRepository<Vehicle> _vehicle;
        private IGenericRepository<Customer> _customer;
        private IGenericRepository<Booking> _booking;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<Make> Make => _make ?? new GenericRepository<Make>(_context);
        public IGenericRepository<Color> Color => _color ?? new GenericRepository<Color>(_context);
        public IGenericRepository<Model> Model => _model ?? new GenericRepository<Model>(_context);
        public IGenericRepository<Vehicle> Vehicle => _vehicle ?? new GenericRepository<Vehicle>(_context);
        public IGenericRepository<Customer> Customer => _customer ?? new GenericRepository<Customer>(_context);
        public IGenericRepository<Booking> Booking => _booking ?? new GenericRepository<Booking>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            var user = httpContext.User.Identity.Name;


            // get updated/created entities to update DateTime
            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State is EntityState.Modified or EntityState.Added);

            foreach (var entityEntry in entries)
            {
                ((BaseDomainModel)entityEntry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entityEntry.Entity).UpdatedBy = user;
                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entityEntry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entityEntry.Entity).CreatedBy = user;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}
