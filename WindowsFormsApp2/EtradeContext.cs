using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class EtradeContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
