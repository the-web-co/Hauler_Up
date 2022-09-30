using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hauler_Up.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hauler_Up.Infastructure.Mappings
{
    public class CatchMapping : IEntityTypeConfiguration<Catch>
    {
        public void Configure(EntityTypeBuilder<Catch> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Date).IsRequired();

            builder.Property(c => c.Market).IsRequired();

            builder.Property(c => c.Canner).IsRequired();

            builder.Property(c => c.TrawlId).IsRequired();

            builder.ToTable("Catch");

        }

    }
}
