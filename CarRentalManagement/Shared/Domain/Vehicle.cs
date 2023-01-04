using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRentalManagement.Shared.Domain
{
    public class Vehicle : BaseDomainModel
    {
        [Required]
        public int Year { get; set; }
        public string Vin { get; set; }
        public string LicensePlateNumber { get; set; }
        public double RentalRate { get; set; }
        public virtual List<Booking> RentalRecords { get; set; }

        // Id fields automatically map to foreign key objects id.
        [Required]
        public int ModelId { get; set; }
        // Implying inner join might be necessary. And bring back related data.
        public virtual Model Model { get; set; }
        [Required]
        public int MakeId { get; set; }
        public virtual Make Make { get; set; }
        public int ColorId { get; set; }
        public virtual Color Color { get; set; }

        [NotMapped] // wont be in database
        public byte[] Image { get; set; }
        public string ImageName { get; set; }
    }
}
