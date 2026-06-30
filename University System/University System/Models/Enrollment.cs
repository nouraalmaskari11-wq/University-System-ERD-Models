using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_System.Models
{
    public class Enrollment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int enrollmentId {  get; set; }// System Generated / Primary Key, auto-generated

        [ForeignKey(nameof(Student))]
        [Required]
        public int studentId { get; set; }// Foreign Key / Required (enrollment belongs to one student)

        [ForeignKey(nameof(Course))]
        [Required]
        public int courseId { get; set; }// Foreign Key / Required (enrollment belongs to one course)


        [Required]
        public DateTime enrollmentDate { get; set; }// System Generated / Required

        [MaxLength(2)]
        public string? finalGrade { get; set; }// User Input / Optional, max length 2 (null until graded)


        [Required]
        [MaxLength(20)]
        public string status { get; set; } = "In Progress";// Default Value / Required, default "In Progress"

        // navigation property - many-to-one (enrollment to student)
        public Student Student { get; set; }// Required / Total Participation

        // navigation property - many-to-one (enrollment to course)
        public Course Course { get; set; }// Required / Total Participation
    }
}
