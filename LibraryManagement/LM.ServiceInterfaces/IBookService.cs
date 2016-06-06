using LM.BuisnessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.ServiceInterfaces
{
    public interface IBookService
    {
        Book Create(Book book);
    }
}
