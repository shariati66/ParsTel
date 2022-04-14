using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace ParsTel.Buy
{
    public class buy
    {
        public int id { get; set; }
        public bool typeBuy { get; set; }
        public int customerCode { get; set; }
        public int customerGarantiCode { get; set; }

    }

    public class buyConfig:EntityTypeConfiguration<buy>
    {
        public buyConfig()
        {
            HasKey(x => x.id);
            Property(x => x.typeBuy).IsRequired();
            Property(x => x.customerCode).IsRequired();
            Property(x=>x.customerGarantiCode).IsOptional();
        }
    }
}
