﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Application.TransactionDetailServices.Dto
{
    public class CreateTransactionDetailDto
    {
        public int TransactionsId { get; set; }
        public int ProductsId { get; set; }
        public int Qty { get; set; }
        public int SubTotal { get; set; }
    }
}
