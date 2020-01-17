using HandRent.Service.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandRent.Service.ModelConfig
{
    public class CommunityConfig:EntityTypeConfiguration<CommunityEntity>
    {
        public CommunityConfig()
        {
            ToTable("T_Communities");
            Property(e => e.Name).IsRequired().HasMaxLength(20);
            HasRequired(e => e.Region).WithMany().HasForeignKey(e => e.RegionId).WillCascadeOnDelete(false);
            Property(e => e.Location).IsRequired().HasMaxLength(1024);
            
        }
    }
}
