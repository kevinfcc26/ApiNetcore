using Coworking.Api.DataAccess.Contracts;
using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.DataAccess.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess
{
   public  class CoworkingDBContext : DbContext, ICoworkingDBContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<AdminEntity> Admins { get; set; }
        public DbSet<BookingEntity> Bookings { get; set; }
        public DbSet<OfficeEntity> Offices { get; set; }
        public DbSet<Offices2RoomsEntity> Offices2Rooms { get; set; }
        public DbSet<Room2ServicesEntity> Room2Services { get; set; }
        public DbSet<RoomEntity> Rooms { get; set; }
        public DbSet<ServiceEntity> Services { get; set; }

        public CoworkingDBContext(DbContextOptions options): base(options) { }

        public CoworkingDBContext()
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuider)
        {
            AdminEntityConfig.SetEntityBuilder(modelBuider.Entity<AdminEntity>());
            BookingEntityConfig.SetEntityBuilder(modelBuider.Entity<BookingEntity>());
            Office2RoomEntityConfig.SetEntityBuilder(modelBuider.Entity<Offices2RoomsEntity>());
            OfficeEntityConfig.SetEntityBuilder(modelBuider.Entity<OfficeEntity>());
            Room2ServiceEntityConfig.SetEntityBuilder(modelBuider.Entity<Room2ServicesEntity>());
            RoomEntityConfig.SetEntityBuilder(modelBuider.Entity<RoomEntity>());
            ServiceEntityConfig.SetEntityBuilder(modelBuider.Entity<ServiceEntity>());
            UserEntityConfig.SetEntityBuilder(modelBuider.Entity<UserEntity>());

            base.OnModelCreating(modelBuider);
        }
    }
}
