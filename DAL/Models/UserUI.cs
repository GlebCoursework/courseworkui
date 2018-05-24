using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class UserUI
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; }
        public override string ToString()
        {
            return "Login:" + Login + ", Password:" + Password + ", Balance:" + Balance;
        }
    }
}
