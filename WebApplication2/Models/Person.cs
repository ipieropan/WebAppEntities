using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Person
    {
        [Key]
        public int PeopleId { get; set; }
        [Required]
        [Display(Name = "Full Name")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

        public IList<LanguagePerson> LanguagePerson { get; set; }

    }
}
