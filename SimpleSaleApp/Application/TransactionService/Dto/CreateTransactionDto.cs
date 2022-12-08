﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Application.TransactionService.Dto
{
    public class CreateTransactionDto
    {
        public int TransactionId { get; set; }  
        public string TransactionCode { get; set; }
        public Nullable<DateTime> TransactionDate { get; set; }
        public int Total { get; set; }
        public string Description { get; set; }
    }
}
