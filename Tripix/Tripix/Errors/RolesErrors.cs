using Tripix.Abstractions;

namespace Tripix.Errors
{
    public static class RolesErrors
    {
        public static readonly Error RoleNotFound = new("Role Not found", "This Role Not Found", StatusCodes.Status404NotFound);
    }
}
