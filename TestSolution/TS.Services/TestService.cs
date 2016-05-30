using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.RepositoryInterfaces;
using TS.ServiceInterfaces;

namespace TS.Services
{
    public class TestService : ITestService
    {
        [Dependency]
        public ITestRepository TestRepo { get; set; }
        public void Test()
        {
            TestRepo.Test();
        }
    }
}
