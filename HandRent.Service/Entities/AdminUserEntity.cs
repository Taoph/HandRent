using System;
using System.Collections.Generic;
using System.Text;

namespace HandRent.Service.Entities
{
    public class AdminUserEntity:BaseEntity
    {
        public string Name { get; set; }
        public string PhoneNum { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }

        public string Email { get; set; }

        public int LoginErrorTimes { get; set; }
        /// <summary>
        /// 此处为DateTime?类型
        /// </summary>
        public DateTime? LastLoginErorDateTime { get; set; }
        public long? CityId { get; set; }
        public CityEntity City { get; set; }

        public virtual ICollection<RoleEntity> Roles { get; set; }
        = new List<RoleEntity>();

    }
}
