using AppPenjualan.Application.ProductServices;
using AppPenjualan.Application.TransactionService;
using AppPenjualan.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Views.TransactionViews
{
    public class TransactionView
    {
        private ITransactionAppService _transactionAppService;
        public TransactionView(ITransactionAppService transactionAppService)
        {
            _transactionAppService = transactionAppService;
        }
        public void DisplayView()
        {
            Console.Clear();

            bool showMenu = true;
            int RecordPerPage = 2;
            int PageNumber = 0;

            do
            {
                Console.Write("Enter Page : ");
                int page = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Page Size : ");
                int pageSize = Convert.ToInt32(Console.ReadLine());

                var pageInfo = new PageInfo(page, pageSize);
                var transactionList = _transactionAppService.GetAllTransactions(pageInfo);

                decimal totalPage = transactionList.Total / pageSize;

                Console.WriteLine($"Display Page : {page} with total page : {(int)Math.Ceiling(totalPage)}");

                foreach (var transaction in transactionList.Data)
                {
                    //Console.WriteLine($"{transaction.ProductCode} - {transaction.ProductName} - {transaction.ProductPrice} - " +
                    //                         $"{transaction.ProductQty} - {transaction.SupplierName}");
                }

                Console.WriteLine();

                while (showMenu)
                {

                    Console.WriteLine("Choose an option : ");
                    Console.WriteLine("1) Create Transaction");
                    Console.WriteLine("2) Select Transaction");
                    Console.WriteLine("3) Select Page");
                    Console.WriteLine("4) Search Transaction");
                    Console.WriteLine("5) Exit");
                    Console.WriteLine("\r\nChoose an option : ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            showMenu = true;
                            break;
                        case "2":
                            showMenu = true;
                            break;
                        case "3":
                            showMenu = true;
                            break;
                        case "4":
                            showMenu = true;
                            break;
                        case "5":
                            showMenu = false;
                            break;
                    }
                }
            } while (showMenu);
        }
    }
}
