using System;
using System.Collections.Generic;
using System.Text;

namespace HandRent.Service.Entities
{
    public class RoleEntity:BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<AdminUserEntity> AdminUsers { get; set; } 
            = new List<AdminUserEntity>();

        public virtual ICollection<PermissionEntity> Permissions { get; set; } 
            = new List<PermissionEntity>();
    }
}
