using System.Collections.Generic;

namespace CarRentalManagement.Shared.Domain
{
    public class Vehicle : BaseDomainModel
    {
        public int Year { get; set; }
        public string Vin { get; set; }
        public string LicensePlateNumber { get; set; }
        public double RentalRate { get; set; }
        public virtual List<Booking> RentalRecords { get; set; }

        // Id fields automatically map to foreign key objects id.
        public int ModelId { get; set; }
        // Implying inner join might be necessary. And bring back related data.
        public virtual Model Model { get; set; }
        public int MakeId { get; set; }
        public virtual Make Make { get; set; }
        public int ColorId { get; set; }
        public virtual Color Color { get; set; }
    }
}
