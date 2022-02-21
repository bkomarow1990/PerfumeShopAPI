﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeShopAPI.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string Image { get; set; }


        public virtual Category Category { get; set; }
    }
}
