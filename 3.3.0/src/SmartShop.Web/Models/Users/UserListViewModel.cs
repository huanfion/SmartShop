using System.Collections.Generic;
using SmartShop.Roles.Dto;
using SmartShop.Users.Dto;

namespace SmartShop.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}