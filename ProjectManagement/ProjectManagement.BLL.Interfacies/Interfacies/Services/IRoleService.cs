﻿using System.Collections.Generic;

namespace ProjectManagement.BLL.Interfacies.Interfacies.Services
{
    public interface IRoleService
    {
        bool IsUserInRole(string username, string roleName);
        
        IEnumerable<BllRole> GetUserRoles(string username);
        
        void AddUserInRole(string username, string roleName);
        
        void RemoveUserFromRole(string username, string roleName);
        
        void UpdateUserRoles(string username, IEnumerable<int> rolesIds);
        
        IEnumerable<BllUser> GetUsersInRole(string roleName);
        
        IEnumerable<BllRole> GetAllRoles();
    }
}