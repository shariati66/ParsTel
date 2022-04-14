using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParsTel.kala
{
    public class commodity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        public int type { get; set; }
        public int gNumber { get; set; }
        public string gComments { get; set; }
        public string model { get; set; }
        public string brand { get; set; }
        public int price { get; set; }
        public string gName { get; set; }

    }

    public class commodityConfig:EntityTypeConfiguration<commodity>
    {
        public commodityConfig()
        {
            HasKey(x => x.id);
            Property(x=>x.type).IsRequired();
            Property(x=>x.gNumber).IsRequired();
            Property(x=>x.price).IsRequired();
           
            Property(x=>x.model).IsRequired();
            Property(x=>x.brand).IsRequired();
            Property(x=>x.gName).IsRequired();  
        }
    }
}
