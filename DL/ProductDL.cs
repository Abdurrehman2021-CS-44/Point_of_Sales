using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.BL;
using PointOfSale.UI;
using System.IO;

namespace PointOfSale.DL
{
    class ProductDL
    {
        public static List<Product> productList = new List<Product>();
        
        public static void addIntoTheList(Product p)
        {
            productList.Add(p);
        }
        public static List<Product> highestPriceUnit()
        {
             return productList.OrderByDescending(o => o.pPrice).ToList();
        }
        public static bool loadIntoList(string path)
        {
            StreamReader file = new StreamReader(path);
            string record = "";
            if (File.Exists(path))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedString = record.Split(',');
                    string name = splittedString[0];
                    string category = splittedString[1];
                    float price = float.Parse(splittedString[2]);
                    int quantity = int.Parse(splittedString[3]);
                    int minimumStock = int.Parse(splittedString[4]);
                    Product p = new Product(name, category, price, quantity, minimumStock);
                    addIntoTheList(p);
                }
                file.Close();
                return true;
            }
            return false;
        }
        public static void storeDataIntoFile(string path, Product p)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(p.pName + "," + p.pCateg + "," + p.pPrice + "," + p.availableStock + "," + p.minimumStock);
            file.Flush();
            file.Close();
        }
    }
}
