﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Mocking
{
    internal class Program
    {
        public static void Main()
        {
            var service = new VideoService(new FileReader());
            var result = service.ReadVideoTitle();
        }
    }
}
