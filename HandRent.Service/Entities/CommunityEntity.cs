using System;
using System.Collections.Generic;
using System.Text;

namespace HandRent.Service.Entities
{
    public class CommunityEntity:BaseEntity
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Traffic { get; set; }
        public int? BuiltYear{get;set;}
        public long RegionId { get; set; }
        public virtual RegionEntity Region { get; set; }
    }
}
