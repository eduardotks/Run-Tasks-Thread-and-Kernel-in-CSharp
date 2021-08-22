using System;
using SistemaWeb.CODE;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaWeb.CODE
{
    public class DepartmentsDAL
    {
        public static List<Departments> GetDepartamento(out string mensagemErro)
        {
            List<Departments> lista = new List<Departments>();
            mensagemErro = "";
            Departments cont = new Departments();
            StringBuilder sql = new StringBuilder();
            sql.AppendLine(" SELECT *");
            sql.AppendLine(" FROM bd_sistema_web.departments");

            Command cmd = new Command();
            cmd.CommandText = sql.ToString();
            DataTable retorno = cmd.GetData();

            if (retorno.Rows.Count > 0)
            {
                foreach (DataRow linha in retorno.Rows)
                {
                    lista.Add(new Departments
                    {
                        Id = Convert.ToInt32(linha["ID"].ToString()),
                        Nome = linha["NOME"].ToString(),
                    });
                }
            }
            return lista;

        }
    }
}