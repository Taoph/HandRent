using HandRent.Service.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandRent.Service.ModelConfig
{
    public class HouseConfig:EntityTypeConfiguration<HouseEntity>
    {
        public HouseConfig()
        {
            ToTable("T_Houses");
            HasRequired(e => e.Community).WithMany().HasForeignKey(e => e.CommunityId)
                .WillCascadeOnDelete(false);
            HasRequired(e => e.RoomType).WithMany().HasForeignKey(e => e.RoomTypeId)
                .WillCascadeOnDelete(false);
            HasRequired(e => e.Status).WithMany().HasForeignKey(e => e.StatusId)
                .WillCascadeOnDelete(false);
            HasRequired(e => e.DecorateStatus).WithMany().HasForeignKey(e => e.DecorateStatusId)
                .WillCascadeOnDelete(false);
            HasRequired(e => e.Type).WithMany().HasForeignKey(e => e.DecorateStatusId)
                .WillCascadeOnDelete(false);

            Property(e => e.Description).IsOptional();
            Property(e => e.Address).HasMaxLength(128).IsRequired();
            Property(e => e.Direction).IsRequired().HasMaxLength(20);
            Property(e => e.OwnerName).HasMaxLength(20).IsRequired();
            Property(e => e.OwnerPhoneNum).HasMaxLength(20).IsRequired().IsUnicode(false);


        }
    }
}
