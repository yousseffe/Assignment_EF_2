using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EF_2.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(15)]
        public string FName { get; set; }
        [Required]
        [MaxLength(15)]
        public string LName { get; set; }
        [Required]
        public string Address { get; set; }

        [Range(18, 60)]
        public int Age { get; set; }

        [ForeignKey("Department")]
        public int? Dept_ID { get; set; }
        public Department Department { get; set; }
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
