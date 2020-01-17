using HandRent.Service.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandRent.Service.ModelConfig
{
    public class RoleConfig:EntityTypeConfiguration<RoleEntity>
    {
        public RoleConfig()
        {
            ToTable("T_Roles");
            Property(e => e.Name).HasMaxLength(50).IsRequired();
            HasMany(e => e.Permissions).WithMany(e => e.Roles)
                .Map(t => t.ToTable("T_RolePermissions").MapLeftKey("RoleId").MapRightKey("PermissionId"));

        }
    }
}
