﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.ServiceInterfaces;

namespace TS.Services
{
    public class TestService : ITestService
    {
        public void Test()
        {
            Console.Read();
        }
    }
}
