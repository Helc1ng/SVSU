using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web.Data.Models;

namespace web.Data.interfaces
{
    public interface IAllBooks
    {
        IEnumerable<Book> Book { set; get; }
        IEnumerable<Book> getFavBook { set; get; }
        Book getObjectbook(int bookId);
    }
}