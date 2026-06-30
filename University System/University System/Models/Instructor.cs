using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_System.Models
{
    public class Instructor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int instructorId { get; set; }// System generated / Primary Key, auto-generated

        [Required]
        [MaxLength(100)]
        public string fullName { get; set; }// user input / Required, max length 100

        [Required]
        [MaxLength(150)]
        public string email { get; set; }// user input / Required, unique, max length 150

        [MaxLength(20)]
        public string? officeNumber { get; set; }// user input / Optional, max length 20

        [Required]
        public DateTime hireDate { get; set; }// user input / Required

        [Required]
        [Range(0.01,double.MaxValue )]
        public decimal salary { get; set; }// user input / Required, must be greater than 0

        [Required]
        [MaxLength(50)]
        public string academicTitle { get; set; }// user input / Required, max length 50

        // navigation property - one-to-one (instructor to department as head)
        public Department? departmentHead { get; set; }

        // navigation property - one-to-many (instructor to course)
        public ICollection<Course> coursesTaught { get; set; }
    }
}
