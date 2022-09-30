using Hauler_Up.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hauler_Up.Infastructure.Mappings
{
    public class TrawlMapping : IEntityTypeConfiguration<Trawl>
    {
        public void Configure(EntityTypeBuilder<Trawl> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Name).IsRequired().HasColumnType("varchar(50)");

            builder.HasMany(t => t.Catches).WithOne(c => c.Trawl).HasForeignKey(c => c.TrawlId);

            builder.ToTable("Trawl");
        }
    }
}
