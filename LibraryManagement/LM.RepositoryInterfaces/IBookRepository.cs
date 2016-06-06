using LM.BuisnessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.RepositoryInterfaces
{
    public interface IBookRepository
    {
        Book Create(Book book);
    }
}
