﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<SongCategory> SongCategories { get; set; }
    }
}
