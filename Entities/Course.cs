using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EF_2.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        public int Duration { get; set; }

        [ForeignKey("Top_ID")]
        public Topic Topic { get; set; }

        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
    }
}
