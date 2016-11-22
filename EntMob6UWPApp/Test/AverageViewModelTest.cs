using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using EntMob6UWPApp.Services;
using EntMob6UWPApp;
using EntMob6UWPApp.ViewModels;
using EntMob6UWPApp.View;

namespace Test
{
    [TestClass]
    public class AverageViewModelTest
    {
        AverageViewModel vm;
        Mocks.MockFrameNavigation mockFrameNavigation;
        [TestInitialize]
        public  void SetUp()
        {
           
            Mocks m = new Mocks();
            mockFrameNavigation = new Mocks.MockFrameNavigation();
            vm = new AverageViewModel(mockFrameNavigation
                , m.getHumidityDataAverageService(), m.getBrightnessDataAverageService(), m.getTemperatureDataAverageService(),m.getAirPressureDataAverageService());
            vm.CurrentFilter = "Day";
        }
        [TestMethod]
        public void TestAverageHumidity()
        {
           
            vm.SwitchClassCommand.Execute("Humidity");
            Assert.AreEqual(vm.Averages[0].Average, 53,0.1);
        }
        [TestMethod]
        public void TestAverageTemperature()
        {
            vm.SwitchClassCommand.Execute("Temperature");
            Assert.AreEqual(vm.Averages[0].Average, 50, 0.1);
        }
        [TestMethod]
        public void TestAverageBrightness()
        {
            vm.SwitchClassCommand.Execute("Brightness");
            Assert.AreEqual(vm.Averages[0].Average, 52, 0.1);
        }
        [TestMethod]
        public void TestAverageAirPressure()
        {
            vm.SwitchClassCommand.Execute("AirPressure");
            Assert.AreEqual(vm.Averages[0].Average, 51, 0.1);
        }
        [TestMethod]
        public void TestNavigationRequestCountOnOverView()
        {
           Assert.AreEqual(mockFrameNavigation.NavigationRequests.Count, 0);
           vm.OverviewCommand.Execute(null);
           Assert.AreEqual(mockFrameNavigation.NavigationRequests.Count, 1);
        }
       [TestMethod]
        public void TestNavigationRequestTypeOnHistory()
        {
          Assert.AreEqual(mockFrameNavigation.NavigationRequests.Count, 0);
          vm.OverviewCommand.Execute(null);
           Assert.AreEqual(mockFrameNavigation.NavigationRequests[0].Frame, typeof(OverviewView));
       }

     
    }
}
