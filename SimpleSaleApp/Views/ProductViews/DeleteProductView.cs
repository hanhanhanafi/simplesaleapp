using AppPenjualan.Application.ProductServices;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Views.ProductViews
{
    public class DeleteProductView
    {
        private IProductAppService _productAppService;

        public DeleteProductView(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        public void DisplayView()
        {
            Console.Clear();
            Console.WriteLine("Delete Product");
            Console.WriteLine("--------------");
            Console.Write("Input Id Product : ");

            int productId = Convert.ToInt32(Console.ReadLine());
            _productAppService.Delete(productId);

            Console.WriteLine("Success !");
        }
    }
}
