﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class NameChangedEventArgs :EventArgs
    {
        public string ExeistingName { get; set; }
        public string newName { get; set; }
    }
}
