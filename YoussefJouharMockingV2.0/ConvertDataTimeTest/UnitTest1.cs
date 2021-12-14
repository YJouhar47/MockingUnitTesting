using Moq;
using System;
using NUnit.Framework;
using YoussefJouharMockingV2._0;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;

namespace ConvertDataTimeTest
{
    [TestFixture]
    public class Tests
    {
        /*[Test]
        public void TestDay_ShouldBeInvalid() 
        {
            var x = DateTime.Parse("2021-12-10T65:25:20.379161+01:00");
            var showModeOfDay = new ShowModeOfDay();
            var WorldTime = new Mock<IAskIpAddress>();
            var datetime = new WorldTimeByIP() { datetime = x };
            WorldTime.Setup(x => x.GetWorldTimeByIpAsync(It.IsAny<HttpClient>(), It.IsAny<string>())).Returns(datetime);
            var result = WorldTime.Object.GetWorldTimeByIpAsync(new HttpClient(), "url");
            var y = showModeOfDay.ConvertTimeTowardsSentence(datetime: result.datetime); //
            Assert.AreEqual(y, "Invalid Data");
        }
        */
        [Test]
        public void TestDay_Should_Work()
        {
            var x = DateTime.Parse("2021-12-10T11:25:20.379161+01:00");
            var showModeOfDay = new ShowModeOfDay();
            var WorldTime = new Mock<IAskIpAddress>();
            var datetime = new WorldTimeByIP() { datetime = x };
            WorldTime.Setup(x => x.GetWorldTimeByIpAsync(It.IsAny<HttpClient>(), It.IsAny<string>())).Returns(datetime);
            var result = WorldTime.Object.GetWorldTimeByIpAsync(new HttpClient(), "url");
            var y = showModeOfDay.ConvertTimeTowardsSentence(datetime: result.datetime); //
            Assert.AreEqual(y, "Day");

        }

        [Test]
        public void TestNoon_Should_Work()
        {
            var x = DateTime.Parse("2021-12-10T13:25:20.379161+01:00");
            var showModeOfDay = new ShowModeOfDay();
            var WorldTime = new Mock<IAskIpAddress>();
            var datetime = new WorldTimeByIP() { datetime = x };
            WorldTime.Setup(x => x.GetWorldTimeByIpAsync(It.IsAny<HttpClient>(), It.IsAny<string>())).Returns(datetime);
            var result = WorldTime.Object.GetWorldTimeByIpAsync(new HttpClient(), "url");
            var y = showModeOfDay.ConvertTimeTowardsSentence(datetime: result.datetime); //
            Assert.AreEqual(y, "Noon");

        }

        [Test]
        public void TestEvening_Should_Work()
        {
            var x = DateTime.Parse("2021-12-10T19:25:20.379161+01:00");
            var showModeOfDay = new ShowModeOfDay();
            var WorldTime = new Mock<IAskIpAddress>();
            var datetime = new WorldTimeByIP() { datetime = x };
            WorldTime.Setup(x => x.GetWorldTimeByIpAsync(It.IsAny<HttpClient>(), It.IsAny<string>())).Returns(datetime);
            var result = WorldTime.Object.GetWorldTimeByIpAsync(new HttpClient(), "url");
            var y = showModeOfDay.ConvertTimeTowardsSentence(datetime: result.datetime); //
            Assert.AreEqual(y, "Evening");

        }

        [Test]
        public void TestNight_Should_Work()
        {
            var x = DateTime.Parse("2021-12-10T00:56:38.379161+01:00");
            var showModeOfDay = new ShowModeOfDay();
            var WorldTime = new Mock<IAskIpAddress>();
            var datetime = new WorldTimeByIP() { datetime = x };
            WorldTime.Setup(x => x.GetWorldTimeByIpAsync(It.IsAny<HttpClient>(), It.IsAny<string>())).Returns(datetime);
            var result = WorldTime.Object.GetWorldTimeByIpAsync(new HttpClient(), "url");
            var y = showModeOfDay.ConvertTimeTowardsSentence(result.datetime); //
            TestContext.WriteLine(result.datetime);
            TestContext.WriteLine("Verwachte resultaat :" + y);
            Assert.AreEqual(y, "Night");

        }
    }
}