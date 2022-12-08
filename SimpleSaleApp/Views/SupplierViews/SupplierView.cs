using AppPenjualan.Application.SupplierServices;
using AppPenjualan.ConfigProfile;
using AppPenjualan.Database;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Views.SupplierViews
{
    public class SupplierView
    {
        public void DisplayView()
        {
            Console.Clear();

            //bool showMenu = true;
            //int RecordPerPage = 2;
            //int PageNumber = 0;

            //do
            //{
            //    Console.Write("Enter Page : ");
            //    if (int.TryParse(Console.ReadLine(), out PageNumber))
            //    {
            //        if (PageNumber > 0 && PageNumber < 5)
            //        {
            //            var supplierList = _supplierAppService.GetAllProducts()
            //                                                .Skip((PageNumber - 1) * RecordPerPage)
            //                                                .Take(RecordPerPage)
            //                                                .ToList();
            //            foreach (var supplier in supplierList)
            //            {
            //                Console.WriteLine($"{supplier.SupplierName} - {supplier.SupplierAddress}");
            //            }
            //        }
            //    }
            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ConfigurationProfile());
            });

                bool showMenu = true;
                while (showMenu)
                {
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Choose an option : ");
                    Console.WriteLine("1) List Supplier");
                    Console.WriteLine("2) Create Supplier");
                    Console.WriteLine("3) Update Supplier");
                    Console.WriteLine("4) Delete Supplier");
                    Console.WriteLine("5) Exit");
                    Console.Write("\r\nChoose an option : ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                        //Console.Clear();
                        //var contextSupplierList = new PenjualanContext();
                        //IMapper mapperSupplierList = new Mapper(config);
                        //ISupplierAppService supplierAppService = new SupplierAppService(contextSupplierList, mapperSupplierList);
                        //var supplierListView = new SupplierListView(supplierAppService);
                        //supplierListView.DisplayView();
                        showMenu = true;
                            break;
                        case "2":
                        //Console.Clear();
                        //var contextCreateSupplier = new PenjualanContext();
                        //IMapper mapperCreateSupplier = new Mapper(config);
                        //ISupplierAppService createSupplierAppService = new SupplierAppService(contextCreateSupplier, mapperCreateSupplier);
                        //var createSupplierView = new CreateSupplierView(createSupplierAppService);
                        //createSupplierView.DisplayView();
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
           // } while (showMenu);
        }
    }
}
