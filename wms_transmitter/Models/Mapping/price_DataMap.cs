using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace wms_transmitter.Models.Mapping
{
    public class price_DataMap : EntityTypeConfiguration<price_Data>
    {
        public price_DataMap()
        {
            // Primary Key
            this.HasKey(t => new { t.spid, t.hw });

            // Properties
            this.Property(t => t.spid)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(11);

            this.Property(t => t.hw)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(11);

            this.Property(t => t.spbh)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("price_Data");
            this.Property(t => t.spid).HasColumnName("spid");
            this.Property(t => t.hw).HasColumnName("hw");
            this.Property(t => t.chbdj).HasColumnName("chbdj");
            this.Property(t => t.lastModifyTime).HasColumnName("lastModifyTime");
            this.Property(t => t.LastUploadTime).HasColumnName("LastUploadTime");
            this.Property(t => t.is_pushed).HasColumnName("is_pushed");
            this.Property(t => t.spbh).HasColumnName("spbh");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
