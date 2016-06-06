using LM.BuisnessEntities;
using LM.RepositoryInterfaces;
using LM.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.Services
{
    public class BookService: IBookService
    {
        private readonly IBookRepository BookRepo;

        public BookService(IBookRepository BookRepo)
        {
            this.BookRepo = BookRepo;
        }

        public Book Create(Book book)
        {
           return  BookRepo.Create(book);
        }
    }
}
