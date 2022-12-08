using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Database
{
    [Table("TransactionDetails", Schema = "dbo")]
    public class TransactionDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Transaction Details Id")]
        public int TransactionDetailsId { get; set; }
        public int TransactionsId { get; set; }
        public int ProductsId { get; set; }
        public int Qty { get; set; }
        public int SubTotal { get; set; }

        public virtual Products Products { get; set; } // Merelasikan
        public virtual Transactions Transactions { get; set; }

    }
}
