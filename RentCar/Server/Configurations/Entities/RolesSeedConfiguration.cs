using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentCar.Shared.Domain;
using System;

namespace RentCar.Server.Configurations.Entities
{
    public class RolesSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                 new IdentityRole { Id = "847373b0-ff6f-11eb-9a03-0242ac130003", Name = "User", NormalizedName = "USER" },
                 new IdentityRole { Id = "1a77b329-1d10-4fb7-be20-6cbfea1b0865", Name = "Administrator", NormalizedName = "ADMINISTRATOR" }
                 );
        }
    }
}
