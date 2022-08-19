using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectTXServer.Entity;

namespace ProjectTXServer.Configurations
{
    public class ProductInGenderConfigurations : IEntityTypeConfiguration<ProductInGender>
    {
        public void Configure(EntityTypeBuilder<ProductInGender> builder)
        {
            builder.ToTable("ProductInGender");
            builder.HasKey(t => new { t.GenderId,t.ProductId });
            builder.HasOne(t => t.GenderObj).WithMany(ur => ur.ListGender)
     .HasForeignKey(pc => pc.GenderId);
            builder.HasOne(t => t.ProductObj).WithMany(ur => ur.ListProductGender)
     .HasForeignKey(pc => pc.ProductId);
        }
    }
}
