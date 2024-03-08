using Microsoft.EntityFrameworkCore;
using OneToOne1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne1.db
{
    public class OneToOne1DbContext:DbContext
    {
        public DbSet<TestStudent>TestStudents { get; set; }
        public DbSet<StudentAdress>StudentAdresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = "Server=localhost\\SQLEXPRESS;Database=TestStudentDb;Trusted_Connection=True;Encrypt=false;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(path);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
