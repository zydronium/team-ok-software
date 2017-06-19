using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamOk.Backend.Domain.Entities;

namespace TeamOk.Backend.Domain.DAL
{
    public class BackendDBContext : DbContext
    {
        public BackendDBContext(DbContextOptions<BackendDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Location> Locations { get; set; }
        public DbSet<LocationFacility> LocationFacilities { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<FloorFacility> FloorFacilities { get; set; }
        public DbSet<Workspace> Workspaces { get; set; }
        public DbSet<WorkspaceFacility> WorkspaceFacilities { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<NotificationType> NotificationType { get; set; }
        public DbSet<Occupation> Occupations { get; set; }
        public DbSet<Facility> facilities { get; set; }
    }
}
