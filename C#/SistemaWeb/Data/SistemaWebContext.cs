using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaWeb.Models;

namespace SistemaWeb.Data
{
    public class SistemaWebContext : DbContext
    {
        public SistemaWebContext (DbContextOptions<SistemaWebContext> options)
            : base(options)
        {
        }

        public DbSet<SistemaWeb.Models.Funcionarios> Funcionarios { get; set; }
    }
}
