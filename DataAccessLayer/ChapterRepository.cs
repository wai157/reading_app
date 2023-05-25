using DataTransferObjectLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ChapterRepository
    {
        private readonly PBL3DbContext _context;

        public ChapterRepository()
        {
            _context = new PBL3DbContext();
        }

        public ChapterDTO GetChapterById(int Id)
        {
            Chapter chapter = _context.Chapters.FirstOrDefault(x => x.Id == Id);
            if (chapter != null)
            {
                return Mapper.ToChapterDTO(chapter);
            }
            return null;
        }

        public List<ChapterDTO> GetAllChaptersOf(BookDTO book)
        {
            List<Chapter> chapters = _context.Chapters.Where(x => x.BookId == book.Id)
                                                      .OrderByDescending(x => x.No)
                                                      .ToList();
            List<ChapterDTO> chapterDTOs = new List<ChapterDTO>();
            foreach(Chapter chapter in chapters)
            {
                ChapterDTO chapterDTO = Mapper.ToChapterDTO(chapter);
                chapterDTOs.Add(chapterDTO);
            }

            return chapterDTOs;
        }

        public List<ChapterDTO> GetAllUnverifiedChapters()
        {
            List<Chapter> chapters = _context.Chapters.Where(x => x.IsVerified == false)
                                                    .ToList();
            List<ChapterDTO> chapterDTOs = new List<ChapterDTO>();
            foreach (Chapter chapter in chapters)
            {
                ChapterDTO chapterDTO = Mapper.ToChapterDTO(chapter);
                chapterDTOs.Add(chapterDTO);
            }

            return chapterDTOs;
            
        }

        public void AddChapter(ChapterDTO chapter)
        {
            _context.Chapters.Add(new Chapter
            {
                No = chapter.No,
                IsVerified = false,
                Title = chapter.Title,
                Content = chapter.Content,
                BookId = chapter.BookId,
            });
            _context.SaveChanges();
        }

        public void UpdateChapter(ChapterDTO chapterDTO)
        {
            Chapter chapterToUpdate = _context.Chapters.FirstOrDefault(x => x.Id == chapterDTO.Id);
            if (chapterToUpdate != null)
            {
                chapterToUpdate.IsVerified = chapterDTO.IsVerified;
                chapterToUpdate.No = chapterDTO.No;
                chapterToUpdate.Title = chapterDTO.Title;
                chapterToUpdate.Content = chapterDTO.Content;
                _context.SaveChanges();
            }
        }

        public void DeleteChapter(int chapterId)
        {
            Chapter chapterToRemove = _context.Chapters.FirstOrDefault(x => x.Id == chapterId);
            if (chapterToRemove != null)
            {
                _context.Chapters.Remove(chapterToRemove);
                _context.SaveChanges();
            }
        }

        public void IncreaseView(int Id)
        {
            Chapter chapter = _context.Chapters.FirstOrDefault(x => x.Id == Id);
            chapter.Views += 1;
            _context.SaveChanges();
        }
    }
}
