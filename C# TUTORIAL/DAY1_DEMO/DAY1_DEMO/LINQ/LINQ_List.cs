global using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY1_DEMO.LINQ
{
    internal class LINQ_List
    {

        class ProductStore
        {
            public string productName { get; set; }
            public int productPrice { get; set; }
        }

        static void MainFn(string[] args)
        {
            IList<ProductStore> productList = new List<ProductStore>();

            productList.Add(new ProductStore() { productName = "Bathing Bar",productPrice = 50});
            productList.Add(new ProductStore() { productName = "Washing Bar",productPrice = 30});
            productList.Add(new ProductStore() { productName = "Toilet Soap",productPrice = 40});
            productList.Add(new ProductStore() { productName = "Shampoo",productPrice = 70});
            productList.Add(new ProductStore() { productName = "Conditioner",productPrice = 90});
            productList.Add(new ProductStore() { productName = "FaceCream",productPrice = 125});
            productList.Add(new ProductStore() { productName = "Shaving Blade",productPrice = 30});

            var items = from item in productList select item;
            //var result = productList.Select(p => p);  //Method Query

            Console.WriteLine("Item Name         <==>     Item Price");
            foreach (var item in items)
            {
                Console.WriteLine($" {item.productName}            {item.productPrice}");
            }

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.productName);
            //}

            //



            //## Where Filter



            var result = from p in productList
                         where p.productPrice > 20 && p.productPrice < 70
                         select p;

            var filter = productList.Where(p => p.productPrice > 20 && p.productPrice < 100);

            Console.WriteLine("-------------------------Where Filter-------------------------------------");
            foreach (var item in result)
            {
                Console.WriteLine(item.productName);
            }


            Console.WriteLine("--------------------------------------------------------------");
            foreach (var item2 in filter)
            {
                Console.WriteLine(item2.productName);
            }
            




            //## PRINT RESULT USING LINQ SYNTAX
            Console.WriteLine("--------------------PRINT RESULT USING LINQ SYNTAX----------------------------------");

            result.ToList().ForEach(p => Console.WriteLine("Product Name: {0} | Product Price: {1}", p.productName, p.productPrice));



            //## LIST PRODUCT IN ASCENDING ORDER
            Console.WriteLine("--------------------LIST PRODUCT IN ASCENDING ORDER----------------------------------");
            result = productList.OrderBy(p => p.productPrice);
            //result = from p in productList orderby p.productPrice select p;    LINQ Query Method

            result.ToList().ForEach(p => Console.WriteLine("Product Name {0}  Price {1}", p.productName, p.productPrice));






            Console.ReadKey();
        }
    }
}
