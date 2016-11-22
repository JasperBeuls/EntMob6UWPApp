using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using EntMob6UWPApp.Services;
using EntMob6UWPApp;
using EntMob6UWPApp.ViewModels;
using EntMob6UWPApp.View;

namespace Test
{
    [TestClass]
    public class OverViewViewModelTest
    {
        OverviewViewModel vm;
        Mocks.MockFrameNavigation mockFrameNavigation;
        [TestInitialize]
        public  void SetUp()
        {
           
            Mocks m = new Mocks();
            mockFrameNavigation = new Mocks.MockFrameNavigation();
            vm = new OverviewViewModel(mockFrameNavigation
                , m.getHumidityDataService(), m.getBrightnessDataService(), m.getAirPressureDataService(), m.getTemperatureDataService());

        }
        [TestMethod]
        public void TestLatestHumidity()
        {
            vm.LoadData();
            Assert.AreEqual(vm.LatestHumidity.Percentage, 50,0.1);
        }
        [TestMethod]
        public void TestLatestTemperature()
        {
            vm.LoadData();
            Assert.AreEqual(vm.LatestTemperature.Value, 51, 0.1);
        }
        [TestMethod]
        public void TestLatestBrightness()
        {
            vm.LoadData();
            Assert.AreEqual(vm.LatestBrightness.Value, 52, 0.1);
        }
        [TestMethod]
        public void TestLatestAirPressure()
        {
            vm.LoadData();
            Assert.AreEqual(vm.LatestAirPressure.Value, 53, 0.1);
        }
        [TestMethod]
        public void TestNavigationRequestCountOnHistory()
        {
           Assert.AreEqual(mockFrameNavigation.NavigationRequests.Count, 0);
           vm.HistoryCommand.Execute(null);
           Assert.AreEqual(mockFrameNavigation.NavigationRequests.Count, 1);
        }
        [TestMethod]
        public void TestNavigationRequestTypeOnHistory()
        {
           Assert.AreEqual(mockFrameNavigation.NavigationRequests.Count, 0);
           vm.HistoryCommand.Execute(null);
           Assert.AreEqual(mockFrameNavigation.NavigationRequests[0].Frame, typeof(AverageView));
        }

     
    }
}
