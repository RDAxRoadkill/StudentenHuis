using System;
using System.ComponentModel.DataAnnotations;

namespace StudHuis.Models
{
    public class Meal
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Vul een datum in.")]
        public DateTime MealTime { get; set; }
        [Required(ErrorMessage = "Vul een naam in.")]
        public string Name { get; set; }
        public string Description { get; set; }
        //public User Cook { get; set; }
        public int MaxGuests { get; set; }
        public double price { get; set; }
        //Collection of guests
    }
}