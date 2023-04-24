using DataAccessLayer;
using DataTransferObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ChapterManager
    {
        private readonly ChapterRepository _repository;

        public ChapterManager()
        {
            _repository = new ChapterRepository();
        }

        public ChapterDTO GetChapterById(int Id)
        {
            return _repository.GetChapterById(Id);
        }

        public List<ChapterDTO> GetAllChapters(BookDTO book)
        {
            return _repository.GetAllChapters(book);
        }

        public void AddChapter(ChapterDTO chapter)
        {
            _repository.AddChapter(chapter);
        }

        public void IncreaseView(int Id)
        {
            _repository.IncreaseView(Id);
        }
    }
}
