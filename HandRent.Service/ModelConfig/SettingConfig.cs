using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data.Entity.ModelConfiguration;
using HandRent.Service.Entities;

namespace HandRent.Service.ModelConfig
{
    public class SettingConfig : EntityTypeConfiguration<SettingEntity>
    {
        public SettingConfig()
        {
            ToTable("T_Settings");
            Property(s => s.Name).IsRequired().HasMaxLength(1024);
            Property(s => s.Value).IsRequired();
        }
    }
}