using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectTXServer.Entity;

namespace ProjectTXServer.Configurations
{
    public class ProductInLocationConfigurations : IEntityTypeConfiguration<ProductInLocation>
    {
        public void Configure(EntityTypeBuilder<ProductInLocation> builder)
        {
            builder.ToTable("ProductInLocation");
            builder.HasKey(t => new { t.ProductId,t.LocateId });
            builder.HasOne(t => t.ProductObj).WithMany(ur => ur.ListProductLocation)
     .HasForeignKey(pc => pc.ProductId);
            builder.HasOne(t => t.LocationObj).WithMany(ur => ur.ListProductLocation)
     .HasForeignKey(pc => pc.LocateId);
        }
    }
}
