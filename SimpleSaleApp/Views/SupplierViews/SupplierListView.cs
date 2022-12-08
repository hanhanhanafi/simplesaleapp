using AppPenjualan.Application.SupplierServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Views.SupplierViews
{
    public class SupplierListView
    {
        private ISupplierAppService _supplierAppService;
        public SupplierListView(ISupplierAppService supplierAppService)
        {
            _supplierAppService = supplierAppService;
        }

        public void DisplayView()
        {
            var supplierList = _supplierAppService.GetAllSuppliers();
            Console.WriteLine("List Supplier");
            Console.WriteLine("-------------------");
            foreach (var supplier in supplierList)
            {
                Console.WriteLine($"{supplier.SupplierName} - {supplier.SupplierAddress}");
            }
        }
    }
}
