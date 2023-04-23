using DataTransferObjectLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AuthorRepository
    {
        private readonly PBL3DbContext _context;
        public AuthorRepository()
        {
            _context = new PBL3DbContext();
        }

        public AuthorDTO GetAuthorByName(string name)
        {
            Author author = _context.Authors.FirstOrDefault(x => x.Name == name);
            if (author != null)
            {
                AuthorDTO authorDTO = new AuthorDTO
                {
                    Id = author.Id,
                    Name = author.Name
                };
                return authorDTO;
            }
            return null;
        }

        public void AddAuthor(string name)
        {
            _context.Authors.Add(new Author
            {
                Name = name
            });
            _context.SaveChanges();
        }
    }
}
