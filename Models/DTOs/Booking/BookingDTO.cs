using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Labb1Restaurant.Models.DTOs.Booking
{
    public class BookingDTO
    {
        [Required]
        public int TableId { get; set; }
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        [Required]
        public string CustomersPhoneNo { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int GuestAttending { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public TimeSpan BookingStart { get; set; }
    }
}
