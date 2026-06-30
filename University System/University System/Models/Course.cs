using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_System.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int courseId { get; set; }// System Generated / Primary Key, auto-generated

        [Required]
        [MaxLength(10)]
        public string courseCode { get; set; }// User Input / Required, unique, max length 10

        [Required]
        [MaxLength(150)]
        public string courseTitle { get; set; }// User Input / Required, max length 150

        [Required]
        [Range(1,6)]
        public int creditHours { get; set; } // User Input / Required, range 1-6

        [ForeignKey(nameof(Department))]
        [Required]
        public int departmentId { get; set; } // Foreign Key / Required (course belongs to one department)


        [ForeignKey(nameof(Instructor))]
        public int? instructorId { get; set; }// Foreign Key / Optional (course may be unassigned)


        [Required]
        [MaxLength(20)]
        public string semesterOffered { get; set; }// User Input / Required, max length 20

        // navigation Property - Many-to-One (Course to Department)
        // each course belongs to exactly one department (Required)
        public Department Department { get; set; }// Required / Total Participation


        // navigation property - many-to-one (course to instructor)
        public Instructor? Instructor { get; set; }// Optional / Partial Participation


        // navigation property - one-to-many (course to enrollment)
        public ICollection<Enrollment> Enrollments { get; set; }



    }
}
