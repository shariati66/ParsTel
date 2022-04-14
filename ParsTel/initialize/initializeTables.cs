using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace ParsTel.initialize
{
    public class initializeTables
    {
        public int id { get; set; }
        public int customerCode { get; set; }
        public int goodsCode { get; set; }
        public int typeGoodsCode { get; set; }

    }
    public class initializeTablesConfig:EntityTypeConfiguration<initializeTables>
    {
        public initializeTablesConfig()
        {
           HasKey(t => t.id);
            Property(t => t.customerCode).IsRequired();
            Property(t => t.goodsCode).IsRequired(); 
        }
    }
}
