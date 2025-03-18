using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rafaela.Models;

namespace Rafaela.Data
{
    public class RafaelaContext : DbContext
    {
        public RafaelaContext (DbContextOptions<RafaelaContext> options)
            : base(options)
        {
        }

        public DbSet<Rafaela.Models.Aluno> Aluno { get; set; } = default!;
    }
}
