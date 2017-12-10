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
    [Table("TPROPERTY")]
    class TPropertyClass
    {
        [Key]
        [Column("id")]
        public int id { get; set; }
        [Column("name")]
        public string name { get; set; }
        [Column("value")]
        public string value { get; set; }
        [Column("group_id")]
        public int group_id { get; set; }

    }
}
