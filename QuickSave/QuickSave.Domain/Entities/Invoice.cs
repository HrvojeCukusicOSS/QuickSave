﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSave.Domain.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public float Discount { get; set; }
        public float FullAmount { get; set; }
        public bool IsPaid { get; set; }
        public DateTime DateOfPrinting { get; set; }
        public DateTime DateOfTransaction { get; set; }
        public User Costumer { get; set; }
        public int UserId { get; set; }
        public Voucher Voucher { get; set; }
    }
}
