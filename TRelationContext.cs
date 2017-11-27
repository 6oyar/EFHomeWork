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
    class TRelationContext : DbContext
    {
        public TRelationContext(string conneсtionName) : base(conneсtionName)
        {
        }
        public virtual DbSet<TRelationClass> TRelationProperty { get; set; }
    }
}
