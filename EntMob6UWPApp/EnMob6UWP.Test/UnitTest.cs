using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
namespace EnMob6UWP.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //var x = new StubIHumidityDataService().GetAllHumidities(() => new List<Humidity>
            //{
            //    new Humidity() {ID ="lala",Measured = DateTime.Today,Percentage = 75}
            //});
            //OverviewViewModel classUnderTest = new OverviewViewModel(new StubIFrameNavigation(),new HumidityDataService());

            //classUnderTest.LoadData();
            //Assert.AreEqual(75,classUnderTest.LatestHumidity.Percentage,0.01);
            Assert.Equals(1, 1);
        }
    }
}
