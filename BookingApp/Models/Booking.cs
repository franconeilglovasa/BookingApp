using System.ComponentModel.DataAnnotations;

namespace BookingApp.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

        [Required]
        [MaxLength(100)]
        public string PassengerName { get; set; }

        [Required]
        [MaxLength(10)]
        public string Date { get; set; }

        [Required]
        [MaxLength(10)]
        public string Time { get; set; }

        [Required]
        [MaxLength(200)]
        public string PickupLocation { get; set; }

        [Required]
        [MaxLength(200)]
        public string DropoffLocation { get; set; }

        [Required]
        public float Distance { get; set; }

        [Required]
        public float Fare { get; set; }

        public float CalculateFare()
        {
            float baseFare = 25.0f;
            float additionalFarePerKm = 20.0f;
            return Distance <= 1 ? baseFare : baseFare + (Distance - 1) * additionalFarePerKm;
        }

    }
}
