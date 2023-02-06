using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.BL;
using PointOfSale.DL;

namespace PointOfSale.UI
{
    class ProductUI
    {
        public static Product takeInputForProduct()
        {
            string pName, pCateg;
            float pPrice;
            int availableStock, minimumStock;
            Console.Write("Enter Name : ");
            pName = Console.ReadLine();
            Console.Write("Enter Category : ");
            pCateg = Console.ReadLine();
            Console.Write("Enter Price : ");
            pPrice = float.Parse(Console.ReadLine());
            Console.Write("Enter Quantity : ");
            availableStock = int.Parse(Console.ReadLine());
            Console.Write("Enter Minimum Stock : ");
            minimumStock = int.Parse(Console.ReadLine());
            Product product = new Product(pName, pCateg, pPrice, availableStock, minimumStock);
            return product;
        }
        public static void viewProducts()
        {
            Console.WriteLine("Name\tCategory\tPrice\tQuantity");
            foreach (Product i in ProductDL.productList)
            {
                Console.WriteLine(i.pName + "\t" + i.pCateg + "\t" + i.pPrice + "\t" + i.availableStock);
            }
        }
        public static void highestPriceProduct()
        {
            List<Product> sortedProductList = ProductDL.highestPriceUnit();
            Console.WriteLine("Highest Unit Price Product");
            Console.WriteLine("--------------------------");
            if (sortedProductList.Count >= 1)
            {
                Console.WriteLine("Name : " + sortedProductList[0].pName);
                Console.WriteLine("Category : " + sortedProductList[0].pCateg);
                Console.WriteLine("Price : " + sortedProductList[0].pPrice);
                Console.WriteLine("Quantity : " + sortedProductList[0].availableStock);
            }
        }
        public static void viewSalesTax()
        {
            Console.WriteLine("Name\tCategory\tTax");
            foreach (Product i in ProductDL.productList)
            {
                Console.WriteLine(i.pName + "\t" + i.pCateg + "\t" + i.calculateSalesTax());
            }
        }
        public static void lessThanThresholdProducts()
        {
            foreach (Product i in ProductDL.productList)
            {
                if (i.availableStock < i.minimumStock)
                {
                    Console.WriteLine("You have to order " + i.pName);
                }
            }
        }
    }
}
