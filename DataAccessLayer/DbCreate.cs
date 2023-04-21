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
            context.Roles.AddRange(new Role[]
            {
                new Role{Id = 1, Name = "admin"},
                new Role{Id = 2, Name = "mod"},
                new Role{Id = 3,Name = "user"},
            });
            context.Authors.AddRange(new Author[]
            {
                new Author{Id = 1, Name = "Đang cập nhật"},
            });
            context.Genres.AddRange(new Genre[]
            {
                new Genre{Id = 1, Name = "Trinh thám"},
                new Genre{Id = 2, Name = "Hồi hộp, giật gân"},
                new Genre{Id = 3, Name = "Kinh dị"},
                new Genre{Id = 4, Name = "Lịch sử"},
                new Genre{Id = 5, Name = "Tình cảm"},
                new Genre{Id = 6, Name = "Khoa học viễn tưởng"},
                new Genre{Id = 7, Name = "Giả tưởng"},
                new Genre{Id = 8, Name = "Hư cấu hiện thực"}
            });
            context.Accounts.AddRange(new Account[]
            {
                new Account{Id = 1, Username = "admin", Email = "admin@gmail.com", Password = Extensions.GetSHA256Hash("admin"), RoleId = 1},
                new Account{Id = 3, Username = "user", Email = "user@gmail.com", Password = Extensions.GetSHA256Hash("user"), RoleId = 3},
            });
            context.UserInfoes.AddRange(new UserInfo[]
            {
                new UserInfo{Id = 1, Name = "admin", Avatar = Extensions.ImageToByteArray(Resources._634011), DOB = new DateTime(2003, 07, 15)},
                new UserInfo{Id = 3, Avatar = Extensions.ImageToByteArray(Resources._634011), DOB = new DateTime(1945, 09, 02)}
            });
            context.Books.AddRange(new Book[]
            {
                new Book{Name = "Đại quản gia là ma hoàng", Cover = Extensions.ImageToByteArray(Resources.daiquangialamahoang), AuthorId = 1, AccountId = 1, GenreId = 1},
                new Book{Name = "Ta thật không phải cải thế cao nhân", Cover = Extensions.ImageToByteArray(Resources.tathatkhongphaicaithecaonhan), AuthorId = 1, AccountId = 1, GenreId = 1},
                new Book{Name = "Không để ta chết nữa ta vô địch thật đấy", Cover = Extensions.ImageToByteArray(Resources.kdtcntvdtd), AuthorId = 1, AccountId = 1, GenreId = 1},
                new Book{Name = "Góc nhìn của tác giả", Cover = Extensions.ImageToByteArray(Resources.gocnhincuatacgia), AuthorId = 1, AccountId = 1, GenreId = 1},
                new Book{Name = "Bắc kiếm", Cover = Extensions.ImageToByteArray(Resources.backiem), AuthorId = 1, AccountId = 1, GenreId = 1},
                new Book{Name = "Võ đang kì hiệp", Cover = Extensions.ImageToByteArray(Resources.vdkh), AuthorId = 1, AccountId = 1, GenreId = 1},
                new Book{Name = "Vô hạn ma pháp sư", Cover = Extensions.ImageToByteArray(Resources.vohanmaphapsu), AuthorId = 1, AccountId = 1, GenreId = 1},
                new Book{Name = "Tử thần phiêu nguyệt", Cover = Extensions.ImageToByteArray(Resources.tuthanphieunguyet), AuthorId = 1, AccountId = 1, GenreId = 1},
            });
        }
    }
}
