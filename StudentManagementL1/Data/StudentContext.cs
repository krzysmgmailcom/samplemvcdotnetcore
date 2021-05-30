using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentManagementL1.Models;

namespace StudentManagementL1.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options)
          : base(options)
        {
        }
        public DbSet<StudentManagementL1.Models.Student> Student { get; set; }
        public DbSet<StudentManagementL1.Models.Specialization> Specialization { get; set; }

        //public DbSet<Models.Student> Student { get; set; }

        //public DbSet<Models.Specialization> Specialization { get; set; }
    }
}
