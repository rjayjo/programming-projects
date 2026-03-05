using Final_Machine_Project.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Students.BusinessLogic;

namespace Final_Machine_Project.Controllers

{ 
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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

        private StudentsBLL bll = new StudentsBLL();

        public IActionResult Index()
        {
            List<StudentsBLL> list = bll.GetAll();

            return View(list);
        }
       
        public IActionResult Add()
        {
            return View(new StudentsBLL());
        }

        [HttpPost]

        public IActionResult Add(StudentsBLL obj)
        {
            if (ModelState.IsValid)
            {
                obj.Add();
                return RedirectToAction("Index");
            }
            else
            {
                return View(obj);
            }
        }

        public IActionResult Edit(int id)
        {
            StudentsBLL obj = bll.Get(id);
            if (obj.StudentID == 0) return RedirectToAction("Index");

            return View(obj);
        }

        [HttpPost]

        public IActionResult Edit(StudentsBLL obj)
        {
            if (ModelState.IsValid)
            {
                obj.Edit();
                return RedirectToAction("Index");
            }
            else
            {
                return View(obj);
            }
        }

        [HttpPost]
        public IActionResult Delete(StudentsBLL obj)
        {
            obj.Delete();
            return RedirectToAction("Index");
        }

    
    }
}
