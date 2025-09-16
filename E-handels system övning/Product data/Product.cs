using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_handels_system_övning.Product_data
{
    public class Product
    {
        public static double GlobalDiscount = 0.0;
        public static int NextId = 1;
        public static int TotalCount = 0;


        public int Id;
        public string Name;
        public string Brand;
        public double Price;


        public Product()
        {
            Id = NextId;
            NextId++;
            TotalCount++;
        }

        public virtual string productInformation()
        {
            return $"{Id}, {Name}, {Brand}, {Price}";
        }


        public virtual double FinalPrice()
        {
            double discountFactor = 1 - GlobalDiscount;
            return Price * discountFactor;
        }


        public static void SetGlobalDiscountPercent(double percent)
        {
            GlobalDiscount = percent / 100;
        }
    }
}
