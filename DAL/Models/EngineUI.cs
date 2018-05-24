﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class EngineUI : BasePartsUI
    {
        public int Cylinders { get; set; }
        public double Liters { get; set; }
        public int HP { get; set; }
        public int Torque { get; set; }
        public string Type { get; set; }
        public override string ToString()
        {
            return "Name:" + Name + ", Type:" + Type + ", Cylinders:" + Cylinders + ", Liters:" + Liters + ", HP:" + HP + ", Torque: " + Torque + " PriceEngine: " + Price + ", Producer: " + Producer;
        }
    }
}
