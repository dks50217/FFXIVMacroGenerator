﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator.Interface
{
    interface IGenerator
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
        bool InitPath();
        bool CreateJsonData();
    }
}
