using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class CarUI
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Status { get; set; }

        public virtual EngineUI Engine { get; set; }

        public virtual GearboxUI Gearbox { get; set; }

        public virtual InteriorUI Interior { get; set; }

        public virtual ExteriorUI Exterior { get; set; }
    }
}
