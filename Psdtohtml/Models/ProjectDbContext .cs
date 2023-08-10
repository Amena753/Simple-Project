using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Psdtohtml.Models
{
    public class ProjectDbContext : DbContext
    {
        public DbSet<GenreProductName> Genres { set; get; }
        public DbSet<ProductAlbum> Albums { set; get; }
        public DbSet<ProductArtist> Artists { set; get; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}