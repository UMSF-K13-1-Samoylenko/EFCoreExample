﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreExample.BAL.OutputModels
{
    public class DbBook
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PagesCount { get; set; }
    }
}
