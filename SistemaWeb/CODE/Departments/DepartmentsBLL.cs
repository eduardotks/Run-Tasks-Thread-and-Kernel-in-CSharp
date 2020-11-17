using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Text;
using SistemaWeb.CODE;

namespace SistemaWeb.CODE
{
    public class DepartmentsBLL
    {
        public List<Departments> GetDepartamento(out string mensagemErro)
        {
            mensagemErro = "";
            try
            {
                List<Departments> itens = DepartmentsDAL.GetDepartamento(out mensagemErro);
                return itens;
            }
            catch (Exception ex)
            {
                mensagemErro = ex.Message;
                return null;
            }
        }

      
    }
}
