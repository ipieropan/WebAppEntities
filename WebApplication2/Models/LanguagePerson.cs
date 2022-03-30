using System.ComponentModel.DataAnnotations;
using WebApplication2.Models;

namespace WebApplication2.Models
{
    public class LanguagePerson
    {
        [Display(Name="Language")]
        public string LanguageName { get; set; }
        public Language Language { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
