using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Data_Access_Layer.Entity

{
    [Table(name:"Randevular")]
    class Randevu
    {
        [Key]
        public int RandevuId { get; set; }

        public string HastaAdi { get; set; }
        public string HastaSoyadi { get; set; }
        public string HastaCinsiyeti { get; set; }
        public byte HastaYasi { get; set; }
        public byte HastaBransi { get; set; }
        public int HastaDoktoru { get; set; }
        public DateTime RandevuTarihi { get; set; }
    }
}
