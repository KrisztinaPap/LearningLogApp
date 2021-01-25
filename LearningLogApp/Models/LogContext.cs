using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningLogApp.Models
{
    public class LogContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        public LogContext(DbContextOptions<LogContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
