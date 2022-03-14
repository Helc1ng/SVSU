using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web.Data.Models;

namespace web.Data.interfaces
{
    public class IBookCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
