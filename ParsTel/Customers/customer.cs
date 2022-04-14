using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParsTel.Customers
{
    public class customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        public string lname { get; set; }
        public string fname { get; set; }
        public string fatherName { get; set; }
        public string city { get; set; }
        public string shenasnameID { get; set; }
        public string birthPlace { get; set; }
        public string melli { get; set; }
        public string sadere { get; set; }
        public string address { get; set; }
        public string postalCode { get; set; }
        public string mobile { get; set; }
        public string phone { get; set; }

    }

    public class CustomersConfig:EntityTypeConfiguration<customer>
    {
        public CustomersConfig()
        {
            HasKey(x => x.id);
            Property(x=>x.lname).IsRequired().HasMaxLength(50);
            Property(x=>x.fname).IsRequired().HasMaxLength(50);
            Property(x=>x.fatherName).IsOptional().HasMaxLength(50);
            Property(x=>x.city).IsOptional().HasMaxLength(50);
            Property(x=>x.shenasnameID).IsOptional().HasMaxLength(50);
            Property(x=>x.birthPlace).IsOptional().HasMaxLength(50);
            Property(x=>x.melli).IsRequired().HasMaxLength(10);
            Property(x=>x.sadere).IsOptional().HasMaxLength(50);
            Property(x=>x.address).IsOptional().HasMaxLength(200);
            Property(x=>x.postalCode).IsOptional().HasMaxLength(11);
            Property(x=>x.mobile).IsRequired().HasMaxLength(100);
            Property(x=>x.phone).IsOptional().HasMaxLength(11);


        }
    }
}
