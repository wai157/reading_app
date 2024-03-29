﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public int RoleId { get; set; }

        public virtual UserInfo UserInfo { get; set; }
        public virtual Verification Verification { get; set; }
        public virtual Role Role { get; set; }
        public virtual List<History> Histories { get; set; }
        public virtual List<Library> Libraries { get; set; }
        public virtual List<RatedBook> RatedBooks { get; set; }
        public virtual List<BookReport> BookReports { get; set; }
        public virtual List<Notification> Notifications { get; set; }
    }
}
