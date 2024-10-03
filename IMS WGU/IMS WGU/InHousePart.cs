using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSWGU
{
    public class InHousePart : Part
    {
        private int macID;
        public int MachineID { get; set; }
        public InHousePart() { }
        
        public InHousePart(int partID, string name, int inventory, decimal price, int max, int min, int machID)
        {
            PartID = partID;
            Name = name;
            Inventory = inventory;
            Price = price.ToString();
            Max = max;
            Min = min;
            MachineID = machID;
        }

    }
}
