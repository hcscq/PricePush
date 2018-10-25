using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using wms_transmitter.Models.Mapping;

namespace wms_transmitter.Models
{
    public partial class BIW_KSOAContext : DbContext
    {
        static BIW_KSOAContext()
        {
            Database.SetInitializer<BIW_KSOAContext>(null);
        }

        public BIW_KSOAContext()
            : base("Name=BIW_KSOAContext")
        {
        }
        public DbSet<price_Data> price_Data { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new price_DataMap());
        }
    }
}
