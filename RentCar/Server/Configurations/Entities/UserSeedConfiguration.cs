using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentCar.Server.Models;

namespace RentCar.Server.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hash = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser { Id = "82be2896-012f-4170-aec2-e011f4660980", Email = "admin@localhost.com",NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    FirstName = "Admin",LastName = "Admin",UserName="Admin",NormalizedUserName = "ADMIN",PasswordHash = hash.HashPassword(null,"P@ssword1") }
                );
        }
    }
}
