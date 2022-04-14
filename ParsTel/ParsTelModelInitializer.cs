using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParsTel.Customers;
using ParsTel.initialize;

namespace ParsTel
{
    public class ParsTelModelInitializer: DropCreateDatabaseIfModelChanges<ParsTelModel>
    {
        protected override void Seed(ParsTelModel ptm)
        {
            
            //add username initial
            users usr=new users();
            usr.username = "admin";
            usr.password = "admin";

            ptm.Users.Add(usr);
            

            initializeTables initTable=new initializeTables();
            initTable.customerCode = 1;
            initTable.goodsCode = 100;
            initTable.typeGoodsCode = 1000;

            ptm.InitializeTables.Add(initTable);

            ptm.SaveChanges();
            base.Seed(ptm);
        }
    }
}
