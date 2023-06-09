﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreConsole.Models
{
    public class Booking
    {
        [Key]
        public Guid Id { get; set; }
        public Guid? CustomerID { get; set; }
        public Guid? BookID { get; set; }
        public DateTime? BookingDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string? CustomerName { get; set; }
        public string? BookName { get; set; }


    }
}
