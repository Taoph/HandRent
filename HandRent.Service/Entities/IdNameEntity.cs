using System;
using System.Collections.Generic;
using System.Text;

namespace HandRent.Service.Entities
{
    public class IdNameEntity:BaseEntity
    {
        public string TypeName { get; set; }
        public string Name { get; set; }
    }
}
