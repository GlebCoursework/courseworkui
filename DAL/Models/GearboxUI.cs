using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class GearboxUI : BasePartsUI
    {
        public string Type { get; set; }
        public int Quantity { get; set; }
        public override string ToString()
        {
            return "Name:" + Name + ", Type:" + Type + ", Gears:" + Quantity + " PriceGearbox: " + Price + ", Producer: " + Producer;

        }
    }
}
