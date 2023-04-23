using DataAccessLayer;
using DataTransferObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class AuthorManager
    {
        private readonly AuthorRepository _repository;

        public AuthorManager()
        {
            _repository = new AuthorRepository();
        }

        public AuthorDTO GetAuthorByName(string name)
        {
            return _repository.GetAuthorByName(name);
        }

        public void AddAuthor(string name)
        {
            _repository.AddAuthor(name);
        }
    }
}
