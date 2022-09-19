using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using school_5.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Each DB set maps to a table in the database
      
        public DbSet<school_5.Models.Student> Student { get; set; }

        public DbSet<school_5.Models.Test>? Test { get; set; }
        
        public DbSet<school_5.Models.TestResult> TestResults { get; set; }
    }
