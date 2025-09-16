using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_handels_system_övning.Product_data
{
    public class Book : Product
    {

        public string Author;

        public override string productInformation()
        {
            return $"The book {Name} was written by {Author} and published by {Brand}. The price is {Price}";
        }

    }
}
