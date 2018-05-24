using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class InteriorUI : BasePartsUI
    {
        public string Colour { get; set; }
        public string Material { get; set; }
        public override string ToString()
        {
            return "Name:" + Name + ", Colour:" + Colour + ", Material:" + Material + " PriceInterior: " + Price + ", Producer: " + Producer;
        }
    }
}
