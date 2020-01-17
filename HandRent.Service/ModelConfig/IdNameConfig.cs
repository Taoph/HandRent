using HandRent.Service.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandRent.Service.ModelConfig
{
    public class IdNameConfig:EntityTypeConfiguration<IdNameEntity>
    {
        public IdNameConfig()
        {
            ToTable("T_IdNames");
            Property(e => e.TypeName).HasMaxLength(1024).IsRequired();
            Property(e => e.Name).HasMaxLength(1024).IsRequired();
        }
    }
}
