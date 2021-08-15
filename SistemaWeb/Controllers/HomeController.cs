using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaWeb.Models;

namespace SistemaWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Console.WriteLine("Thread principal iniciada");
            Thread.CurrentThread.Name = "Principal - ";

            Thread t1 = new Thread(new ThreadStart(run));
            t1.Name = "Secundária - ";
            t1.Start();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Thread atual  - " + Thread.CurrentThread.Name + i);
                Thread.Sleep(3000);
                //Thread.Yield();
            }
            Console.WriteLine("Thread Principal terminada");
            //Console.Read();

            return View();
        }

        public static void run()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Thread Atual - " + Thread.CurrentThread.Name + i);
                Thread.Sleep(3000);
                //Thread.Yield();
            }
        }


        //---------------------------------------

    }
}
