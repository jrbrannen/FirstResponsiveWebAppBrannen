using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


// Jeremy Brannen
namespace FirstResponsiveWebAppBrannen.Models
{
    public class AgeCalculator
    {
        [Required(ErrorMessage = "Please enter your name.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter a year born")]
        [Range(1900,2021, ErrorMessage = "Year born must be 1900 or after and before current year.")]
        public int? BirthYear { get; set; }
        

        public int CalculateAge()
        {
            const int CURRENT_YEAR = 2021;

            int age = CURRENT_YEAR - BirthYear.Value;

            return age;
        }
    }
}
