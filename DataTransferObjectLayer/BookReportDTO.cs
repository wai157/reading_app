﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObjectLayer
{
    public class BookReportDTO
    {
        public int Id { get; set; }
        public int CreateAccountID { get; set; }
        public int ReportedBookID { get; set; }
        public string Content { get; set; }
    }
}
