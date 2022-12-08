using AppPenjualan.Application.ProductServices.Dto;
using AppPenjualan.Application.ProductServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppPenjualan.Application.SupplierServices;
using AppPenjualan.Application.SupplierServices.Dto;

namespace AppPenjualan.Views.SupplierViews
{
    public class CreateSupplierView
    {
        private ISupplierAppService _supplierAppService;
        public CreateSupplierView(ISupplierAppService supplierAppService)
        {
            _supplierAppService = supplierAppService;
        }

        public void DisplayView()
        {
            Console.Clear();
            Console.WriteLine("Add Supplier");
            Console.WriteLine("-------------");
            Console.Write("Input Supplier Name : ");
            string name = Console.ReadLine();
            Console.Write("Input Supplier Address : ");
            string address = Console.ReadLine();

            var createSupplier = new CreateSupplierDto()
            {
                SupplierName = name,
                SupplierAddress = address
            };

            _supplierAppService.Create(createSupplier);
            Console.WriteLine("Success");
            Console.WriteLine("Press any key to continue !");
            Console.ReadKey();
        }
    }
}
