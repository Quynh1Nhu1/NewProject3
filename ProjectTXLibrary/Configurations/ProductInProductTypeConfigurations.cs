using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectTXServer.Entity;

namespace ProjectTXServer.Configurations
{
    public class ProductInProductTypeConfigurations : IEntityTypeConfiguration<ProductInProductType>
    {
        public void Configure(EntityTypeBuilder<ProductInProductType> builder)
        {
            builder.ToTable("ProductInProductType");
            builder.HasKey(t => new { t.ProductTypeId,t.ProductId });
            builder.HasOne(t => t.ProductTypeObj).WithMany(ur => ur.ListType)
     .HasForeignKey(pc => pc.ProductTypeId);
            builder.HasOne(t => t.ProductObj).WithMany(ur => ur.ListProduct)
     .HasForeignKey(pc => pc.ProductId);
        }
    }
}
