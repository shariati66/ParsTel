using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace ParsTel.Buy
{
    public class buyInfo_goods
    {
        public int id { get; set; }
        public int buyCode { get; set; } //FK for Buy
        public int goodsCode { get; set; }//FK for commodity table
        public int numbers { get; set; } // number of goods

    }
    public class buyInfoConfig:EntityTypeConfiguration<buyInfo_goods>
    {
        public buyInfoConfig()
        {
            HasKey(x => x.id);
            Property(x => x.buyCode).IsRequired();
            Property(x => x.goodsCode).IsRequired();
            Property(x=>x.numbers).IsRequired();
        }
    }
}
