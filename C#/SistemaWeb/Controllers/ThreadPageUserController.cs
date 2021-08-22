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
    public class ThreadPageUserController : Controller
    {
        #region Atributes
        public int Tempo { get; set; }
        public int Processo { get; set; }
        public int NumeroDeThreads { get; set; }
        #endregion

        #region TELA
        public IActionResult ThreadUser()
        {
            ThreadPageUserController serverObject = new ThreadPageUserController();

            // Create the thread object, passing in the
            // serverObject.InstanceMethod method using a
            // ThreadStart delegate.
            serverObject.Tempo = 10000;
            serverObject.Processo = 2;


            //*******
            Thread InstanceCaller = new Thread(new ThreadStart(serverObject.InstanceMethod));
            // Start the thread.
            InstanceCaller.Start();
            Console.WriteLine("Chamada 1!");
            //Thread.Sleep(Tempo);
            //*******
            Thread InstanceCaller2 = new Thread(new ThreadStart(serverObject.InstanceMethod));
            // Start the thread.
            InstanceCaller2.Start();
            Console.WriteLine("Chamada 2!");
            //Thread.Sleep(Tempo);
            //*******
            Thread InstanceCaller3 = new Thread(new ThreadStart(serverObject.InstanceMethod));
            // Start the thread.
            InstanceCaller3.Start();
            Console.WriteLine("Chamada 3!");
            //Thread.Sleep(Tempo);
            //*******

            

            return View();
        }
        #endregion


        #region ThreadUserProcess
        // The method that will be called when the thread is started.
        public void InstanceMethod()
        {
            for (int i = 0; i < Processo; i++) //numero de processos
            {
                
                Console.WriteLine("Thread {0}: Processo {1} , Estado {2}, Priority {3}", Thread.CurrentThread.ManagedThreadId, i,  Thread.CurrentThread.ThreadState, Thread.CurrentThread.Priority);

                Thread.Sleep(Tempo);
            }
        }

        public void SuspendeThread()
        {
            Thread.CurrentThread.Interrupt();
        }

        #endregion

    }
}