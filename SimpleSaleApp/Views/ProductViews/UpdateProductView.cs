using AppPenjualan.Application.ProductServices;
using AppPenjualan.Application.ProductServices.Dto;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Views.ProductViews
{

    public class UpdateProductView
    {
        private IProductAppService _productAppService;

        public UpdateProductView(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        public void DisplayView()
        {
            Console.Clear();
            Console.WriteLine("Update Product");
            Console.WriteLine("---------------");
            Console.Write("Cari Product Code : ");
            string codeSearch = Console.ReadLine();

            var updateProduct = _productAppService.GetProductByCode(codeSearch);
            if (updateProduct != null)
            {
                Console.WriteLine($"Product Code : {updateProduct.ProductCode}");
                Console.WriteLine($"Product Name : {updateProduct.ProductName}");
                Console.WriteLine($"Product Price : {updateProduct.ProductPrice}");
                Console.WriteLine($"Product Qty : {updateProduct.ProductQty}");
                Console.WriteLine($"Supplier : {updateProduct.SuppliersId}");

                Console.WriteLine("==========================================");
                Console.Write("Product Code : ");
                string code = Console.ReadLine();
                Console.Write("Product Name : ");
                string name = Console.ReadLine();
                Console.Write("Product Price : ");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.Write("Product Qty : ");
                int qty = Convert.ToInt32(Console.ReadLine());
                Console.Write("Supplier : ");
                int supplierId = Convert.ToInt32(Console.ReadLine());

                var productDto = new UpdateProductDto();

                productDto.ProductCode = code;
                productDto.ProductName = name;
                productDto.ProductPrice = price;
                productDto.ProductQty = qty;
                productDto.SuppliersId = supplierId;

                _productAppService.Update(productDto);

            }
        }
    }
}
