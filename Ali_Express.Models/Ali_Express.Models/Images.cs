﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali_Express.Models
{
    public class Images:BaseEntity
    {
        public string Url { get; set; }
        public int ProductId { get; set; }
        public  Product Product { get; set; }
    }
}
