using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.UI
{
    class MenuUI
    {
        public static void header()
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("             POINT OF SALES          ");
            Console.WriteLine("*************************************");
        }
        public static string mainMenu()
        {
            header();
            Console.WriteLine();
            Console.WriteLine("Menu");
            Console.WriteLine("----");
            Console.WriteLine("1. Sign In");
            Console.WriteLine("2. Sign Up");
            Console.WriteLine("3. Exit");
            string option;
            Console.Write("Your Option...");
            option = Console.ReadLine();
            return option;
        }
        public static string adminMenu()
        {
            header();
            Console.WriteLine();
            Console.WriteLine("Admin's Menu");
            Console.WriteLine("------------");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View All Product");
            Console.WriteLine("3. Find Product with Highest Unit Price");
            Console.WriteLine("4. View Sales Tax of All Products");
            Console.WriteLine("5. Product to be Ordered");
            Console.WriteLine("6. Exit");
            string option;
            Console.Write("Your Option...");
            option = Console.ReadLine();
            return option;
        }
        public static string userMenu()
        {
            header();
            Console.WriteLine();
            Console.WriteLine("User's Menu");
            Console.WriteLine("-----------");
            Console.WriteLine("1. View All Product");
            Console.WriteLine("2. Buy the Product");
            Console.WriteLine("3. Generate Invoice");
            Console.WriteLine("4. Exit");
            string option;
            Console.Write("Your Option...");
            option = Console.ReadLine();
            return option;
        }
    }
}
