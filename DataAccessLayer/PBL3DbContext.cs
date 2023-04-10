using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class PBL3DbContext: DbContext
    {
        public PBL3DbContext(): base("name=PBL3")
        {
            Database.SetInitializer<PBL3DbContext>(new DbCreate());
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<UserInfo> UserInfos { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Chapter> Chapters { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<History> Histories { get; set; }
        public virtual DbSet<Library> Libraries { get; set; }
        public virtual DbSet<RatedBook> RatedBooks { get; set; }
    }
}
