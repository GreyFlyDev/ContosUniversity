using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Contos.Models;

namespace Contos.DAL
{
    public class SchoolContext : DbContext 
    {
                                //connection string gets passed in
        public SchoolContext() : base("SchoolContext")
        {
        }
        //dbset == dbTable      Entity == TableRows

        /*SIDE NOTE
          could have omitted the DbSet<Enrollment> and DbSet<Course>
          statements and it would work the same. 
          The Entity Framework would include them implicitly because the Student entity 
          references the Enrollment entity and the Enrollment entity references the Course entity.
             */
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}