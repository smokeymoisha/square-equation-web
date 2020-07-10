using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SquareEquationContext : DbContext
    {
        public SquareEquationContext() : base("DefaultConnection")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<SquareEquationContext>());
        }

        public DbSet<SquareEquation> SquareEquations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SquareEquation>().HasKey(eq => eq.Identificator);
            modelBuilder.Entity<SquareEquation>().ToTable("Equations");
            modelBuilder.Entity<SquareEquation>().Property(eq => eq.Discriminant).HasColumnName("D");
        }
    }
}
