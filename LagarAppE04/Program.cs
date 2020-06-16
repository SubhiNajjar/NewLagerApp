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
    class Program
    {
        static void Main()
        {

            int choice = 0;

            do
            {
                Clear();
                WriteLine("1. List all items");
                WriteLine("2. Add");
                WriteLine("3. Find");
                WriteLine("4. Delete");
                WriteLine("5. Update");
                WriteLine("6. Exit");
                Write("Please, select a Number from 1 to 6: ");
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
                        


                        break;

                    // Case 4 : Option For Delete
                    case 4:
                        break;


                    // Case 5: Option For Updata
                    case 5:
                        break;

                }


            } while (choice != 6);
        }


    }
}
