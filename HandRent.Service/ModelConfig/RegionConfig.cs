using HandRent.Service.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandRent.Service.ModelConfig
{
    public class RegionConfig:EntityTypeConfiguration<RegionEntity>
    {
        public RegionConfig()
        {
            ToTable("T_Regions");
            Property(t => t.Name).IsRequired().HasMaxLength(20);
            HasRequired(t => t.City).WithMany().HasForeignKey(e => e.CityId)
                .WillCascadeOnDelete(false);
        }
    }
}
