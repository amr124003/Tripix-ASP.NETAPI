using Microsoft.AspNetCore.Identity;

namespace Tripix.SEEDING
{
    public class Seedrole
    {
        public static async Task InitializeAsync ( IServiceProvider serviceProvider )
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            var rolesWithStamps = new Dictionary<string, string>
               {
                   { "User", Guid.NewGuid().ToString() },
                   { "Admin", Guid.NewGuid().ToString() },
                   { "SuperAdmin", Guid.NewGuid().ToString() },
                   { "Driver", Guid.NewGuid().ToString() },
               };

            foreach (var kvp in rolesWithStamps)
            {
                var roleName = kvp.Key;
                var stamp = kvp.Value;

                if (!await roleManager.RoleExistsAsync(roleName))
                {
                    var role = new IdentityRole
                    {
                        Name = roleName,
                        NormalizedName = roleName.ToUpper(),
                        ConcurrencyStamp = stamp
                    };

                    await roleManager.CreateAsync(role);
                }
            }
        }
    }
}
