using System.ComponentModel.DataAnnotations;

namespace ProjektASP123.Models
{
    public class Reservation
    {
        [Display(Name = "ID rezerwacji")]
        public int ReservationId { get; set; }
        
        [Display(Name = "ID auta")]
        public int CarId { get; set; }

        [Display(Name = "ID uzytkownika")]
        public string? UserId { get; set; }

        [Display(Name = "Start rezerwacji")]
        public DateTime ReservationDate { get; set; }

        [Display(Name = "Koniec rezerwacji")]
        public DateTime ReturnDate { get; set; }

        public Car Car { get; set; } 

    }

}
