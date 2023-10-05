using CapitalTask_Backend.Entities;
using CapitalTask_Backend.Interfaces;
using CapitalTask_Backend.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace CaptialTask_Backend.Data
{
    public class TaskBackendContext : DbContext 
    {
        public TaskBackendContext(DbContextOptions<TaskBackendContext> options)
    : base(options)
        {
        }
      

        public DbSet<ProgramDetails> ProgramDetails { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Education> Education{ get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<WorkFlow> WorkFlows { get; set; }
        public DbSet<Question> Question { get; set; }

    }
}
