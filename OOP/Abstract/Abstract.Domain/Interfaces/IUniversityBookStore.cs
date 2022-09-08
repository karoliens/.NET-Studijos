using Abstract.Domain.Enums;
using Abstract.Domain.Models.Abstract;
using Abstract.Domain.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Domain.Interfaces
{
    public interface IUniversityBookStore
    {
        void Fill(string dataSeed);
        List<EBook> FilterEBooks(string? title);
        AudioBook[] FilterAudioBooks(string? title);
        IEnumerable<PaperbackBook> FilterPaperbackBooks(string? title);
        List<HardcoverBook> FilterHardcoverBooks(string? title);
        void Buy(Book book, int qtty);
        Invoice Sale(Person person, string title, BookType bookType, int qtty);
    }
}
