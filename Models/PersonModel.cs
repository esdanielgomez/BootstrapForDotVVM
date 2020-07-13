using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotVVMFormBootstrap.Models
{
    public class PersonModel
    {
        [Required]
        public string Username { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string Gender { get; set; }
        public string About { get; set; }
    }
}
