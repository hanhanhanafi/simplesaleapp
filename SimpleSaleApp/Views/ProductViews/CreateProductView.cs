using AppPenjualan.Application.ProductServices;
using AppPenjualan.Application.ProductServices.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Views.ProductViews
{
    public class CreateProductView
    {
        private IProductAppService _productAppService;
        public CreateProductView(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        public void DisplayView()
        {
            Console.Clear();
            Console.WriteLine("Create Product");
            Console.WriteLine("---------------");
            Console.WriteLine("Product Code : ");
            string code = Console.ReadLine();
            Console.WriteLine("Product Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Product Price : ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Product Qty : ");
            int qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Supplier Id : ");
            int supplierId = Convert.ToInt32(Console.ReadLine());

            var createProduct = new CreateProductDto()
            {
                ProductCode = code,
                ProductName = name,
                ProductPrice = price,
                ProductQty = qty,
                SuppliersId = supplierId
            };

            _productAppService.Create(createProduct);
            Console.WriteLine("Success");
            Console.ReadKey();
        }
    }
}
