using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities
{
    public class Order : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        // 1 order'ın 1'den fazla (n tane) product'ı olacağı için yani 1'e çok ilişki olacak AMA aralarında ÇOKA ÇOK ilişki olduğu için Product bölümünde de aynı şekilde tanımlayınca ÇOKA ÇOK İLİŞKİ OLMUŞ OLACAK.
        public ICollection<Product> Products { get; set; }  

        // Order olarak senin sadece 1 TANE CUSTOMER'ın olabilir. YANİSİ 1'e Çok ilişki tanımı. Tekil isim verdim
        public Customer Customer { get; set; }
    }
}
