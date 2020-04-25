using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RSWEB_university_project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSWEB_university_project.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RSWEB_university_projectContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RSWEB_university_projectContext>>()))
            {
                if (context.Student.Any() || context.Teacher.Any() || context.Course.Any())
                {
                    return;   // DB has been seeded
                }

                context.Student.AddRange(

                new Student
                {
                    StudentID = "34/2017",
                    FirstName = "Marija",
                    LastName = "Markoska",
                    EnrollmentDate = DateTime.Parse("2017-09-15"),
                    AcquiredCredits = 170,
                    CurrentSemestar = 6,
                    EducationLevel = "Junior"
                },
                new Student
                {
                    StudentID = "15/2016",
                    FirstName = "Simona",
                    LastName = "Simonoska",
                    EnrollmentDate = DateTime.Parse("2016-09-15"),
                    AcquiredCredits = 200,
                    CurrentSemestar = 8,
                    EducationLevel = "Junior"
                },
                new Student
                {
                    StudentID = "277/2016",
                    FirstName = "Aleksandra",
                    LastName = "Atanasoska",
                    EnrollmentDate = DateTime.Parse("2016-09-15"),
                    AcquiredCredits = 180,
                    CurrentSemestar = 8,
                    EducationLevel = "Junior"
                    
                },
                new Student
                {
                    StudentID = "252/2017",
                    FirstName = "Andrej",
                    LastName = "Andreevski",
                    EnrollmentDate = DateTime.Parse("2017-09-15"),
                    AcquiredCredits = 150,
                    CurrentSemestar = 6,
                    EducationLevel = "Junior"
                    
                },
                new Student
                {
                    StudentID = "250/2017",
                    FirstName = "Angela",
                    LastName = "Angeloska",
                    EnrollmentDate = DateTime.Parse("2017-09-15"),
                    AcquiredCredits = 185,
                    CurrentSemestar = 6,
                    EducationLevel = "Junior"
                    
                },
                new Student
                {
                    StudentID = "10/2015",
                    FirstName = "Marko",
                    LastName = "Markoski",
                    EnrollmentDate = DateTime.Parse("2015-09-15"),
                    AcquiredCredits = 180,
                    CurrentSemestar = 7,
                    EducationLevel = "Junior"
                    
                },
                new Student
                {
                    StudentID = "97/2018",
                    FirstName = "Stefan",
                    LastName = "Stefanoski",
                    EnrollmentDate = DateTime.Parse("2018-09-15"),
                    AcquiredCredits = 120,
                    CurrentSemestar = 4,
                    EducationLevel = "Junior"
                    
                },
                new Student
                {
                    StudentID = "230/2017",
                    FirstName = "Stefani",
                    LastName = "Stefanoska",
                    EnrollmentDate = DateTime.Parse("2017-09-15"),
                    AcquiredCredits = 150,
                    CurrentSemestar = 5,
                    EducationLevel = "Junior"    
                }
            );
                context.SaveChanges();

                context.Teacher.AddRange(
                     new Teacher
                     {
                         FirstName = "Daniel",
                         LastName = "Denkovski",
                         Degree = "PhD",
                         AcademicRank = "Professor",
                         OfficeNumber = "121 A",
                         HireDate = DateTime.Parse("2010-05-12")
                     },
                new Teacher
                {
                    FirstName = "Pero",
                    LastName = "Latkoski",
                    Degree = "PhD",
                    AcademicRank = "Professor",
                    OfficeNumber = "100TK",
                    HireDate = DateTime.Parse("2009-10-25")                
                },
                new Teacher
                {
                    FirstName = "Valentin",
                    LastName = "Rakovik",
                    Degree = "PhD",
                    AcademicRank = "Assistant Professor",
                    OfficeNumber = "200TK",
                    HireDate = DateTime.Parse("2012-10-10")
                },
                new Teacher
                {
                    FirstName = "Aleksandar",
                    LastName = "Risteski",
                    Degree = "PhD",
                    AcademicRank = "Professor",
                    OfficeNumber = "300TK",
                    HireDate = DateTime.Parse("2007-03-20")
                },
                new Teacher
                {
                    FirstName = "Marko",
                    LastName = "Porjazoski",
                    Degree = "PhD",
                    AcademicRank = "Assоciate Professor",
                    OfficeNumber = "400TK",
                    HireDate = DateTime.Parse("2015-09-06")
                },
                new Teacher
                {
                    FirstName = "Goran",
                    LastName = "Jakimovski",
                    Degree = "PhD",
                    AcademicRank = "Assistant Professor",
                    OfficeNumber = "121A",
                    HireDate = DateTime.Parse("2016-06-10")
                },
                new Teacher
                {
                    FirstName = "Vladimir",
                    LastName = "Atanasovski",
                    Degree = "PhD",
                    AcademicRank = "Professor",
                    OfficeNumber = "500TK",
                    HireDate = DateTime.Parse("2012-07-10")
                },
                new Teacher
                {
                    FirstName = "Hristijan",
                    LastName = "Gjoreski",
                    HireDate = DateTime.Parse("2015-12-05"),
                    Degree = "PhD",
                    AcademicRank = "Assistant Professor",
                    OfficeNumber = "210"
                }
               );
                context.SaveChanges();

                context.Course.AddRange(
                    new Course
                    {
                        Title = "Razvoj na serverski WEB aplikacii",
                        Credits = 6,
                        Semestar = 6,
                        Programme = "TKII",
                        EducationLevel = "Junior",
                        FirstTeacherId = context.Teacher.Single(d => d.FirstName == "Daniel" && d.LastName == "Denkovski").TeacherId,
                        SecondTeacherId = context.Teacher.Single(d => d.FirstName == "Pero" && d.LastName == "Latkoski").TeacherId
                    },
                    new Course
                    {
                        Title = "WEB aplikacii",
                        Credits = 6,
                        Semestar = 6,
                        Programme = "TKII",
                        EducationLevel = "Junior",
                        FirstTeacherId = context.Teacher.Single(d => d.FirstName == "Goran" && d.LastName == "Jakimovski").TeacherId,
                        SecondTeacherId = context.Teacher.Single(d => d.FirstName == "Marko" && d.LastName == "Porjazoski").TeacherId
                    },
                    new Course
                    {
                        Title = "Teorija na informacii",
                        Credits = 6,
                        Semestar = 3,
                        Programme = "TKII",
                        EducationLevel = "Junior",
                        FirstTeacherId = context.Teacher.Single(d => d.FirstName == "Aleksandar" && d.LastName == "Risteski").TeacherId,
                        SecondTeacherId = context.Teacher.Single(d => d.FirstName == "Pero" && d.LastName == "Latkoski").TeacherId
                    },
                    new Course
                    {
                        Title = "Modeliranje na podatoci i bazi",
                        Credits = 6,
                        Semestar = 4,
                        Programme = "All",
                        EducationLevel = "Junior",
                        FirstTeacherId = context.Teacher.Single(d => d.FirstName == "Hristija" && d.LastName == "Gjoreski").TeacherId,
                        SecondTeacherId = context.Teacher.Single(d => d.FirstName == "Goran" && d.LastName == "Jakimovski").TeacherId
                    },
                    new Course
                    {
                        Title = "Android progamiranje 2",
                        Credits = 6,
                        Semestar = 6,
                        Programme = "TKII",
                        EducationLevel = "Junior",
                        FirstTeacherId = context.Teacher.Single(d => d.FirstName == "Pero" && d.LastName == "Latkoski").TeacherId,
                        SecondTeacherId = context.Teacher.Single(d => d.FirstName == "Daniel" && d.LastName == "Denkovski").TeacherId
                    },
                    new Course
                    {
                        Title = "Osnovi na WEB programiranje",
                        Credits = 6,
                        Semestar = 5,
                        Programme = "All",
                        EducationLevel = "Junior",
                        FirstTeacherId = context.Teacher.Single(d => d.FirstName == "Vladimir" && d.LastName == "Atanasovski").TeacherId,
                        SecondTeacherId = context.Teacher.Single(d => d.FirstName == "Valentin" && d.LastName == "Rakovik").TeacherId
                    },
                    new Course
                    {
                        Title = "Android programiranje 1",
                        Credits = 6,
                        Semestar = 5,
                        Programme = "TKII",
                        EducationLevel = "Junior",
                        FirstTeacherId = context.Teacher.Single(d => d.FirstName == "Daniel" && d.LastName == "Denkovski").TeacherId,
                        SecondTeacherId = context.Teacher.Single(d => d.FirstName == "Vladimir" && d.LastName == "Atanasovski").TeacherId
                    }
                    );
                context.SaveChanges();

                context.Enrollment.AddRange(
                    new Enrollment
                    {
                        CourseID = 5,
                        StudentID = 5,
                        Semestar = "Winter, 2019/2020",
                        Year = 2020,
                        Grade = 7,
                        SeminalUrl = "",
                        ProjectUrl = "",
                        ExamPoints = 60,
                        SeminalPoints = 20,
                        ProjectPoints = 70,
                        AdditionalPoints = 3,
                        FinishDate = DateTime.Parse("2020-01-28")
                    },
                    new Enrollment
                    {
                        CourseID = 1,
                        StudentID = 6,
                        Semestar = "Summer, 2018/2019",
                        Year = 2019,
                        Grade = 10,
                        SeminalUrl = "",
                        ProjectUrl = "",
                        ExamPoints = 85,
                        SeminalPoints = 95,
                        ProjectPoints = 95,
                        AdditionalPoints = 5,
                        FinishDate = DateTime.Parse("2019-06-28")
                    },
                    new Enrollment
                    {
                        CourseID = 4,
                        StudentID = 8,
                        Semestar = "Summer, 2018/2019",
                        Year = 2019,
                        Grade = 6,
                        SeminalUrl = "",
                        ProjectUrl = "",
                        ExamPoints = 50,
                        SeminalPoints = 40,
                        ProjectPoints = 55,
                        AdditionalPoints = 0,
                        FinishDate = DateTime.Parse("2019-06-06")
                    },
                    new Enrollment
                    {
                        CourseID = 7,
                        StudentID = 2,
                        Semestar = "Winter, 2019/2020",
                        Year = 2020,
                        Grade = 8,
                        SeminalUrl = "",
                        ProjectUrl = "",
                        ExamPoints = 60,
                        SeminalPoints = 70,
                        ProjectPoints = 50,
                        AdditionalPoints = 3,
                        FinishDate = DateTime.Parse("2020-01-20")
                    },
                    new Enrollment
                    {
                        CourseID = 6,
                        StudentID = 3,
                        Semestar = "Winter, 2018/2019",
                        Year = 2019,
                        Grade = 6,
                        SeminalUrl = "",
                        ProjectUrl = "",
                        ExamPoints = 50,
                        SeminalPoints = 45,
                        ProjectPoints = 40,
                        AdditionalPoints = 5,
                        FinishDate = DateTime.Parse("2019-01-25")
                    },
                    new Enrollment
                    {
                        CourseID = 3,
                        StudentID = 2,
                        Semestar = "Winter, 2018/2019",
                        Year = 2019,
                        Grade = 10,
                        SeminalUrl = "",
                        ProjectUrl = "",
                        ExamPoints = 90,
                        SeminalPoints = 100,
                        ProjectPoints = 90,
                        AdditionalPoints = 10,
                        FinishDate = DateTime.Parse("2019-02-01")
                    }
                    
                    );
                context.SaveChanges();
            }
        }
    }
}
    

