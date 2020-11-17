using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaWeb.CODE;

namespace SistemaWeb.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult List()
        {
            string mensagemErro;
            DepartmentsBLL BLL = new DepartmentsBLL();
            List<Departments> info = BLL.GetDepartamento(out mensagemErro);
            return View(info);
        }
    }
}