using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EF_2.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public DateTime HiringDate { get; set; } = DateTime.Now;
        [ForeignKey("Ins_ID")]
        public Instructor? Instructor { get; set; }
    }
}
