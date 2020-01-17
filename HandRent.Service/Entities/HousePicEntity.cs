using System;
using System.Collections.Generic;
using System.Text;

namespace HandRent.Service.Entities
{
    public class HousePicEntity:BaseEntity
    {
        public long HouseId { get; set; }
        public virtual HouseEntity House { get; set; }
        public string Url { get; set; }
        public string ThumbUrl { get; set; }

      
    }
}
