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
    public class FloorsTest
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
        public void getFloorsTest()
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
                var target = new FloorsController(context);
                var result = target.GetFloors(location.ID);
                int count = 1;
                Assert.AreEqual(count, result.Count());
            }
        }

        [TestMethod]
        public void getFloorByIdTest()
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
                Location location = new Location();
                location.LocationFacilities = new List<LocationFacility>();
                location.LocationFacilities.Add(locationFacility);
                location.Name = "test";
                location.City = "test";
                location.Address = "test";
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
                var target = new FloorsController(context);
                var result = target.GetFloorById(location.ID, floor.ID);
                Assert.AreEqual(floor.Name, result.Name);
                Assert.AreEqual(location.ID, result.LocationId);
                Assert.AreEqual(floor.Created, result.Created);
                Assert.AreEqual(floor.Modified, result.Modified);
            }
        }
    }
}
