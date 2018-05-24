using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ExteriorUI : BasePartsUI
    {
        public string Colour { get; set; }
        public string TypeOfPaint { get; set; }
        public override string ToString()
        {
            return "Name:" + Name + ", TypeOfPaint:" + TypeOfPaint + ", Colour:" + Colour + " PriceExterior: " + Price + ", Producer: " + Producer;
        }
    }
}
