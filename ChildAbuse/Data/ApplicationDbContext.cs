using ChildAbuse.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ChildAbuse.Data
{
    public class ApplicationDbContext : DbContext
    {
#if DEBUG
        public ApplicationDbContext()
        : base("Server=(localdb)\\mssqllocaldb;Database=child_abuse;Trusted_Connection=True;MultipleActiveResultSets=true")
        {
            var ad = this.UsersAccounts.Count();
            if (ad < 1)
            {
                this.UsersAccounts.Add(new UsersAccount { Username = "admin", Password = "admin" });
                this.SaveChanges();
            }
        }
#else
        public ApplicationDbContext()
           : base("Data Source=SQL5063.site4now.net;Initial Catalog=db_a75b55_childabuse;User Id=db_a75b55_childabuse_admin;Password=Horlarlekhan1#")
        {
            var ad = this.UsersAccounts.Count();
            if (ad < 1)
            {
                this.UsersAccounts.Add(new UsersAccount { Id = Guid.NewGuid(), Username = "admin", Password = "admin" });
                this.SaveChanges();
            }
        }
#endif

        public DbSet<UsersAccount> UsersAccounts { set; get; }
        public DbSet<Incident> Incidents { set; get; }
        public DbSet<Victim> Victims { set; get; }
        public DbSet<Curprit> Curprits { set; get; }
    }
}