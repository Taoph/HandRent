using HandRent.Service.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandRent.Service.ModelConfig
{
    public class AttachmentConfig : EntityTypeConfiguration<AttachmentEntity>
    {
        public AttachmentConfig()
        {
            ToTable("T_Attachments");
            Property(e => e.Name).HasMaxLength(50).IsRequired();
            Property(e => e.IconName).HasMaxLength(50).IsUnicode(false).IsRequired();

            HasMany(e => e.Houses).WithMany(e => e.Attachments)
                .Map(t => t.ToTable("T_HouseAttachments").MapLeftKey("AttachmentId")
                .MapRightKey("HouseId"));
        }
    }
}