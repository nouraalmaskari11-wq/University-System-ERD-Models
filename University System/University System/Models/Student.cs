using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_System.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int studentId { get; set; } // system generated / primary key, auto-generated

        [Required]
        [MaxLength(100)]
        public string fullName { get; set; } // user input / required, max length 100

        [Required]
        [MaxLength(150)]
        public string email { get; set; } // user input / required, unique, max length 150

        [MaxLength(20)]
        public string? phoneNumber { get; set; } // user input / optional, max length 20

        [Required]
        public DateTime dateOfBirth { get; set; } // user input / required

        [Required]
        [Range(2000, 2030)]
        public int enrollmentYear { get; set; } // user input / required, range 2000-2030

        [Range(0.0, 4.0)]
        public decimal gpa { get; set; } = 0; // default value / default 0.0, range 0.0-4.0


        // navigation property - one-to-many (student to enrollment)
        public ICollection<Enrollment> enrollments { get; set; }

    }
}
