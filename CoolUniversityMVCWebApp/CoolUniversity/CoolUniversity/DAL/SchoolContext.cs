using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoolUniversity.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CoolUniversity.DAL //Data Access Layer
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //prevents table names from being pluralized
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
//a DbSet property for each entity set
//an entity set typically corresponds to a database table
//an entity corresponds to a row in the table