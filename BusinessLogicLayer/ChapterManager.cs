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
        private readonly BookRepository _bookRepository;

        public ChapterManager()
        {
            _repository = new ChapterRepository();
            _bookRepository = new BookRepository();
        }

        public ChapterDTO GetChapterById(int Id)
        {
            return _repository.GetChapterById(Id);
        }

        public List<ChapterDTO> GetAllChaptersOf(BookDTO book)
        {

            try
            {
                return _repository.GetAllChaptersOf(book).OrderByDescending(x => x.No).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<ChapterDTO> GetAllVerifiedChaptersOf(BookDTO book)
        {
            
            try
            {
                return _repository.GetAllChaptersOf(book).Where(x => x.IsVerified == true)
                    .OrderByDescending(x => x.No).ToList();
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

        public void AddChapter(BookDTO book, ChapterDTO chapter)
        {
            List<ChapterDTO> chapters = _repository.GetAllChaptersOf(book).OrderByDescending(x => x.No).ToList();
            if (chapters.Find(x => x.No == chapter.No) != null)
            {
                throw new Exception("Số chương đã tồn tại! Vui lòng chọn số chương khác!");
            }
            _repository.AddChapter(chapter);
        }

        public void UpdateChapter(BookDTO book, int oldChapterNo, ChapterDTO newChapter)
        {
            List<ChapterDTO> chapters = this.GetAllChaptersOf(book);
            ChapterDTO tempChap = chapters.Find(x => x.No == newChapter.No);
            if (tempChap != null
                && chapters.FindIndex(x => x.No == oldChapterNo) != chapters.FindIndex(x => x.No == tempChap.No))
            {
                throw new Exception("Số chương đã tồn tại! Vui lòng chọn số chương khác!");
            }
            newChapter.IsVerified = false;
            _repository.UpdateChapter(newChapter);
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
