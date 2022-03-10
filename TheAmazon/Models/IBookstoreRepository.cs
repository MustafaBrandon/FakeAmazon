using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheAmazon.Models
{
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }

        public void SaveBook(Book b);

        public void addBook(Book b);

        public void deleteBook(Book b);


    }
}
