using AppPenjualan.Database;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Application.TransactionService.Dto
{
    [AutoMap(typeof(Transactions))] // Create Map
    public class TransactionListDto
    {
        public string TransactionCode { get; set; }
        public Nullable<DateTime> TransactionDate { get; set; }
        public int Total { get; set; }
        public string Description { get; set; }
    }
}
