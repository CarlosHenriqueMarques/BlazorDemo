using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentCar.Shared.Domain;
using System;

namespace RentCar.Server.Configurations.Entities
{
    public class MakeSeedConfiguration : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData(
                  new Make { CreatedBy = "System", DateCreated = DateTime.Now, DateUpdated = DateTime.Now, Name = "Toyota", UpdatedBy = "System", Id = 1 },
                  new Make { CreatedBy = "System", DateCreated = DateTime.Now, DateUpdated = DateTime.Now, Name = "Hyundai", UpdatedBy = "System", Id = 2 }
                  );
        }
    }
}
