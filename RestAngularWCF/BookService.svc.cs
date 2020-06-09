using RestAngularWCF.Data;
using RestAngularWCF.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RestAngularWCF
{
    public class BookService : IBookService
    {
        BookContext db = new BookContext();

        public void AddBook(Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();
        }

        public void AddBookOptions(Book book)
        {

        }

        public void DeleteBook(string bookId)
        {
            Book book = db.Books.Find(bookId);
            db.Books.Remove(book);
            db.SaveChanges();
        }

        public void DeleteBookOptions(string bookId)
        {

        }

        public List<Book> GetBook()
        {
            return db.Books.ToList();
        }

        public Book GetBookDetails(string bookId)
        {
            return db.Books.Find(bookId);
        }

        public void UpdateBook(Book book)
        {
            db.Entry(book).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
