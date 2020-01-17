using System;
using System.Collections.Generic;
using System.Text;

namespace HandRent.Service.Entities
{
    public class AttachmentEntity:BaseEntity
    {
        public string Name { get; set; }
        public string IconName { get; set; }
        public virtual ICollection<HouseEntity> Houses { get; set; }
        = new List<HouseEntity>();
    }
}
