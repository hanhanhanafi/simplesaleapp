using AppPenjualan.Application.ProductServices.Dto;
using AppPenjualan.Application.SupplierServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Views.SupplierViews
{
    public class UpdateSupplierView
    {
        private ISupplierAppService _supplierAppService;
        public UpdateSupplierView(ISupplierAppService supplierAppService)
        {
            _supplierAppService = supplierAppService;
        }

        public void DisplayView()
        {
            
        }
    }
}
