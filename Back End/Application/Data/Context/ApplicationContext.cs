using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> option) : base(option) { }

        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Table
            modelBuilder.Entity<User>().ToTable("Users");

            #endregion
            #region Keys
            modelBuilder.Entity<User>().HasKey(c => c.Id);


            #endregion

            #region Relationship

            #endregion

            #region Properties
            #region ClientRegion
            modelBuilder.Entity<User>().Property(c => c.Name).HasMaxLength(75);
            #endregion
            #endregion
        }
    }
}
