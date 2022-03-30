using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        [Required]
        public string CityName { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }

        public List<Person> People { get; set; }
    }
}
