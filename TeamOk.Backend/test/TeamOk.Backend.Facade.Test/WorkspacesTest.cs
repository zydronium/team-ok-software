using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamOk.Backend.Domain.DAL;
using TeamOk.Backend.Domain.Entities;
using TeamOk.Backend.Facade.Controllers;

namespace TeamOk.Backend.Facade.Test
{
    [TestClass]
    public class WorkspacesTest
    {
        private static DbContextOptions<BackendDBContext> CreateNewContextOptions()
        {
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkInMemoryDatabase()
                .BuildServiceProvider();
            var builder = new DbContextOptionsBuilder<BackendDBContext>();
            builder.UseInMemoryDatabase()
                .UseInternalServiceProvider(serviceProvider);
            return builder.Options;
        }

        [TestMethod]
        public void getWorkspacesTest()
        {
            var option = CreateNewContextOptions();
            using (var context = new BackendDBContext(option))
            {
                Facility facility = new Facility();
                facility.Name = "test";
                facility.Created = DateTime.Now;
                facility.Modified = DateTime.Now;
                context.facilities.Add(facility);
                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    throw;
                }
                LocationFacility locationFacility = new LocationFacility();
                locationFacility.FacilityID = facility.ID;
                locationFacility.FacilityInstance = facility;
                locationFacility.Created = DateTime.Now;
                locationFacility.Modified = DateTime.Now;
                locationFacility.Value = "Test";

                context.LocationFacilities.Add(locationFacility);
                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    throw;
                }
                FloorFacility floorFacility = new FloorFacility();
                floorFacility.FacilityID = facility.ID;
                floorFacility.FacilityInstance = facility;
                floorFacility.Created = DateTime.Now;
                floorFacility.Modified = DateTime.Now;
                floorFacility.Value = "Test";

                context.FloorFacilities.Add(floorFacility);
                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    throw;
                }
                WorkspaceFacility workspaceFacility = new WorkspaceFacility();
                workspaceFacility.FacilityID = facility.ID;
                workspaceFacility.FacilityInstance = facility;
                workspaceFacility.Created = DateTime.Now;
                workspaceFacility.Modified = DateTime.Now;
                workspaceFacility.Value = "Test";

                context.WorkspaceFacilities.Add(workspaceFacility);
                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    throw;
                }
                Location location = new Location();
                location.LocationFacilities = new List<LocationFacility>();
                location.LocationFacilities.Add(locationFacility);
                location.Name = "test";
                location.Latitude = 1.10;
                location.Longitude = 1.10;
                location.OpeningHours = "test";
                location.Phonenumber = "test";
                location.Postcode = "test";
                location.Created = DateTime.Now;
                location.Modified = DateTime.Now;

                context.Locations.Add(location);
                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    throw;
                }
                Floor floor = new Floor();
                floor.FloorFacilities = new List<FloorFacility>();
                floor.FloorFacilities.Add(floorFacility);
                floor.Name = "test";
                floor.Location = location;
                floor.Created = DateTime.Now;
                floor.Modified = DateTime.Now;

                context.Floors.Add(floor);
                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    throw;
                }
                Workspace workspace = new Workspace();
                workspace.WorkspaceFacilities = new List<WorkspaceFacility>();
                workspace.WorkspaceFacilities.Add(workspaceFacility);
                workspace.Name = "test";
                workspace.Floor = floor;
                workspace.Created = DateTime.Now;
                workspace.Modified = DateTime.Now;

                context.Workspaces.Add(workspace);
                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    throw;
                }
                var target = new WorkspacesController(context);
                var result = target.GetWorkspaces(floor.ID);
                int count = 1;
                Assert.AreEqual(count, result.Count());
            }
        }

        [TestMethod]
        public void getWorkspaceByIdTest()
        {
            var option = CreateNewContextOptions();
            using (var context = new BackendDBContext(option))
            {
                Facility facility = new Facility();
                facility.Name = "test";
                facility.Created = DateTime.Now;
                facility.Modified = DateTime.Now;
                context.facilities.Add(facility);
                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    throw;
                }
                LocationFacility locationFacility = new LocationFacility();
                locationFacility.FacilityID = facility.ID;
                locationFacility.FacilityInstance = facility;
                locationFacility.Created = DateTime.Now;
                locationFacility.Modified = DateTime.Now;
                locationFacility.Value = "Test";

                context.LocationFacilities.Add(locationFacility);
                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    throw;
                }
                FloorFacility floorFacility = new FloorFacility();
                floorFacility.FacilityID = facility.ID;
                floorFacility.FacilityInstance = facility;
                floorFacility.Created = DateTime.Now;
                floorFacility.Modified = DateTime.Now;
                floorFacility.Value = "Test";

                context.FloorFacilities.Add(floorFacility);
                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    throw;
                }
                WorkspaceFacility workspaceFacility = new WorkspaceFacility();
                workspaceFacility.FacilityID = facility.ID;
                workspaceFacility.FacilityInstance = facility;
                workspaceFacility.Created = DateTime.Now;
                workspaceFacility.Modified = DateTime.Now;
                workspaceFacility.Value = "Test";

                context.WorkspaceFacilities.Add(workspaceFacility);
                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    throw;
                }
                Location location = new Location();
                location.LocationFacilities = new List<LocationFacility>();
                location.LocationFacilities.Add(locationFacility);
                location.Name = "test";
                location.Latitude = 1.10;
                location.Longitude = 1.10;
                location.OpeningHours = "test";
                location.Phonenumber = "test";
                location.Postcode = "test";
                location.Created = DateTime.Now;
                location.Modified = DateTime.Now;

                context.Locations.Add(location);
                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    throw;
                }
                Floor floor = new Floor();
                floor.FloorFacilities = new List<FloorFacility>();
                floor.FloorFacilities.Add(floorFacility);
                floor.Name = "test";
                floor.Location = location;
                floor.Created = DateTime.Now;
                floor.Modified = DateTime.Now;

                context.Floors.Add(floor);
                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    throw;
                }
                Workspace workspace = new Workspace();
                workspace.WorkspaceFacilities = new List<WorkspaceFacility>();
                workspace.WorkspaceFacilities.Add(workspaceFacility);
                workspace.Name = "test";
                workspace.Floor = floor;
                workspace.Claimed = true;
                workspace.ClaimedUntill = DateTime.Now.AddHours(2.0);
                workspace.Created = DateTime.Now;
                workspace.Modified = DateTime.Now;

                context.Workspaces.Add(workspace);
                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    throw;
                }
                var target = new WorkspacesController(context);
                var result = target.GetWorkspaceById(floor.ID, workspace.ID);
                Assert.AreEqual(workspace.Name, result.Name);
                Assert.AreEqual(workspace.Claimed, result.Claimed);
                Assert.AreEqual(workspace.ClaimedUntill, result.ClaimedUntill);
                Assert.AreEqual(workspace.Created, result.Created);
                Assert.AreEqual(workspace.Modified, result.Modified);
            }
        }
    }
}
