using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        [Required]
        [Display(Name = "Country Name")]
        public string CountryName { get; set; }

        public List<City> Cities { get; set; }
    }
}
