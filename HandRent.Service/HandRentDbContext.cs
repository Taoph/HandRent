using HandRent.Service.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HandRent.Service
{
    class HandRentDbContext:DbContext
    {
        public HandRentDbContext():base("name=connStr")
        {
            //不再使用Migration自动生成数据库
            Database.SetInitializer<HandRentDbContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations
                .AddFromAssembly(typeof(HandRentDbContext).Assembly);
        }

        public DbSet<AdminLogEntity> AdminLogs{ get; set; }
        public DbSet<AdminUserEntity> AdminUsers { get; set; }
        public DbSet<AttachmentEntity> Attachments { get; set; }
        public DbSet<CityEntity> Cities { get; set; }
        public DbSet<CommunityEntity> Communities { get; set; }
        public DbSet<HouseAppointmentEntity> HouseAppointments { get; set; }
        public DbSet<HouseEntity> Houses { get; set; }
        public DbSet<HousePicEntity> HousePics { get; set; }
        public DbSet<IdNameEntity> IdNames { get; set; }
        public DbSet<PermissionEntity> Permissions { get; set; }
        public DbSet<RegionEntity> RegionEntities { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }
        public DbSet<SettingEntity> Settings { get; set; }
        public DbSet<UserEntity> Users { get; set; }
    }
}
