using System;
using System.Collections.Generic;
using System.Text;

namespace HandRent.Service.Entities
{
    public class SettingEntity:BaseEntity
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
