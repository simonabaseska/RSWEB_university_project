using Microsoft.AspNetCore.Mvc.Rendering;
using RSWEB_university_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSWEB_university_project.ViewModels
{
    public class CoursesFilterVM
    {
        public IList<Course> Courses;
        public SelectList Programmes;
        public SelectList Semestars;
        public string TitleString;
        public string ProgrammeString;
        public int SemestarInt;
    }
}
