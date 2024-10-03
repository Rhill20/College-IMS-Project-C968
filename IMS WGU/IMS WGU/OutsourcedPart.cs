using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSWGU
{
    public class OutsourcedPart : Part
    {   
        public string CompName { get; set; }
     
        public OutsourcedPart(int partID, string name, int inventory, decimal price, int max, int min, string compName)
        {
            PartID = partID;
            Name = name;
            Inventory = inventory;
            Price = price.ToString();
            Max = max;
            Min = min;
            CompName = compName;
        }
    }
}
