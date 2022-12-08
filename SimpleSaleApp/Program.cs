using AppPenjualan;
using AppPenjualan.Application.ProductServices;
using AppPenjualan.Application.SupplierServices;
using AppPenjualan.ConfigProfile;
using AppPenjualan.Database;
using AppPenjualan.Views.ProductViews;
using AppPenjualan.Views.SupplierViews;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main()
    {
        // Application Service
        // Databases
        // Views


        // Product --> Berisi produk2 yang ada di toko
        // Supplier --> Berisi Supplier yang membawa produk
        // Transaction --> TranDate dan TranCode
        // TransactionDetail --> Product yang dibeli

        /*
         
         Dependency Inejction merupakan sebuah teknik untuk mengatur cara bagaimana suatu objek dibentuk ketika terdapat objek lain yang membutuhkan
         
         */

        //var serviceProvider = new ServiceCollection();
        //serviceProvider.AddLogging();
        //// Singleton, Transient dan Scoped
        //// Singleton = Object di create cuma 1x, setiap request akan memakai object yang sama
        //// Transient = Object akan di create setiap kali request  untuk di create
        //// Scoped = Object di create 1x tapi berbeda dalam setiap request
        //serviceProvider.AddSingleton<IProductAppService, ProductAppService>();
        //serviceProvider.AddSingleton<ProductView>(x => new ProductView(x.GetService<IProductAppService>()));

        //serviceProvider.AddTransient<IProductAppService, ProductAppService>();
        //serviceProvider.AddScoped<IProductAppService, ProductAppService>();

        //IMapper mapper = config.CreateMapper();

        Startup startup = new Startup();

        var productView = startup.Provider.GetService<ProductView>();

        bool showMenu = true;
        while (showMenu)
        {
            Console.Clear();
            Console.WriteLine("Point Of Sales Enigmacamp");
            Console.WriteLine("=========================");
            Console.WriteLine("Choose an option : ");
            Console.WriteLine("1) Products");
            Console.WriteLine("2) Suppliers");
            Console.WriteLine("3) Transaction");
            Console.WriteLine("4) Reports");
            Console.WriteLine("5) Exit");
            Console.Write("\r\nSelect an option : ");

            switch (Console.ReadLine())
            {
                case "1":
                    //var contextProduct = new PenjualanContext();
                    //IMapper mapperProduct = new Mapper(config);
                    //IProductAppService productAppService = new ProductAppService(contextProduct, mapperProduct);
                    //var productView = new ProductView(productAppService);
                    productView.DisplayView();
                    showMenu = true;
                    break;
                case "2":
                    var supplierView = new SupplierView();
                    supplierView.DisplayView();
                    showMenu = true;
                    break;
                case "3":
                    showMenu = true;
                    break;
                case "4":
                    showMenu = true;
                    break;
                case "5":
                    showMenu= false;
                    break;
           
            }
        }
    }
}