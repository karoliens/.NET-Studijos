using Abstract.Domain.Enums;
using Abstract.Domain.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Domain.Interfaces
{
    public interface IBookHtmlService
    {
        Dictionary<BookType, List<Book>> Decode(string dataSeed);
        string Encode(Dictionary<BookType, List<Book>> books);
    }
}
