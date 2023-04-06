using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BookRepository
    {
        private readonly string _connectionString;

        public BookRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Book> GetHotBooks()
        {
            var books = new List<Book>();
            using (var connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    using (var command = new MySqlCommand("SELECT * FROM books ORDER BY views, rating, likes DESC LIMIT 6", connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                books.Add(new Book
                                {
                                    Name = (string)reader["book_name"],
                                    BookCover = (byte[])reader["book_cover"]
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    connection.Close();
                }
                return books;
            }
        }
    }
}
