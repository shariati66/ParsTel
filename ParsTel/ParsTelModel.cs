using System;
using System.Data.Entity;
using System.Linq;
using ParsTel.Customers;
using ParsTel.initialize;
using ParsTel.kala;

namespace ParsTel
{
    public class ParsTelModel : DbContext
    {
        // Your context has been configured to use a 'ParsTelModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ParsTel.ParsTelModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ParsTelModel' 
        // connection string in the application configuration file.
        public ParsTelModel()
            : base("name=ParsTelModel")
        {
            Database.SetInitializer<ParsTelModel>( new ParsTelModelInitializer());
            
        }
        /// <summary>
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomersConfig());
            modelBuilder.Configurations.Add(new initializeTablesConfig());
            modelBuilder.Configurations.Add(new commodityConfig());
            base.OnModelCreating(modelBuilder);
        }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<users> Users { get; set; }
        public virtual DbSet<customer> Customers { get; set; } 
        public virtual DbSet<initializeTables> InitializeTables { get; set; }
        public virtual DbSet<commodity> Commodity { get; set; }
        public virtual DbSet<TypeGoods> TypeGoods { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}