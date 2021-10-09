using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.EntitySeeding
{
    public class UserRoleSeedingConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "932ab41a-fdf0-4d0c-be4e-47414fceaf99",
                    UserId = "004938fa-d152-4d77-80fa-9ebd905e6175"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "86bafafe-3271-467f-b6ea-32967995ac65",
                    UserId = "b53e7d87-f37e-4ac9-83fd-26dfbe1d032e"
                });
        }
    }
}
