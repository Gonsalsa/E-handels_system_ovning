using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_handels_system_övning.Product_data
{
    public class Clothing : Product
    {
        public string Size;
        public override string productInformation()
        {
            return $"The {Name} by {Brand}, size: {Size}, cost {Price}";
        }

    }

}


