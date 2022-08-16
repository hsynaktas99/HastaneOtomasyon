using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Data_Access_Layer.Entity
{
    [Table("Branslar")]
    class Brans
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte BransId { get; set; }
        
        public string BransAdi { get; set; }
       
    }
}
