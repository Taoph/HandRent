using HandRent.Service.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandRent.Service.ModelConfig
{
    public class CityConfig:EntityTypeConfiguration<CityEntity>
    {
        public CityConfig()
        {
            ToTable("T_Cities");
            Property(t => t.Name).HasMaxLength(20);
        }
    }
}
