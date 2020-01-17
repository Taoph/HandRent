using System;
using System.Collections.Generic;
using System.Text;

namespace HandRent.Service.Entities
{
    public class RegionEntity:BaseEntity
    {
        public string Name { get; set; }

        public long CityId { get; set; }
        public virtual CityEntity City { get; set; } 
    }
}
