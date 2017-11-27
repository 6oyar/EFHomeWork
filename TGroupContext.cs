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
    class TGroupContext : DbContext
    {
        public TGroupContext(string conneсtionName) : base(conneсtionName)
        {
        }
        public virtual DbSet<TGroupClass> TGroupProperty { get; set; }

    }
}
