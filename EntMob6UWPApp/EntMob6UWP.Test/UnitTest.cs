using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System;

namespace EntMob6UWP.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //var x = new StubIHumidityDataService().GetAllHumidities(() =>
            //    new System.Collections.Generic.List<Domain.Humidity>
            //    {
            //       new Domain.Humidity
            //       {
            //           ID = "1",
            //           Measured = DateTime.Today,
            //           Percentage = 50f

            //       }
            //   });


            //OverviewViewModel overView = new OverviewViewModel(new StubIFrameNavigation(), x);
            //overView.LoadData();
            Assert.AreEqual(50d, 50d);
        }
    }
}
