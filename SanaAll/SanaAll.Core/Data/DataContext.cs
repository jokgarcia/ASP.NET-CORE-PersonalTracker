using Microsoft.EntityFrameworkCore;
using SanaAll.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanaAll.Core.Data
{
    public class DataContext :  DbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Profile> Profiles { get; set; }

        //Specifying Data Provider and ConnectionString
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = PersonalTracker");
        }
    }
}
