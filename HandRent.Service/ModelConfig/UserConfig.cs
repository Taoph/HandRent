using HandRent.Service.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandRent.Service.ModelConfig
{
    public class UserConfig:EntityTypeConfiguration<UserEntity>
    {
        public UserConfig()
        {
            ToTable("T_Users");
            HasRequired(e => e.City).WithMany().HasForeignKey(e => e.CityId)
                .WillCascadeOnDelete(false);
            Property(e => e.PasswordSalt).HasMaxLength(20).IsRequired();
            Property(e => e.PasswordHash).HasMaxLength(100).IsRequired();
            Property(e => e.PhoneNum).HasMaxLength(20).IsUnicode(false).IsRequired();
        }
    }
}
