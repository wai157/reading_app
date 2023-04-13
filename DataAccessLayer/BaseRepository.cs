using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class BaseRepository
    {
        protected PBL3DbContext _context;
        public BaseRepository(PBL3DbContext context)
        {
            _context = context;
        }
    }
}
