using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using TASK_1.BL;

namespace TASK_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Products> product = new List<Products>();
            Products prod = new Products();
            int option = 0;
            List<string> menu = new List<string>() { "1. VIEW ITEM", "2. ADD ITEM", "3. DELETE ITEM","4. EXIT"};  
            
            while(true)
            {
                Console.Clear();
                option = view_option(menu);
                Console.Clear();
                if(option == 2)
                {
                    product.Add(add_products());
                }
                else if(option  == 1)
                {
                    view_products(product);
                }
                else if(option == 3)
                {
                    del_product(product);
                }
                else if(option == 4 )
                {
                    break;
                }

            }
        }
        // DELETE PRODUCTS
        static void del_product(List<Products> product)
        {
            for(int i = 0; i<product.Count; i++)
            {
                Console.SetCursorPosition(50, 5 + i);
                Console.WriteLine("{0}. NAME: {1} ", i+1, product[i].name);
            }
            Console.SetCursorPosition(10, 3);
            Console.WriteLine("ENTER THE INDEX: ");
            Console.SetCursorPosition(30, 3);
            int opt = int.Parse(Console.ReadLine()) - 1;
            product.RemoveAt(opt);
            Console.ReadKey();

        }
        // VIEW PRODUCTS
        static void view_products(List<Products> product)
        {
            for(int i = 0; i < product.Count; i++)
            {
                Console.WriteLine("NAME: {0} | PRODUCT: {1} | QUANTITY: {2} | COUNTRY: {3} ", product[i].name, product[i].category, product[i].quality, product[i].country);
            }
            Console.ReadKey();
        }
        // View options
        static int view_option(List<string> menu)
        {
            int opt;
            for(int i = 0; i < menu.Count ; i++ )
            {
                Console.SetCursorPosition(20,5 + i);
                Console.WriteLine(menu[i]);
            }
            Console.SetCursorPosition(20,3);
            Console.WriteLine("CHOSE ONE OPTION: ");
            Console.SetCursorPosition(40, 3);
            opt = int.Parse(Console.ReadLine());
            return opt;
            
        }
        // ADD ITEMS
        static Products add_products()
        {
            Products products = new Products();
            Console.WriteLine("ENTER PRODUCT NAME: ");
            products.name = Console.ReadLine();
            Console.WriteLine("ENTER PRODUCT PRICE: ");
            products.price = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER PRODUCT CATEGORY: ");
            products.category = (Console.ReadLine());
            Console.WriteLine("ENTER PRODUCT COUNTRY: ");
            products.country = (Console.ReadLine());
            Console.WriteLine("ENTER PRODUCT QUANTITY: ");
            products.quality = (Console.ReadLine());
            return products;
        }

    }
}
