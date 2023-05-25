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

        public List<ChapterDTO> GetAllVerifiedChaptersOf(BookDTO book)
        {
            
            try
            {
                return _repository.GetAllChaptersOf(book).Where(x => x.IsVerified == true).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<ChapterDTO> GetAllUnverifiedChapters()
        {
            try
            {
                return _repository.GetAllUnverifiedChapters().ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void AddChapter(ChapterDTO chapter)
        {
            _repository.AddChapter(chapter);
        }

        public void UpdateChapter(ChapterDTO chapter)
        {
            chapter.IsVerified = false;
            _repository.UpdateChapter(chapter);
        }

        public void VerifyChapter(int chapterId)
        {
            ChapterDTO chapter = _repository.GetChapterById(chapterId);
            if (this.GetAllUnverifiedChapters().Where(x => x.BookId == chapter.BookId && x.No < chapter.No).Count() > 0)
            {
                throw new Exception("Cần duyệt các chương nhỏ hơn trước!");
            }
            chapter.IsVerified = true;
            _repository.UpdateChapter(chapter);
        }

        public void VerifyAllChapter()
        {
            List<ChapterDTO> chapters = this.GetAllUnverifiedChapters().ToList();
            foreach (ChapterDTO chapter in chapters)
            {
                chapter.IsVerified = true;
                _repository.UpdateChapter(chapter);
            }
        }

        public void DeleteChapter(int chapterId)
        {
            _repository.DeleteChapter(chapterId);
        }

        public void IncreaseView(int Id)
        {
            _repository.IncreaseView(Id);
        }
    }
}
