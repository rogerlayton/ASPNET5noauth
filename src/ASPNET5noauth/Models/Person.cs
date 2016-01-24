using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET5noauth.Models
{
    public class Person
    {
        [Required]
        [StringLength(10, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 2)]
        public string LastName { get; set; }
        [Required]
        public DateTime Birthdate { get; set; }
    }
}
