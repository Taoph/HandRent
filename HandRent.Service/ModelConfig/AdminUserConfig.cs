using HandRent.Service.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandRent.Service.ModelConfig
{
    public class AdminUserConfig:EntityTypeConfiguration<AdminUserEntity>
    {
        public AdminUserConfig()
        {
            ToTable("T_AdminUsers");
            HasOptional(e => e.City).WithMany().HasForeignKey(e => e.CityId)
                .WillCascadeOnDelete(false);
            //这里WithMany没有设置参数
            HasMany(e => e.Roles).WithMany(r=>r.AdminUsers).Map(m => m.ToTable("T_AdminUserRoles")
              .MapLeftKey("AdminUserId").MapRightKey("RoleId"));
            Property(e => e.Name).HasMaxLength(50).IsRequired();
            Property(e => e.Email).HasMaxLength(30).IsRequired().IsUnicode(false);
            Property(e => e.PhoneNum).HasMaxLength(20).IsRequired().IsUnicode(false);
            Property(e => e.PasswordSalt).HasMaxLength(20).IsRequired().IsUnicode(false);
            Property(e => e.PasswordHash).HasMaxLength(100).IsRequired().IsUnicode(false);
        }
    }
}
