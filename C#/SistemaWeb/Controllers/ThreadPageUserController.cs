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
        public string Prioridade { get; set; }
        #endregion

        #region TELA
        public IActionResult ThreadUser()
        {
            return View();
        }
        #endregion

        #region ThreadUserProcess
        public bool Execucao(int tempo, int qtdProcessso, int prioridade1, int prioridade2, int prioridade3)
        {
            ThreadPageUserController serverObject = new ThreadPageUserController();

            // Create the thread object, passing in the
            // serverObject.InstanceMethod method using a
            // ThreadStart delegate.
            serverObject.Tempo = tempo;
            serverObject.Processo = qtdProcessso;

            //*******
            Thread InstanceCaller = new Thread(new ThreadStart(serverObject.InstanceMethod));
            if (prioridade1 == 1)
                InstanceCaller.Priority = ThreadPriority.Highest;
            if (prioridade1 == 2)
                InstanceCaller.Priority = ThreadPriority.AboveNormal;
            if (prioridade1 == 3)
                InstanceCaller.Priority = ThreadPriority.Normal;
            if (prioridade1 == 4)
                InstanceCaller.Priority = ThreadPriority.BelowNormal;
            if (prioridade1 == 5)
                InstanceCaller.Priority = ThreadPriority.Lowest;
            // Start the thread.
            InstanceCaller.Start();


            Console.WriteLine("Chamada 1!");
            //Thread.Sleep(Tempo);
            //*******
            Thread InstanceCaller2 = new Thread(new ThreadStart(serverObject.InstanceMethod));
            if (prioridade2 == 1)
                InstanceCaller2.Priority = ThreadPriority.Highest;
            if (prioridade2 == 2)
                InstanceCaller2.Priority = ThreadPriority.AboveNormal;
            if (prioridade2 == 3)
                InstanceCaller2.Priority = ThreadPriority.Normal;
            if (prioridade2 == 4)
                InstanceCaller2.Priority = ThreadPriority.BelowNormal;
            if (prioridade2 == 5)
                InstanceCaller2.Priority = ThreadPriority.Lowest;
            // Start the thread.
            InstanceCaller2.Start();


            Console.WriteLine("Chamada 2!");
            //Thread.Sleep(Tempo);
            //*******
            Thread InstanceCaller3 = new Thread(new ThreadStart(serverObject.InstanceMethod));
            if (prioridade3 == 1)
                InstanceCaller3.Priority = ThreadPriority.Highest;
            if (prioridade3 == 2)
                InstanceCaller3.Priority = ThreadPriority.AboveNormal;
            if (prioridade3 == 3)
                InstanceCaller3.Priority = ThreadPriority.Normal;
            if (prioridade3 == 4)
                InstanceCaller3.Priority = ThreadPriority.BelowNormal;
            if (prioridade3 == 5)
                InstanceCaller3.Priority = ThreadPriority.Lowest;
            // Start the thread.
            InstanceCaller3.Start();
            Console.WriteLine("Chamada 3!");
            //Thread.Sleep(Tempo);
            //*******

            return true;
        }

        // The method that will be called when the thread is started.
        public void InstanceMethod()
        {
            string mensagemErro;
            for (int i = 0; i < Processo; i++) //numero de processos
            {

                Console.WriteLine("Thread {0}: Processo {1} , Estado {2}, Priority {3}", Thread.CurrentThread.ManagedThreadId, i, Thread.CurrentThread.ThreadState, Thread.CurrentThread.Priority);
                retorno(Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(Tempo);
            }

        }

        public IActionResult retorno(int thread)
        {
            return Json(new { sucesso = true, thread = thread }) ;
        }

        public void SuspendeThread()
        {
            Thread.CurrentThread.Interrupt();
        }

        #endregion

    }
}