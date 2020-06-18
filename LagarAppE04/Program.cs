using DocumentFormat.OpenXml.Wordprocessing;
using LagarAppE04.Filters;
using LagarAppE04.Helpers;
using LagarAppE04.JsonFileHelper;
using LagarAppE04.ProductHelper;
using LagarAppE04.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using static System.Console;

namespace LagarAppE04
{
    public class Program
    {


        static void Main()
        {
            ProductFilter productFilter = new ProductFilter();

            int choice = 0;

            do
            {
                Clear();
                WriteLine("1. List all items");
                WriteLine("2. Add New Product");
                WriteLine("3. Find Product");
                WriteLine("4. Delete Product");
                WriteLine("5. Update Product");
                WriteLine("6. Find ManuFacturer");
                WriteLine("7. Find By Price");
                WriteLine("8. List all Shops");
                WriteLine("9. Exit");
                Write("Please, Select a Number from 1 to 9: ");
                int.TryParse(ReadLine(), out choice);



                //
                switch (choice)
                {

                    // Case 1 : Option For List
                    case 1:
                        new FileProductRepository().GetAll();
                        break;

                    // Case 2 : Option For Add
                    case 2:
                        IProductRepository productRepository = new FileProductRepository();
                        var product = ConsoleHelper.NewProduct();
                        productRepository.Insert(product);
                        break;

                    // Case 3 : Option For Find
                    case 3:
                        //ProductFilter.GetByProductName();

                        IProductRepository productFindRep = new FileProductRepository();
                        WriteLine("Product Name :");
                        var productToFind = ReadLine();
                        product = productFindRep.GetByProductName(productToFind);
                        if(product != null)
                        {
                            WriteLine("Product Find ... \n Please Press Enter To Go Back  ");
                        }
                        else
                        {
                            WriteLine("Product Not found... \n Please Press Enter To Go Back ");
                        }
                        ReadLine();
                        break;


                    // Case 4 : Option For Delete
                    case 4:
                        IProductRepository productDeleteRep = new FileProductRepository();
                        WriteLine("Product Name : ");
                        var productToDelete = ReadLine();

                        product = productDeleteRep.GetByProductName(productToDelete);
                        if (product != null)
                        {
                            productDeleteRep.Delete(product);
                            WriteLine("Product Delete... \n Please Press Enter To Go Back ");
                        }
                        else
                        {
                            WriteLine("Product Not found... \n Please Press Enter To Go Back ");
                        }
                        ReadLine();
                        break;


                    // Case 5: Option For Updata
                    case 5:
                        IProductRepository productUploadRep = new FileProductRepository();
                        WriteLine("Product Name For Upload : ");
                        var productToUpload = ReadLine();
                        product = productUploadRep.GetByProductName(productToUpload);
                        if (product != null)
                        {
                            WriteLine("Product Name :");
                            product.Name = ReadLine();

                            WriteLine("Please enter Price (,) : ");
                            product.Price = decimal.Parse(ReadLine());

                            WriteLine("Product ManuFacturer :");
                            product.ManuFacturer = ReadLine();

                            productUploadRep.Upload(product);
                        }
                        else
                        {
                            WriteLine("Product Not found... \n Please Press Enter To Go Back ");
                        }
                        break;
                    case 6:
                        IProductRepository productFindManu = new FileProductRepository();
                        WriteLine("ManuFacturer Name :");
                        var productToFindManu = ReadLine();
                        product = productFindManu.GetByManuFacturerName(productToFindManu);
                        if (product != null)
                        {
                            WriteLine("ManuFacturer Find ... \n Please Press Enter To Go Back  ");
                        }
                        else
                        {
                            WriteLine("ManuFacturer Not found... \n Please Press Enter To Go Back ");
                        }
                        ReadLine();

                        break;
                    case 7:
                        IProductRepository productFindPrice = new FileProductRepository();
                        WriteLine("Write Price :");
                        try
                        {
                            var maxPrice = decimal.Parse(ReadLine());
                            if(maxPrice > 0)
                            {
                                productFilter.SearchByPrice(maxPrice, productFindPrice.GetAll());
                            }
                            else
                            {
                                throw new FormatException();
                            }

                        }
                        catch (FormatException)
                        {
                            WriteLine("Invalid input");
                        }
                        WriteLine("\nPlease Press Enter To Go Back");
                        ReadLine();
                        break;
                    case 8:
                        new FileShopRepository().GetAll();
                        break;
                }


            } while (choice != 9);
        }

    }
}
