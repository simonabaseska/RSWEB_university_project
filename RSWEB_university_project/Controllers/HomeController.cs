using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RSWEB_university_project.Data;
using RSWEB_university_project.Models;

namespace RSWEB_university_project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RSWEB_university_projectContext _dbContext;
        public HomeController(ILogger<HomeController> logger,RSWEB_university_projectContext dbContext )
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            //_dbContext.Teacher.Add(new Teacher { });
            //_dbContext.SaveChanges();

            //var foundt = _dbContext.Teacher.Where(x => x.HireDate > DateTime.UtcNow.AddYears(-1)).ToList();



            //_dbContext.RemoveRange(foundt);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
