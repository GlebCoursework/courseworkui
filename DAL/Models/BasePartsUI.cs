using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{

    public class BasePartsUI //батьківський класс з основними полями на які ссилаються інші класу, в якому данні конвертуються з WCF в DAL UI
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Producer { get; set; }

        public decimal Price { get; set; }

        public virtual ICollection<CarUI> Cars { get; set; }

    }

}
