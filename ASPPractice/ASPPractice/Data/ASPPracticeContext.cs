using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPPractice.Models;

namespace ASPPractice.Data
{
    public class ASPPracticeContext : DbContext
    {
        public ASPPracticeContext (DbContextOptions<ASPPracticeContext> options)
            : base(options)
        {
        }

        public DbSet<ASPPractice.Models.joke> joke { get; set; }
    }
}
