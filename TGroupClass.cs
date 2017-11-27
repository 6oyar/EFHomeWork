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
    [Table("TGROUP")]
    class TGroupClass
    {
        [Key]
        [Column("id")]
        public int id { get; set; }
        [Column("name")]
        public string name { get; set; }

    }

}
