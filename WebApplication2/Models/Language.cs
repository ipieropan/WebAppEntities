using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Language
    {
        [Key, Display(Name = "Language")]
        public string LanguageName { get; set; }

        public List<LanguagePerson> LanguagePerson { get; set; }
        public List<Person> People { get; set; }
    }
}
