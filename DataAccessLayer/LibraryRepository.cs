using DataTransferObjectLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class LibraryRepository
    {
        private readonly PBL3DbContext _context;

        public LibraryRepository()
        {
            _context = new PBL3DbContext();
        }

        public List<LibraryDTO> GetLibraryByAccountId(int accountId)
        {
            List<Library> libraries = _context.Libraries.Where(x => x.AccountId == accountId).ToList();
            List<LibraryDTO> libraryDTOs = new List<LibraryDTO>();
            foreach (Library library in libraries)
            {
                libraryDTOs.Add(Mapper.ToLibraryDTO(library));
            }
            return libraryDTOs;
        }

        public void AddLibrary(LibraryDTO libraryDTO)
        {
            _context.Libraries.Add(new Library
            {
                AccountId = libraryDTO.AccountId,
                BookId = libraryDTO.BookId
            });
            _context.SaveChanges();
        }

        public void DeleteLibrary(int Id)
        {
            Library libraryToRemove = _context.Libraries.FirstOrDefault(x => x.Id == Id);
            _context.Libraries.Remove(libraryToRemove);
            _context.SaveChanges();
        }
    }
}
