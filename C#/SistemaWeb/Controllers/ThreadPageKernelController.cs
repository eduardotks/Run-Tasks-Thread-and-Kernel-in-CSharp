using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SistemaWeb.Controllers
{
    public class ThreadPageKernelController : Controller
    {
        public IActionResult ThreadKernel()
        {
            return View();
        }
    }
}