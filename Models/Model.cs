﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication1.Models
{
    public class Model
    {
        public Model(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
