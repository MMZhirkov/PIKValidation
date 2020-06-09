using RestAngularWCF.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace RestAngularWCF.Data
{
    public class BookContext : DbContext
    {
        public BookContext() : base("BookContext") { }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            // TODO Erasmus
            //modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
        }
    }
}