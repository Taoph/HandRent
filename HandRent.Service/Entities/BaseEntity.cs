using System;
using System.Collections.Generic;
using System.Text;

namespace HandRent.Service.Entities
{
    public abstract class BaseEntity
    {
        public long Id { get; set; }
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
      
    }
}
