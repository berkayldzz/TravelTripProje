using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class Yorumlar
    {
        [Key]
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public int Blogid{ get; set; }

        // Bloglar ve Yorumlar arasında bir ilişki kurucaz
        // Blog tablosundan bir değer türeticem
        public virtual Blog Blog { get; set; } // Blogun idsi şeklinde tutulucak // Blog adlı propertyim Blog tablomdan gelcek değeri tutuyor.
        // Sanal olmasını istediğim için virtual ekledim





    }
}