using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SistemaWeb.Controllers
{
    public class ThreadController : Controller
    {
        public IActionResult Thread()
        {
            return View();
        }
    }
}