using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public string BlogImage { get; set; }

        // 1 e çok ilişkiyi sağlamak için yorumları dahil etmek gerekiyor
        // 1 blogun birden fazla yorumu olabilir ama 1 yorum sadece 1 blog için geçerli 
        public ICollection<Yorumlar> Yorumlars { get; set; }
    
        // ICollection: Bir interfacedir listelemek,kümeleme gibi işlemlerde kullanılır.Hangi sınıf üzerinde tutulucaksa o yazılır daha sonrasında.
  
        
    }
}

