using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        [Required(ErrorMessage = "Enter your first name :)")]
        [StringLength(100, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string LastName { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 8, ErrorMessage = "TaxId does not meet length requirement!")]
        public int TaxId { get; set; }

        public string Address { get; set; }

        [Required]
        public string ContactNumber { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        public List<Booking> Bookings { get; set; }
    }
}