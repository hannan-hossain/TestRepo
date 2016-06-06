using LM.BuisnessEntities;
using LM.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.Repositories
{
    public class BookRepository: IBookRepository
    {
        public GenericRepository<LibraryContext> GenericRepositoryInstance { get; set; }

        public BookRepository()
        {
            GenericRepositoryInstance = new GenericRepository<LibraryContext>();
        }
        public Book Create(Book book)
        {
            try
            {
                GenericRepositoryInstance.IntiailizeDate<Book>(book);
                GenericRepositoryInstance.Add<Book>(book);
                GenericRepositoryInstance.Commit();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Test error", ex);
            }

            return book;
        }
    }
}
