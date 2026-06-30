using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_System.Models
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int departmentId { get; set; }// System Generated / Primary Key, auto-generated

        [Required]
        [MaxLength(100)]
        public string departmentName { get; set; }// User Input / Required, unique, max length 100

        [MaxLength(50)]
        public string? building {  get; set; } // User Input / Optional, max length 50

        [Required]
        [Range(0, double.MaxValue)]
        public decimal budget { get; set; }// User Input / Required, must be >= 0

        [ForeignKey(nameof(headInstructor))]
        public int? headInstructorId { get; set; }// Foreign Key / Optional (department may have no head)

        // navigation property - one-to-one (department to instructor as head)
        public Instructor? headInstructor { get; set; }

        // navigation property - one-to-many (department to course)
        public ICollection<Course> courses { get; set; }


    }
}
