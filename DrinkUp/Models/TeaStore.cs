﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkUp.Models
{
    public class TeaStore
    {
        [Key]
        public int TeaStoreID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
