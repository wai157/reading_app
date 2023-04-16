using EntityLayer;
using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class PBL3DbContext: DbContext
    {
        public PBL3DbContext(): base("name=MyDbConnection")
        {
            Database.SetInitializer(new DbCreate());
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<UserInfo> UserInfoes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Chapter> Chapters { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<History> Histories { get; set; }
        public virtual DbSet<Library> Libraries { get; set; }
        public virtual DbSet<RatedBook> RatedBooks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                        .HasOptional(s => s.UserInfo)
                        .WithRequired(ad => ad.Account);
        }
    }
}
