﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCTest
{
    public class Validator : IValidator
    {
        public Validator(IDao dao)
        {
        }
    }
}
