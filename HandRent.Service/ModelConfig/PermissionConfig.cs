using HandRent.Service.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandRent.Service.ModelConfig
{
    public class PermissionConfig:EntityTypeConfiguration<PermissionEntity>
    {
        public PermissionConfig()
        {
            ToTable("T_Permissions");
            Property(e => e.Description).HasMaxLength(1024).IsOptional();
            Property(e => e.Name).HasMaxLength(50).IsRequired();
        }
    }
}
