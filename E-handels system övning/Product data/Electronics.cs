using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_handels_system_övning.Product_data
{
    public class Electronics : Product
    {
        public int WarrantyYears;
        public override string productInformation()
        {
            return $"The {Name} by {Brand} cost {Price} and have {WarrantyYears} years warranty ";
        }
    }

}

