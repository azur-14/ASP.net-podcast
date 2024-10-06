using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication2.Controllers
{
    public class BodyController : Controller
    {
        public IActionResult Index()
        {
            return View("Views/Body/Index.cshtml"); // Đường dẫn cụ thể đến view Body
        }
    }

}