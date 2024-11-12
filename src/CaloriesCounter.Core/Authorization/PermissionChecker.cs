using Abp.Authorization;
using CaloriesCounter.Authorization.Roles;
using CaloriesCounter.Authorization.Users;

namespace CaloriesCounter.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
