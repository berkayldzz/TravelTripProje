using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class BlogYorum
    {
        // Hangi tablolarımdan veri çekiceksem veya hangi tablolarımda işlem gerçekleştiriceksem o tabloları buraya bir IEnumareble(bir interface) formatında yazmam gerekiyor.
        // IEnumareble: Belli sayıdaki değerleri bir koleksiyon formatında toplayan yapıdır.
        // IEnumareble aracılığıyla bir view üzerinden birden fazla değer çekebilicem.
        // Normalde en yukarıdaki modelin içinde ne yazarsa o tabloya ait verileri çekebiliyoduk.
        // Ama IEnumareble sayesinde bir view üzerinde birden fazla değer çekebilicez.
        public IEnumerable<Blog> Deger1 { get; set; }
        public IEnumerable<Yorumlar> Deger2 { get; set; }
        public IEnumerable<Blog> Deger3 { get; set; }

    }
}