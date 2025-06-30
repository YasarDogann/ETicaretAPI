using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        // Burada 1'e çok ilişki var yani 1 müşterinin birden fazla siparişi olabilr
        //public ICollection<Order> Orders { get; set; }
    }
}
