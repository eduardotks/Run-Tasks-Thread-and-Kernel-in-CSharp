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
    public class ThreadPageKernelController : Controller
    {
        #region Atributes
        public int Tempo { get; set; }
        public int Processo { get; set; }
        public int NumeroDeThreads { get; set; }
        public string Prioridade { get; set; }

        public List<int> thread { get; set; }
        //List<int> thread = new List<int>();
        #endregion
        public IActionResult ThreadKernel()
        {
            return View();
        }



        #region ThreadUserProcess


        public void Execucao()
        {
            //Console.WriteLine("Thread principal iniciada");
            Thread.CurrentThread.Name = "Principal - ";

            Thread t1 = new Thread(new ThreadStart(run));
            t1.Name = "Secundária - ";
            t1.Start();


            Thread t2 = new Thread(new ThreadStart(run));
            t2.Name = "Terciária - ";
            t2.Start();
            /*
            for (int i = 0; i < 5; i++)
            {
                //Console.WriteLine("Thread atual  - " + Thread.CurrentThread.Name + i);
                Thread.Sleep(3000);
                
            }
            */



            //Console.WriteLine("Thread Principal terminada");
            //Console.Read();

            
        }

        public static void run()
        {

            int cont = 1;
            int processos = 1;
            for (int i = 0; i < 5; i++)
            {
                if (cont == 1)
                {
                    Console.WriteLine("Estado {0}, Priority {1}", Thread.CurrentThread.ThreadState, Thread.CurrentThread.Priority);
                    Console.WriteLine("Thread {0}: Processo {1}", Thread.CurrentThread.ManagedThreadId + 0, processos);
                    Console.WriteLine("Thread {0}: Processo {1} ", Thread.CurrentThread.ManagedThreadId + 1, processos);
                    Console.WriteLine("Thread {0}: Processo {1} ", Thread.CurrentThread.ManagedThreadId + 2, processos);
                    cont++;
                    processos++;
                    

                }
                if (cont == 2)
                {
                    Console.WriteLine("Estado {0}, Priority {1}",Thread.CurrentThread.ThreadState, Thread.CurrentThread.Priority);
                    Console.WriteLine("Thread {0}: Processo {1}", Thread.CurrentThread.ManagedThreadId, processos);
                    cont++;
                    processos++;
                    

                }
                if (cont == 3)
                {
                    Console.WriteLine("Estado {0}, Priority {1}", Thread.CurrentThread.ThreadState, Thread.CurrentThread.Priority);
                    Console.WriteLine("Thread {0}: Processo {1}", Thread.CurrentThread.ManagedThreadId + 0, processos);
                    Console.WriteLine("Thread {0}: Processo {1} ", Thread.CurrentThread.ManagedThreadId + 1, processos);

                    cont++;
                    processos++;
                    

                }
                if (cont == 4)
                {
                    Console.WriteLine("Estado {0}, Priority {1}", Thread.CurrentThread.ThreadState, Thread.CurrentThread.Priority);
                    Console.WriteLine("Thread {0}: Processo {1}", Thread.CurrentThread.ManagedThreadId + 0, processos);
                    Console.WriteLine("Thread {0}: Processo {1} ", Thread.CurrentThread.ManagedThreadId + 3, processos);

                    processos = 1;
                    cont = 1;
                    Thread.Sleep(3000);
                    
                }

            }
        }
        #endregion

        public void SuspendeThread()
        {
            Thread.CurrentThread.Interrupt();
        }

    }
}

/*       public void InstanceMethod()
        {

            int cont = 0;


            string mensagemErro;
            for (int i = 0; i < Processo; i++) //numero de processos
            {
                if (cont == 0)
                {
                    Console.WriteLine("Thread {0}: Processo {1} , Estado {2}, Priority {3}", Thread.CurrentThread.ManagedThreadId, i, Thread.CurrentThread.ThreadState, Thread.CurrentThread.Priority);
                    Console.WriteLine("Thread {0}: Processo {1} ", Thread.CurrentThread.ManagedThreadId, i);
                    Console.WriteLine("Thread {0}: Processo {1} ", Thread.CurrentThread.ManagedThreadId, i);
                    cont++;
                    Thread.Sleep(3000);
                    break;
                }
                if(cont == 1)
                {
                    Console.WriteLine("Thread {0}: Processo {1} , Estado {2}, Priority {3}", Thread.CurrentThread.ManagedThreadId, i, Thread.CurrentThread.ThreadState, Thread.CurrentThread.Priority);
                    cont++;
                    Thread.Sleep(3000);
                    break;
                }
                if (cont == 3)
                {
                    Console.WriteLine("Thread {0}: Processo {1} , Estado {2}, Priority {3}", Thread.CurrentThread.ManagedThreadId, i, Thread.CurrentThread.ThreadState, Thread.CurrentThread.Priority);
                    Console.WriteLine("Thread {0}: Processo {1} ", Thread.CurrentThread.ManagedThreadId, i);
                    cont++;
                    Thread.Sleep(3000);
                    break;
                }
                if (cont == 4)
                {
                    Console.WriteLine("Thread {0}: Processo {1} , Estado {2}, Priority {3}", Thread.CurrentThread.ManagedThreadId, i, Thread.CurrentThread.ThreadState, Thread.CurrentThread.Priority);
                    Console.WriteLine("Thread {0}: Processo {1} ", Thread.CurrentThread.ManagedThreadId, i);
                    Console.WriteLine("Thread {0}: Processo {1} ", Thread.CurrentThread.ManagedThreadId, i);
                    Console.WriteLine("Thread {0}: Processo {1} ", Thread.CurrentThread.ManagedThreadId, i);
                    cont++;
                    Thread.Sleep(3000);
                    break;
                }
                //retorno(Thread.CurrentThread.ManagedThreadId);
            }

        }
*/