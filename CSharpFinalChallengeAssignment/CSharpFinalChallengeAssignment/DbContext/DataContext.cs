using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace CSharpFinalChallengeAssignment
{
    public class DataContext : DbContext
    {
        public DataContext(string connectionString) : base(connectionString)
        {

        }

        public virtual DbSet<Student> Students { get; set; }
    }
}