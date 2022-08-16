using HastaneOtomasyon.Data_Access_Layer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Data_Access_Layer.Context
{
    class HastaneOtomasyonContext : DbContext
    {
        
        public DbSet<Brans> Branslar { get; set; } 
        public DbSet<Doktor> Doktorlar { get; set; }
        public DbSet<Randevu> Randevular { get; set; }
    }
}
