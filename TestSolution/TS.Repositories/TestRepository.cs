using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.BusinessEntities;
using TS.RepositoryInterfaces;

namespace TS.Repositories
{
    public class TestRepository: ITestRepository
    {
        public GenericRepository<carshippingreviewsconnection> GenericRepositoryInstance { get; set; }
        public void Test() {
            GenericRepositoryInstance = new GenericRepository<carshippingreviewsconnection>();
        }
    }
}
