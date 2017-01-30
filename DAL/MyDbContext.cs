using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlGenerateManager.Models;

namespace HtmlGenerateManager.DAL
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class MyDbContext : DbContext
    {
        static MyDbContext()
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MyDbContext>());
              Database.SetInitializer<MyDbContext>(null);
        }

        public MyDbContext() : base("EFContext") { }

        public DbSet<WebPage> WebPages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
