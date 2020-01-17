using HandRent.Service.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandRent.Service.ModelConfig
{
    public class HouseAppointmentConfig:EntityTypeConfiguration<HouseAppointmentEntity>
    {
        public HouseAppointmentConfig()
        {
            ToTable("T_HouseAppointments");
            HasOptional(e => e.User).WithMany().HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);
            HasRequired(e => e.House).WithMany().HasForeignKey(e => e.HouseId)
                .WillCascadeOnDelete(false);
            HasOptional(e => e.FollowAdminUser).WithMany().HasForeignKey(e => e.FollowAdminUserId)
                .WillCascadeOnDelete(false);
            Property(e => e.Name).HasMaxLength(20).IsRequired();
            Property(e => e.PhoneNum).HasMaxLength(20).IsRequired().IsUnicode(false);
            Property(e => e.Status).HasMaxLength(20).IsRequired();
            Property(e => e.RowVersion).IsRequired().IsRowVersion();
        }
    }
}
