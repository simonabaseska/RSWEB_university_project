using Microsoft.AspNetCore.Mvc.Rendering;
using RSWEB_university_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSWEB_university_project.ViewModels
{
    public class EnrollStudentsVM
    {
        public Course Course { get; set; }
        public IEnumerable<int> SelectedStudents { get; set; }
        public IEnumerable<SelectListItem> StudentList { get; set; }
        public SelectList YearList { get; set; }
        public string selectedSemester { get; set; }
        public int selectedYear { get; set; }
    }
}
