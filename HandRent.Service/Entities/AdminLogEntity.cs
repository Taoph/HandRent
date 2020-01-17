using System;
using System.Collections.Generic;
using System.Text;

namespace HandRent.Service.Entities
{
    public class AdminLogEntity:BaseEntity
    {
        public long AdminUserId { get; set; }
        public virtual AdminUserEntity AdminUser { get; set; }
        public string Message { get; set; }
    }
}
