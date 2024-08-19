using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EF_2.Entities
{
    internal class Instructor
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        public Double Bonus { get; set; }
        [Required]
        public Double Salary { get; set; }
        [Required]
        [MaxLength (50)]
        public String Address { get; set; }
        [Required]
        [Range (1, 100 , ErrorMessage = "HourRate must be at least 1. and max is 100 ")]
        public Double HourRate { get; set; }

        public int? Dept_ID { get; set; }
        public Department Department { get; set; }
        public ICollection<Course> courses { get; set; } = new HashSet<Course>();
    }
}
