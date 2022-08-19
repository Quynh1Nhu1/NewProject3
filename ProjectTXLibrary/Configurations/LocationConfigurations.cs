using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectTXServer.Entity;

namespace ProjectTXServer.Configurations
{
    public class LocationConfigurations : IEntityTypeConfiguration<AreaLocation>
    {
        public void Configure(EntityTypeBuilder<AreaLocation> builder)
        {
            builder.ToTable("Area");
            builder.HasKey(t => new { t.LocateId });
        }
    }
}
