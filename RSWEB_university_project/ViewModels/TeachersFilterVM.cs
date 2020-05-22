using Microsoft.AspNetCore.Mvc.Rendering;
using RSWEB_university_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSWEB_university_project.ViewModels
{
    public class TeachersFilterVM
    {
        public IList<Teacher> Teachers;
        public string FirstNameString;
        public string LastNameString;
        public SelectList Degrees;
        public SelectList AcademicRanks;
        public string DegreeString;
        public string AcademicRankString;
    }
}
