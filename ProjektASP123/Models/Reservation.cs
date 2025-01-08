namespace ProjektASP123.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int CarId { get; set; }
        public string UserId { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public Car Car { get; set; } // Navigation property
    }

}
