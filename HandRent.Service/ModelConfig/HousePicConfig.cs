using HandRent.Service.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandRent.Service.ModelConfig
{
    public class HousePicConfig:EntityTypeConfiguration<HousePicEntity>
    {
        public HousePicConfig()
        {
            ToTable("T_HousePics");
            HasRequired(e => e.House).WithMany().HasForeignKey(e => e.HouseId)
                .WillCascadeOnDelete(false);
            Property(e => e.Url).HasMaxLength(1024).IsRequired();
            Property(e => e.ThumbUrl).HasMaxLength(1024).IsRequired();

        }
    }
}
