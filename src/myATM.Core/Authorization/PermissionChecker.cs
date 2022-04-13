using Abp.Authorization;
using myATM.Authorization.Roles;
using myATM.Authorization.Users;

namespace myATM.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
