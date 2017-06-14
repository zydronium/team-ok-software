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
    public class LocationsTest
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
        public void getLocationsTest()
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
                var target = new LocationsController(context);
                var result = target.GetLocations();
                int count = 1;
                Assert.AreEqual(count, result.Count());
            }
        }

        [TestMethod]
        public void getLocationByIdTest()
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
                var target = new LocationsController(context);
                var result = target.GetLocationById(location.ID);
                Assert.AreEqual(location.Name, result.Name);
                Assert.AreEqual(location.City, result.City);
                Assert.AreEqual(location.Address, result.Address);
                Assert.AreEqual(location.Latitude, result.Latitude);
                Assert.AreEqual(location.Longitude, result.Longitude);
                Assert.AreEqual(location.OpeningHours, result.OpeningHours);
                Assert.AreEqual(location.Phonenumber, result.Phonenumber);
                Assert.AreEqual(location.Postcode, result.Postcode);
                Assert.AreEqual(location.Created, result.Created);
                Assert.AreEqual(location.Modified, result.Modified);
            }
        }
    }
}
