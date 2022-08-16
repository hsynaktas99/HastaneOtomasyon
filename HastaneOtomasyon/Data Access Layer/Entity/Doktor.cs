using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Data_Access_Layer.Entity
{
    [Table(name:"Doktorlar")]
    class Doktor
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DoktorId { get; set; }

        public string DoktorAdi { get; set; }

        public string DoktorCinsiyeti { get; set; }

        public byte DoktorBransi { get; set; }

    }
}
