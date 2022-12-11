using System;

using Microsoft.AspNetCore.Mvc;

namespace T5_Ext2.Controllers
{
    public class StudentController: Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Subjects()
        {
            return View();
        }


    }
}
