using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aula.Models;

namespace Aula.Data
{
    public class AulaContext : DbContext
    {
        public AulaContext (DbContextOptions<AulaContext> options)
            : base(options)
        {
        }

        public DbSet<Aula.Models.Departments> Departments { get; set; }
    }
}
