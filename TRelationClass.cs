using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace TestWinApp
{
    [Table("TRELATION")]
    class TRelationClass
    {
        [Key]
        [Column("id_parent", Order = 1)]
        public int idPparent { get; set; }
        [Key]
        [Column("id_child", Order = 2)]
        public int idChild { get; set; }


    }
}
