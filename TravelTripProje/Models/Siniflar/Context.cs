using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Hierarchy;

namespace TravelTripProje.Models.Siniflar
{
    public class Context : DbContext  // İlgili tablolarıma ulaşabilmem için DbContext sınıfından miras almam gerekiyor
    {
        // Sınıflarımı(tablolarımı) veri tabanına yansıtmak için oluşturduğum sınıf

        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdresBlog> AdresBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<iletisim> iletisims { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }





    }
}