﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Teplomer
    {


        public delegate void PrehriatieHandler(int teplota);
        public event PrehriatieHandler PrehriatieStroja;
    }
}