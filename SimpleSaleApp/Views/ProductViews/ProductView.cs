using AppPenjualan.Application.ProductServices;
using AppPenjualan.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Views.ProductViews
{
    public class ProductView
    {
        private IProductAppService _productAppService;
        public ProductView(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        public void DisplayView()
        {
            Console.Clear();

            bool showMenuPage = true;
            int RecordPerPage = 2;
            int PageNumber = 0;

            do
            {
                Console.Write("Enter Page : ");
                int page = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Page Size : ");
                int pageSize = Convert.ToInt32(Console.ReadLine());

                var pageInfo = new PageInfo(page, pageSize);

                var productList = _productAppService.GetAllProducts(pageInfo);

                decimal totalPage = productList.Total / pageSize;

                Console.WriteLine($"Display Page : {page} with total page : {(int)Math.Ceiling(totalPage)}");

                foreach (var product in productList.Data)
                {
                    Console.WriteLine($"{product.ProductCode} - {product.ProductName} - {product.ProductPrice} - " +
                                             $"{product.ProductQty} - {product.SupplierName}");
                }

                Console.WriteLine();
                bool showMenu = true;
                while (showMenu)
                {

                    Console.WriteLine("Choose an option : ");
                    Console.WriteLine("1) Create Product");
                    Console.WriteLine("2) Update Product");
                    Console.WriteLine("3) Delete Product");
                    Console.WriteLine("4) Select Page");
                    Console.WriteLine("5) Search Product");
                    Console.WriteLine("6) Exit");
                    Console.Write("\r\nChoose an option : ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            var createView = new CreateProductView(_productAppService);
                            createView.DisplayView();
                            showMenu = true;
                            break;
                        case "2":
                            var updateView = new UpdateProductView(_productAppService);
                            updateView.DisplayView();
                            showMenu = true;
                            break;
                        case "3":
                            var deleteView = new DeleteProductView(_productAppService);
                            deleteView.DisplayView();
                            showMenu = true;
                            break;
                        case "4":
                            showMenu = true;
                            break;
                        case "5":
                            showMenu = true;
                            break;
                        case "6":
                            showMenu = false;
                            break;
                    }
                }
            } while (showMenuPage);
        }
    }
}
