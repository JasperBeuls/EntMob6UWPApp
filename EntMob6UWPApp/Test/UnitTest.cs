using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using EntMob6UWPApp.Services;
using EntMob6UWPApp;
using EntMob6UWPApp.ViewModels;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLatestHumidity()
        {
            var x = new StubIHumidityDataService().GetAllHumidities(() =>
            new System.Collections.Generic.List<EntMob6UWP.Domain.Humidity>
            {
               new EntMob6UWP.Domain.Humidity
               {
                   ID = "hh",
                   Measured = DateTime.Today,
                   Percentage=50d
               }
               
              
           })
           .GetLatestHumidity(()=>
             new EntMob6UWP.Domain.Humidity
             {
                 ID = "hh",
                 Measured = DateTime.Today,
                 Percentage = 50d
             }
               );
            OverviewViewModel vm = new OverviewViewModel(new StubIFrameNavigation(), x);
            vm.LoadData();
            Assert.AreEqual(vm.LatestHumidity.Percentage, 50,1);
            


            

        }
    }
}
