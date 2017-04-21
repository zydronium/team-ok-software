using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamOk.Backend.Domain.DAL;

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
            PostCursusViewModel PostCursusViewModel = new PostCursusViewModel();
            using (var context = new CASDBContext(option))
            {
                Cursus cursus = new Cursus();
                cursus.Cursuscode = "test";
                cursus.Duur = 5;
                cursus.Titel = "Test";
                context.Cursussen.Add(cursus);
                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    throw;
                }
                CursusInstantie cursusInstantie = new CursusInstantie();
                cursusInstantie.StartDatum = DateTime.Now;
                cursusInstantie.WeekNummer = DateTimeHelpers.GetWeekNumber(cursusInstantie.StartDatum);
                cursusInstantie.CursusID = cursus.ID;

                context.CursusInstanties.Add(cursusInstantie);
                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    throw;
                }
                var target = new CursusController(context);
                var result = target.GetCursussen();
                int count = 1;
                Assert.AreEqual(count, result.Count());
            }
        }
    }
}
