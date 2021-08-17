using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentCar.Shared.Domain;
using System;

namespace RentCar.Server.Configurations.Entities
{
    public class ModelSeedConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
                  new Model { CreatedBy = "System", DateCreated = DateTime.Now, DateUpdated = DateTime.Now, Name = "Toyota", UpdatedBy = "System", Id = 1 },
                  new Model { CreatedBy = "System", DateCreated = DateTime.Now, DateUpdated = DateTime.Now, Name = "Hyundai", UpdatedBy = "System", Id = 2 }
                  );
        }
    }
}
