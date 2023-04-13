using EntityLayer;
using Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using DataAccessLayer.Properties;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DbCreate: CreateDatabaseIfNotExists<PBL3DbContext>
    {
        protected override void Seed(PBL3DbContext context)
        {
            context.Accounts.AddRange(new Account[]
            {
                new Account{Id = 1, Username = "admin", Email = "admin@gmail.com", Password = Extensions.GetSHA256Hash("admin"), RoleId = 1},
                new Account{Id = 2, Username = "mod", Email = "mod@gmail.com", Password = Extensions.GetSHA256Hash("mod"), RoleId = 2},
                new Account{Id = 3, Username = "user", Email = "user@gmail.com", Password = Extensions.GetSHA256Hash("user"), RoleId = 3},
            });
            context.Roles.AddRange(new Role[]
            {
                new Role{Id = 1, Name = "admin"},
                new Role{Id = 2, Name = "mod"},
                new Role{Id = 3, Name = "user"},
            });
            context.Books.AddRange(new Book[]
            {
                new Book{Id = 1, Name = "Đại quản gia là ma hoàng", Cover = Extensions.ImageToByteArray(Resources.daiquangialamahoang), AuthorId = 1, AccountId = 1},
                new Book{Id = 2, Name = "Ta thật không phải cải thế cao nhân", Cover = Extensions.ImageToByteArray(Resources.tathatkhongphaicaithecaonhan), AuthorId = 1, AccountId = 1},
                new Book{Id = 3, Name = "Không để ta chết nữa ta vô địch thật đấy", Cover = Extensions.ImageToByteArray(Resources.kdtcntvdtd), AuthorId = 1, AccountId = 1},
                new Book{Id = 4, Name = "Góc nhìn của tác giả", Cover = Extensions.ImageToByteArray(Resources.gocnhincuatacgia), AuthorId = 1, AccountId = 1},
                new Book{Id = 5, Name = "Bắc kiếm", Cover = Extensions.ImageToByteArray(Resources.backiem), AuthorId = 1, AccountId = 1},
                new Book{Id = 6, Name = "Võ đang kì hiệp", Cover = Extensions.ImageToByteArray(Resources.vdkh), AuthorId = 1, AccountId = 1},
                new Book{Id = 7, Name = "Vô hạn ma pháp sư", Cover = Extensions.ImageToByteArray(Resources.vohanmaphapsu), AuthorId = 1, AccountId = 1},
                new Book{Id = 8, Name = "Tử thần phiêu nguyệt", Cover = Extensions.ImageToByteArray(Resources.tuthanphieunguyet), AuthorId = 1, AccountId = 1},
            });
            context.Authors.AddRange(new Author[]
            {
                new Author{Id = 1, Name = "Đang cập nhật"},
            });
        }
    }
}
