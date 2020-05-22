using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RSWEB_university_project.Models
{
    public class Student
    {
        [Key]
        public int ID { 
            get;
            set;
        }

        [Required]
        [StringLength(10)]
        [ Display(Name = "Student ID")]
        public String StudentID
        {
            get;
            set;
        }

        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { 
            get;
            set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { 
            get;
            set;
        }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { 
            get;
            set; 
        }

        [Display(Name = "Acquired Credits")]
        public int AcquiredCredits { 
            get;
            set; 
        }

        [Display(Name = "Current Semestar")]
        public int CurrentSemestar { 
            get;
            set;
        }

        [StringLength(25)]
        [Display(Name = "Education Level")]
        public string EducationLevel { 
            get;
            set;
        }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public ICollection<Enrollment> Courses {
            get;
            set;
        }
        public string ImageUrl { 
            get;
            set;
        }
    }
}
