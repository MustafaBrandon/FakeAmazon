using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheAmazon.Models.ViewModels
{
    public class BookViewModel
    {
        public IQueryable<Book> Books { get; set; }
        public PageInfo PageInfo { get; set; }

    }
}
