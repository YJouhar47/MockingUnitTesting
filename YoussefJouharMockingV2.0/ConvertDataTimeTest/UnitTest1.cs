using Moq;
using System;
using NUnit.Framework;
using YoussefJouharMockingV2._0;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;

namespace ConvertDataTimeTest
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var x = DateTime.Parse("2021-12-10T20:56:38.379161+01:00");
            var showModeOfDay = new ShowModeOfDay();
            var WorldTime = new Mock<IAskIpAddress>();
            var datetime = new WorldTimeByIP() {datetime = x};
            WorldTime.Setup(x => x.GetWorldTimeByIpAsync(new HttpClient(), "url")).Returns(datetime);
            var result = WorldTime.Object.GetWorldTimeByIpAsync(new HttpClient(), "url");
            TestContext.WriteLine("Je bent anders" + result.datetime);
            var y = showModeOfDay.ConvertTimeTowardsSentence(datetime: result.datetime); //Geeft niets terug, waarom ?
            Assert.AreEqual(y, "Nacht");
            
        }
    }
}