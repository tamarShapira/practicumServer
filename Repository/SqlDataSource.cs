using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;
//using static System.Net.Mime.MediaTypeNames;

namespace Repository
{
    public class SqlDataSource:DbContext,IDataSource
    {
        public SqlDataSource(DbContextOptions<SqlDataSource> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\USER\\Documents\\practice_project.mdf;Integrated Security=True;Connect Timeout=30");
                                         //Data Source=sqlsrv;Initial Catalog=#calender_project;Integrated Security=True;TrustServerCertificate=True
            base.OnConfiguring(optionsBuilder);
        }
        //protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        //{
        //    builder.Properties<DateOnly>()
        //        .HaveConversion<DateTime>()
        //        .HaveColumnType("date");
        //}
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>()
        //        .Property(i => i.UserId)
        //        .HasColumnName("IDD");
        //}
        //public override int SaveChanges()
        //{
        //    return base.SaveChanges();
        //}

        public Task<int> SaveChangesAsync()
        {
           return base.SaveChangesAsync();
        }

        public Microsoft.EntityFrameworkCore.DbSet<Parent> Parent { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Child> Child { get; set; }
    }
    //public class DateOnlyConverter : ValueConverter<DateOnly, DateTime>
    //{
    //    /// <summary>
    //    /// Creates a new instance of this converter.
    //    /// </summary>
    //    public DateOnlyConverter() : base(
    //            d => d.ToDateTime(TimeOnly.MinValue),
    //            d => DateOnly.FromDateTime(d))
    //    { }
    //}
}

