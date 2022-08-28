using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.ViewModels
{
    public class PublisherVM
    {
        public string Name { get; set; }
    }

    public class PublisherWithBooksAndAuthorsVM
    {
        public string Name { get; set; }
        public List<BookAuthorVm> BookAuthors { get; set; }
    }

    public class BookAuthorVm
    {
        public string BookName { get; set; }
        public List<string> BookAuthors { get; set; }
    }
}
