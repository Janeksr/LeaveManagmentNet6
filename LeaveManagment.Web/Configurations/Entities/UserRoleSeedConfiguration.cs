using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagment.Web.Configurations.Entites
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "a1951852-04a8-4eef-9538-13b21627a185",
                    UserId = "119acbc4-bb39-436b-a66e-b60c6d634395"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "a1951852-04c8-2eef-9238-13b31627b185",
                    UserId = "119acbc4-bb39-426b-b645-160c3ef3c3a5"
                }
            );
        }
    }
}