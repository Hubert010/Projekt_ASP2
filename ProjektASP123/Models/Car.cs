using System.ComponentModel.DataAnnotations;

namespace ProjektASP123.Models
{
    public class Car
    {
        [Display(Name = "ID auta")]
        public int CarId { get; set; }

        [Display(Name = "Model")]
        public string Model { get; set; }

        [Display(Name = "Marka")]
        public string Brand { get; set; }

        [Display(Name = "Rok produkcji")]
        public int Year { get; set; }

        [Display(Name = "Dostępność")]
        public bool Availability { get; set; }

    }

}
