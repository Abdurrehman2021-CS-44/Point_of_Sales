using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.BL
{
    class Product
    {
        public string pName;
        public string pCateg;
        public float pPrice;
        public int availableStock;
        public int minimumStock;
        public Product(string pName, string pCateg, float pPrice, int availableStock, int minimumStock)
        {
            this.pName = pName;
            this.pCateg = pCateg;
            this.pPrice = pPrice;
            this.availableStock = availableStock;
            this.minimumStock = minimumStock;
        }
        public float calculateSalesTax()
        {
            float tax;
            if (this.pCateg == "Grocery")
            {
                tax = this.pPrice * 0.05F;
            }
            if (this.pCateg == "Fruit")
            {
                tax = this.pPrice * 0.10F;
            }
            else
            {
                tax = this.pPrice * 0.15F;
            }
            return tax;
        }
    }
}
