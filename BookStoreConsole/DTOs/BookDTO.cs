﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreConsole.DTOs
{
    public class BookDTO
    {
        public Guid Id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public string? title { get; set; }
        public string? author { get; set; }
        public int? quantity { get; set; }
        public bool? IsBooked { get; set; }
    }
}
