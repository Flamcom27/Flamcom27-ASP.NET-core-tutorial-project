#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP.NET__core_tutorial_project.Models;

namespace ASP.NET__core_tutorial_project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ASP.NET__core_tutorial_project.Models.Joke> Joke { get; set; }
    }
}
