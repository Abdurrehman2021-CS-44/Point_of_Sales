using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.BL;
using PointOfSale.DL;

namespace PointOfSale.UI
{
    class CustomerUI
    {
        public static Customer customer = new Customer();
        public static string takeProductName()
        {
            string name;
            Console.WriteLine("What you want to order : ");
            name = Console.ReadLine();
            return name;
        }
        public static void buyProduct()
        {
            string name = "";
            name = takeProductName();
            foreach (Product i in ProductDL.productList)
            {
                if (i.pName == name)
                {
                    int howMany;
                    Console.Write("Enter how many you want : ");
                    howMany = int.Parse(Console.ReadLine());
                    float bill = howMany * i.pPrice;
                    if(i.availableStock >= howMany)
                    {
                        i.availableStock = i.availableStock - howMany;
                    }
                    else
                    {
                        Console.WriteLine("We don't have as much as you want");
                        continue;
                    }
                    customer.bills.Add(bill);
                    Console.WriteLine("Thank you for shopping");
                    howMany = 0;
                }
            }
        }
        public static void genInvoice()
        {
            float sum = 0;
            foreach (float i in customer.bills)
            {
                sum = sum + i;
            }
            Console.WriteLine("You have to pay " + sum);
        }
    }
}
