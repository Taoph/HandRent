using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HandRent.Service.Entities
{
    public class PermissionEntity:BaseEntity
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public virtual ICollection<RoleEntity> Roles { get; set; }
            = new List<RoleEntity>();
    }
}
